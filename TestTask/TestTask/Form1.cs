using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tast1 task1 = new Tast1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test2 task2 = new Test2();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Test3 task3 = new Test3();
            task3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[((())()(())]] - не верно \n\n[((()))()(())] - верно", "Задание №4");
        }
    }
}
