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
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToLower();
            string name = "вячеслав";
            string Name = "Вячеслав";
                
            if (name == input)
                {
                    MessageBox.Show("Привет " + Name);
                }
            else if (input is null)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
                else
                {
                    MessageBox.Show("Нет такого имени!");
                }
            
        }
    }
}
