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
        //reads from ServerAndLoginAndPassword.txt
        string server, name, pass;
        void ReadLoginAndPassword()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("ServerAndLoginAndPassword.txt");
                server = lines[0];
                name = lines[1];
                pass = lines[2];
            }
            catch (Exception err)
            {
                if (MessageBox.Show(err.Message, "Confirm", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Exit();
                    this.Close();
                }
                
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            ReadLoginAndPassword();
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
            UpdateServerBoxList();
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

        private void button1_ServerMkDir_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                var Temp = new UserMkDir(true, ftpClient, ServerPath);
                Temp.ShowDialog();
                UpdateServerBoxList();
            }

        }

        string ServerPath = "~";
        void UpdateServerBoxList()
        {
            if (ServerIsOn)
            {
                string[] simpleDirectoryListing = ftpClient.directoryListDetailed(ServerPath);
                listBox1_Server.Items.Clear();
                listBox1_Server.Items.AddRange(simpleDirectoryListing.Select(x => Regex.Match(x, @"[ ].[^ ]*$").Value.Replace(" ", "")).ToArray());
                label1_ServerPath.Text = ServerPath;
            }
        }

        bool ServerIsOn = false;

        private void button1_ServerDelete_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                string Adress = listBox1_Server.SelectedItem.ToString().Replace("\\", "");

                if (Adress.Contains("."))
                    try
                    {
                        ftpClient.delete(ServerPath +"/"+ Adress);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                else
                    try
                    {
                        ftpClient.deleteDirectory(ServerPath + "/" + Adress);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                UpdateServerBoxList();
            }
        }

        private void button1_ServerRename_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                string Adress = listBox1_Server.SelectedItem.ToString().Replace("\\", "");

                try
                {
                    var Temp = new UserMove(Adress, true, ftpClient, ServerPath);
                    Temp.ShowDialog();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }


                UpdateServerBoxList();
            }
        }

        private void button1_ServerDown_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                string Adress = listBox1_Server.SelectedItem.ToString().Replace("\\", "");

                ServerPath += "/" + Adress;
                UpdateServerBoxList();
            }
        }

        private void button1_ServerUp_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                if (ServerPath == "~")
                {
                    MessageBox.Show("Error: ~ path");
                    return;
                }
                string[] Folders = ServerPath.Split('/');

                ServerPath = ServerPath.Replace(Folders.Last(), "");
                ServerPath = ServerPath.Remove(ServerPath.Count()-1);
                UpdateServerBoxList();
            }

        }

        ftp ftpClient;
        private void button1_Login_Click(object sender, EventArgs e)
        {
            try
            {
                ftpClient = new ftp(server, name, pass); //1 - number
                ServerIsOn = true;
                UpdateServerBoxList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                try
                {
                    string Adress = Directory.GetCurrentDirectory() + "\\" + listBox1_User.SelectedItem.ToString().Replace("\\", "");

                    ftpClient.upload(ServerPath + "/" + listBox1_User.SelectedItem.ToString().Replace("\\", ""), Adress);

                    UpdateUserBox();
                    UpdateServerBoxList();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button1_Receive_Click(object sender, EventArgs e)
        {
            if (ServerIsOn)
            {
                try
                {
                    string Adress = Directory.GetCurrentDirectory() + "\\" + listBox1_Server.SelectedItem.ToString().Replace("\\", "");

                    ftpClient.download(ServerPath + "/" + listBox1_Server.SelectedItem.ToString().Replace("\\", ""), Adress);

                    UpdateUserBox();
                    UpdateServerBoxList();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
