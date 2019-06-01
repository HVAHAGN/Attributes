using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyFramework;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMoneyTypes();
        }

        private void InitMoneyTypes()
        {
            foreach (MoneyType item in Enum.GetValues(typeof(MoneyType)))
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoneyType mt = (MoneyType)comboBox1.SelectedItem;
            textBox1.Text = numericUpDown1.Value.ToMoneyToString(mt);
        }
    }
}
