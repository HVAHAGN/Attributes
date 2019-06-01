using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.DisplayMember = nameof(Student.FullName);
        }

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int count = (int)numericUpDown1.Value;
            Student[] students = CreateRandomStudent(count).ToArray();
            listBox1.Items.AddRange(students);
        }

        private IEnumerable<Student> CreateRandomStudent(int count)
        {
            var rnd = new Random();
            for (int i = 1; i <= count; i++)
            {
                yield return new Student
                {
                    Name = $"A{i}",
                    Surname = $"A{i}yan",
                    Age = (byte)rnd.Next(17, 40)
                };
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = listBox1.SelectedItem;
        }
    }
}
