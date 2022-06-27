using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using RocketModel;   

namespace RocketView
{
    public partial class MainForm : Form
    {
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewModel> viewModels;
        object viewModelsLocker;

        Painter painter;


        ViewObject insurance, gym;

        List<Astronaut> astronaut;
        object astronautsLocker;

        List<Launch> launch;

        int maxCompetitionsNumber;

        IEnumerable<Type> paymantTypes;

        List<string> notifications;

        Image astronautImage,
            moneyImage,
            homeImage,
            rocetImage,
            insuranceImage;

        private TextBox notificationTextBox;
        private PictureBox pictureBox;

        public MainForm()
        {
            InitializeComponent();

            InitImages();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();

            astronaut = new List<Astronaut>();
            astronautsLocker = new object();

            paymantTypes = Assembly.Load("RocketModel").GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IInserance") != null);


            notifications = new List<string>();

            maxCompetitionsNumber = (int)(pictureBox.Height / rocetImage.Height);

            launch = new List<Launch>();
        }

        void InitImages()
        {
            astronautImage = Properties.Resources.Astronaut;
            moneyImage = Properties.Resources.Money;
            homeImage = Properties.Resources.Home;
            rocetImage = Properties.Resources.Rocet;
            insuranceImage = Properties.Resources.Insurance;
        }

        void Notification(string message)
        {
            notificationTextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count >= 15)
                {
                    notifications = notifications.GetRange(5, 9);

                    notificationTextBox.Text = "";

                    foreach (var item in notifications)
                    {
                        notificationTextBox.Text += item + "\r\n\r\n";
                    }
                }

                notificationTextBox.Text += message + "\r\n\r\n";
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            painter.Stop();

            foreach (var item in launch)
            {
                item.IsCanceled = true;
            }

            foreach (var item in viewModels)
            {
                if (item is ViewModel viewModel)
                    viewModel.Model.IsCanceled = true;
            }
        }

        void InputPersonModel(PersonModel personModel)
        {

            InputStringDialog inputLastName = new InputStringDialog(new WordValidator(), "Введите Фамилию");

            if (inputLastName.ShowDialog() == DialogResult.OK)
            {
                personModel.LastName = inputLastName.Value;
            }

            InputStringDialog inputFirstName = new InputStringDialog(new WordValidator(), "Введите Имя");

            if (inputFirstName.ShowDialog() == DialogResult.OK)
            {
                personModel.FirstName = inputFirstName.Value;
            }
        }

        private void AddAstronautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Astronaut newAstronaut = new Astronaut(Notification, gym.X, gym.Y);

            InputPersonModel(newAstronaut);


            lock (astronautsLocker)
            {
                astronaut.Add(newAstronaut);
            }

            lock (viewModels)
            {
                viewModels.Add(new ViewModel(newAstronaut, astronautImage));
            }

            Task.Run(newAstronaut.Start);
        }

        private void AddMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type paymantType = typeof(Alive);

            SelectMoneyType selectMoneyType = new SelectMoneyType(paymantTypes);

            if (selectMoneyType.ShowDialog() == DialogResult.OK)
            {
                paymantType = selectMoneyType.SelectedType;
            }

            Insurance money = Activator.CreateInstance(paymantType,
                new object[] { (Action<string>)Notification, insurance.X, insurance.Y, astronaut, astronautsLocker }) as Insurance;

            InputPersonModel(money);

            lock (viewModelsLocker)
            {
                viewModels.Add(new ViewModel(money, moneyImage));
            }

            Task.Run(money.Start);
        }
        void SetBuildingsSize()
        {
            insurance.X = pictureBox.Width - insuranceImage.Width / 2;
            insurance.Y = insuranceImage.Height / 2;


            gym.X = pictureBox.Width - homeImage.Width / 2;
            gym.Y = pictureBox.Height - homeImage.Height / 2;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        void AddRocket(string launchName, int maxParticipatingAstronautsNumber)
        {
            float x = rocetImage.Width / 2,
                y = rocetImage.Height / 2;

            y += launch.Count() * rocetImage.Height;

            launch.Add(new Launch(Notification, astronaut, astronautsLocker, x, y, launchName, maxParticipatingAstronautsNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(rocetImage, x, y));
            }

            Task.Run(launch[launch.Count() - 1].Start);

            if (launch.Count() >= maxCompetitionsNumber)
                AddRocketToolStripMenuItem.Enabled = false;
        }
        private void AddRocketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputCompettionName = new InputStringDialog(new WordValidator(), "Введите имя ракеты");

            string name = "";

            if (inputCompettionName.ShowDialog() == DialogResult.OK)
                name = inputCompettionName.Value;

            InputStringDialog inputMaxParticipatingSAstronautsNumber = new InputStringDialog(new NotNegativeIntValidator(),
                "Введите количество астронавтов");

            if (inputMaxParticipatingSAstronautsNumber.ShowDialog() == DialogResult.OK)
                AddRocket(name, Int32.Parse(inputMaxParticipatingSAstronautsNumber.Value));
            else
                AddRocket(name, 1);
        }

        void GenerateAstronauts(int astronautsNumber)
        {

            for (int i = 0; i < astronautsNumber; i++)
            {
                var newAstronaut = new Astronaut(Notification, gym.X, gym.Y)
                {
                    LastName = "SpLast" + i.ToString(),
                    FirstName = "SpFirst" + i.ToString()
                };

                astronaut.Add(newAstronaut);

                viewModels.Add(new ViewModel(newAstronaut, astronautImage));

                Task.Run(newAstronaut.Start);
            }
        }

        void GenerateMoney(int moneyNumber)
        {
            object[] moneyArgs = new object[]
           { (Action<string>)Notification,
                insurance.X,
                insurance.Y,
                astronaut,
                astronautsLocker };

            for (int i = 0; i < moneyNumber; i++)
            {
                foreach (var item in paymantTypes)
                {
                    Insurance newMoney = Activator.CreateInstance(item, moneyArgs) as Insurance;
                    newMoney.LastName = "DtLast" + i.ToString();
                    newMoney.FirstName = "DtFirst" + i.ToString();

                    viewModels.Add(new ViewModel(newMoney, moneyImage));

                    Task.Run(newMoney.Start);
                }
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoneyToolStripMenuItem.Enabled = true;
            AddAstronautToolStripMenuItem.Enabled = true;
            StartToolStripMenuItem.Enabled = false;
            AddRocketToolStripMenuItem.Enabled = true;

            painter = new Painter(pictureBox, Color.FromArgb(128, 255, 128),
               new Font(notificationTextBox.Font.FontFamily, 10f, notificationTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);


            insurance = new ViewObject(insuranceImage);
            gym = new ViewObject(homeImage);

            SetBuildingsSize();

            viewObjects.Add(insurance);
            viewObjects.Add(gym);

            AddRocket("Заупуск 1", 3);

            GenerateAstronauts(8);

            GenerateMoney(1);

            painter.Start();
        }

    }
}