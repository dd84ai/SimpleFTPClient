using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class UserMove : Form
    {
        string Main = "";
        public UserMove(string Starter)
        {
            InitializeComponent();
            textBox1.Text = Starter;
            Main = Starter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adress = Directory.GetCurrentDirectory() + "\\" + Main.Replace("\\", "");
            if (Main.Contains("\\"))
                try
                {
                    Directory.Move(Adress, Directory.GetCurrentDirectory() + "\\" + textBox1.Text.Replace("\\", ""));
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message);
                }
            else
                try
                {
                    File.Move(Adress, Directory.GetCurrentDirectory() + "\\" + textBox1.Text.Replace("\\", ""));
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message);
                }

            this.Close();

        }
    }
}
