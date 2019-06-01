using CbaTestApp_Soap.CbaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CbaTestApp_Soap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GateSoapClient cbaService = new GateSoapClient();
            ExchangeRates rate = cbaService.ExchangeRatesByDate(DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(CreateStudents(15).ToArray());
        }

        private IEnumerable<Student> CreateStudents(int count)
        {
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                yield return new Student
                {
                    Name = $"A{i + 1}",
                    Surname = $"A{i + 1}yan",
                    Email = $"A{i + 1}@gmail.com",
                    Age = rnd.Next(15, 45)
                };
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = listBox1.SelectedItem;
        }
    }
}
