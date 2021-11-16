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
    public partial class Tast1 : Form
    {
        public Tast1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    if (Convert.ToInt32(textBox1.Text) > 7)
                    {
                        MessageBox.Show("Число больше 7");
                    }
                    else if (Convert.ToInt32(textBox1.Text) == 7)
                    {
                        MessageBox.Show("Вы ввели число 7");
                    }
                    else if (Convert.ToInt32(textBox1.Text) < 7)
                    {
                        MessageBox.Show("Число меньше 7");
                    }
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильнсть формата ввода!",ex.ToString());
            }
            
           

            
            
        }
    }
}
