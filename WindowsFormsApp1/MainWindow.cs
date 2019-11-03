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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateFolderToWorkAtUser();

            UpdateUserBox();
        }
        //string UserPwd = "Worktable"
        void UpdateUserBox()
        {
            label1_UserPwd.Text = Directory.GetCurrentDirectory();

            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*"); //Getting Text files
            string[] subdirectoryEntries = Directory.GetDirectories(Directory.GetCurrentDirectory());
            listBox1_User.Items.Clear();
            listBox1_User.Items.AddRange(subdirectoryEntries.Select(x => Regex.Match(x, @"[\\].[^\\]*$").Value).ToArray());
            listBox1_User.Items.AddRange(Files.Select(x => x.Name).ToArray());
        }
        void CreateFolderToWorkAtUser()
        {
            try
            {
                System.IO.Directory.CreateDirectory("Worktable");
                Directory.SetCurrentDirectory(Directory.GetCurrentDirectory() + @"\Worktable");
            }
            catch (Exception e55)
            {
                MessageBox.Show("Error: " + e55.Message);
            }
        }

        private void listBox1_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateUserBox();
        }

        private void button1_Refresh_Click(object sender, EventArgs e)
        {
            UpdateUserBox();
        }

        private void button1_UserUp_Click(object sender, EventArgs e)
        {
            try
            {
                string Current = Directory.GetCurrentDirectory();
                string Parent = Directory.GetParent(Current).FullName;
                Directory.SetCurrentDirectory(Parent);
                UpdateUserBox();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_UserDown_Click(object sender, EventArgs e)
        {
            try
            {
                string Current = Directory.GetCurrentDirectory() + listBox1_User.SelectedItem.ToString();
                Directory.SetCurrentDirectory(Current);
                UpdateUserBox();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        UserMkDir Formed;
        private void button1_UserMkdir_Click(object sender, EventArgs e)
        {
            Formed = new UserMkDir();
            Formed.ShowDialog();
            UpdateUserBox();
        }

        private void button1_UserDelete_Click(object sender, EventArgs e)
        {
            string Adress = Directory.GetCurrentDirectory() + "\\" + listBox1_User.SelectedItem.ToString().Replace("\\", "");

            if (listBox1_User.SelectedItem.ToString().Contains("\\"))
                try
                {
                    Directory.Delete(Adress);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            else
                try
                {
                    File.Delete(Adress);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            UpdateUserBox();
        }

        private void button1_UserRename_Click(object sender, EventArgs e)
        {
            try
            {
                //string Adress = Directory.GetCurrentDirectory() + "\\" + listBox1_User.SelectedItem.ToString().Replace("\\", "");
                var Temp = new UserMove(listBox1_User.SelectedItem.ToString());
                Temp.ShowDialog();
                UpdateUserBox();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
            }
        }
    }
}
