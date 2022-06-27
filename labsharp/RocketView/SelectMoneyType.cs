using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketView
{
    public partial class SelectMoneyType : Form
    {
        private readonly IEnumerable<Type> paymantTypes;

        public Type SelectedType { get; private set; }

        public SelectMoneyType(IEnumerable<Type> paymantTypes)
        {
            InitializeComponent();

            this.paymantTypes = paymantTypes;

            SelectedType = null;
        }

        private void selectMoneyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = paymantTypes.First(type => type.Name == selectMoneyComboBox.SelectedItem.ToString());
            agreeButton.Enabled = true;
        }

        private void SelectDoctorType_Load(object sender, EventArgs e)
        {
            // fill combo box
            selectMoneyComboBox.Items.AddRange(paymantTypes.Select(type => type.Name).ToArray());
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            // кнопка доступна только при выборе, поэтому можно сразу закрыть
            if (SelectedType == null)
                MessageBox.Show("Вы не выбрали тип выплат");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}