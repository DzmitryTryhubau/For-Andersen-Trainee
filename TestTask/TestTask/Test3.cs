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
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }
        
        void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] array = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(k => int.Parse(k.Trim())).ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    label2.Text += array[j].ToString() + "\t";
                }
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] % 3 == 0)
                    {
                        MessageBox.Show(Convert.ToString(array[j]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте формат введенных данных", ex.ToString());
            }
        
        }
    }
}

