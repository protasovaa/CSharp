using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using lab4csharp;
namespace lab4csharp
{
    public partial class Main : Form
    {
        Assembly models;
        IEnumerable<Type> types;

        Type type;
        object Object;

        MethodInfo method;
        object[] methodParameters;


        public Main()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {   
            models = Assembly.Load("NewPaperModel");
            types = models.GetTypes().Where(type => type.GetInterface("Paper") != null && !type.IsAbstract);
            ObjComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }
        void FillMethodsComboBox()
        {
            MethodsComboBox.Items.Clear();
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodsComboBox.Items.AddRange(type.GetMethods().Where(method => !objectMethods.Contains(method.Name) ).Select(method => method.Name).ToArray());
        }
        object Input(string message)
        {
            Read nf = new Read(message);
            nf.ShowDialog();
            this.Enabled = true;
            if(Int32.TryParse(nf.number,out int n))
            {
                return Convert.ToInt32(nf.number);
            }
            else
            {
                return nf.number;
            }
            
        }

        object InputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                    item.SetValue(newObject, Input("input " + item.Name));
            }

            return newObject;
        }

        void ShowObjectFields()
        {
            fieldsListBox.Items.Clear();

            foreach (var item in type.GetProperties())
            {
                fieldsListBox.Items.Add(item.Name + ": " + item.GetValue(Object));
            }
        }


        private void ObjComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = types.First(type => type.Name == ObjComboBox.SelectedItem.ToString());
            Object = null;
            FillMethodsComboBox();
            CreateObjButton.Enabled = true;
            ObjComboBox.Enabled = true;
            InputFieldsButton.Enabled = false;
            RunMethodButton.Enabled = false;
            fieldsListBox.Items.Clear();
        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            method = type.GetMethods().First(Method => Method.Name == MethodsComboBox.SelectedItem.ToString());
            RunMethodButton.Enabled = false;
            if (method.GetParameters().Length == 0)
            {
                InputFieldsButton.Enabled = false;
                RunMethodButton.Enabled = Object != null;
            }
            else
                InputFieldsButton.Enabled = true;
            methodParameters = null;
            paramsListBox.Items.Clear();
            foreach (var item in method.GetParameters())
            {
                paramsListBox.Items.Add(item.Name);
            }
        }

        private void CreateObjButton_Click(object sender, EventArgs e)
        {
            Object = InputObject(type);
            if (method?.GetParameters().Length == 0)
                RunMethodButton.Enabled = true;
            ShowObjectFields();
        }

        private void RunMethodButton_Click(object sender, EventArgs e)
        {
            if (method.ReturnType == typeof(void))
            {
                method.Invoke(Object, methodParameters);
                MessageBox.Show("Метод выполнен");
            }
            else
                MessageBox.Show(method.Invoke(Object, methodParameters).ToString());
            ShowObjectFields();
        }

        private void InputFieldsButton_Click(object sender, EventArgs e)
        {
            if (method.GetParameters()[0].ParameterType.Name == "Paper")
                methodParameters = new object[1] { InputObject(type) };
            else if (method.GetParameters().Length != 0)
                methodParameters = method.GetParameters().Select(param => Input("input " + param.Name)).ToArray();
            if (Object != null)
                RunMethodButton.Enabled = true;
        }
    }
}
