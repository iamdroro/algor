using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Rocт: {stud.rost} \n Вес: {stud.GE()}"));
            double ew = 1.0;
            stud.eda(1);
            
            MessageBox.Show(string.Format($"Студент: {stud.name} \n СЪел:{e} кг\n \n Рост: {stud.rost} \n Вес: {stud.GE()}"));
            stud.eda(5);
            ew=5.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n СЪел:{e} кг\n \n Рост: {stud.rost} \n Вес: {stud.GE()}"));

        }
    }
}
