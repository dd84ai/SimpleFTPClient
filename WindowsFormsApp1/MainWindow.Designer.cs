namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1_User = new System.Windows.Forms.ListBox();
            this.listBox1_Server = new System.Windows.Forms.ListBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.button1_Receive = new System.Windows.Forms.Button();
            this.button1_Login = new System.Windows.Forms.Button();
            this.button1_UserUp = new System.Windows.Forms.Button();
            this.button1_ServerUp = new System.Windows.Forms.Button();
            this.button1_UserMkdir = new System.Windows.Forms.Button();
            this.button1_ServerMkDir = new System.Windows.Forms.Button();
            this.button1_UserDelete = new System.Windows.Forms.Button();
            this.button1_ServerDelete = new System.Windows.Forms.Button();
            this.button1_UserRename = new System.Windows.Forms.Button();
            this.button1_ServerRename = new System.Windows.Forms.Button();
            this.button1_UserDown = new System.Windows.Forms.Button();
            this.button1_ServerDown = new System.Windows.Forms.Button();
            this.label1_UserPwd = new System.Windows.Forms.Label();
            this.label1_ServerPath = new System.Windows.Forms.Label();
            this.button1_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1_User
            // 
            this.listBox1_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1_User.FormattingEnabled = true;
            this.listBox1_User.ItemHeight = 20;
            this.listBox1_User.Location = new System.Drawing.Point(12, 83);
            this.listBox1_User.Name = "listBox1_User";
            this.listBox1_User.Size = new System.Drawing.Size(378, 364);
            this.listBox1_User.TabIndex = 0;
            this.listBox1_User.SelectedIndexChanged += new System.EventHandler(this.listBox1_User_SelectedIndexChanged);
            // 
            // listBox1_Server
            // 
            this.listBox1_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1_Server.FormattingEnabled = true;
            this.listBox1_Server.ItemHeight = 20;
            this.listBox1_Server.Location = new System.Drawing.Point(396, 83);
            this.listBox1_Server.Name = "listBox1_Server";
            this.listBox1_Server.Size = new System.Drawing.Size(376, 364);
            this.listBox1_Server.TabIndex = 1;
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Send.Location = new System.Drawing.Point(332, 46);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(58, 28);
            this.Button_Send.TabIndex = 2;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            // 
            // button1_Receive
            // 
            this.button1_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Receive.Location = new System.Drawing.Point(396, 46);
            this.button1_Receive.Name = "button1_Receive";
            this.button1_Receive.Size = new System.Drawing.Size(58, 28);
            this.button1_Receive.TabIndex = 3;
            this.button1_Receive.Text = "Get";
            this.button1_Receive.UseVisualStyleBackColor = true;
            // 
            // button1_Login
            // 
            this.button1_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Login.Location = new System.Drawing.Point(12, 8);
            this.button1_Login.Name = "button1_Login";
            this.button1_Login.Size = new System.Drawing.Size(58, 28);
            this.button1_Login.TabIndex = 4;
            this.button1_Login.Text = "Login";
            this.button1_Login.UseVisualStyleBackColor = true;
            // 
            // button1_UserUp
            // 
            this.button1_UserUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_UserUp.Location = new System.Drawing.Point(12, 46);
            this.button1_UserUp.Name = "button1_UserUp";
            this.button1_UserUp.Size = new System.Drawing.Size(58, 28);
            this.button1_UserUp.TabIndex = 5;
            this.button1_UserUp.Text = "Up";
            this.button1_UserUp.UseVisualStyleBackColor = true;
            this.button1_UserUp.Click += new System.EventHandler(this.button1_UserUp_Click);
            // 
            // button1_ServerUp
            // 
            this.button1_ServerUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ServerUp.Location = new System.Drawing.Point(460, 46);
            this.button1_ServerUp.Name = "button1_ServerUp";
            this.button1_ServerUp.Size = new System.Drawing.Size(58, 28);
            this.button1_ServerUp.TabIndex = 6;
            this.button1_ServerUp.Text = "Up";
            this.button1_ServerUp.UseVisualStyleBackColor = true;
            // 
            // button1_UserMkdir
            // 
            this.button1_UserMkdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_UserMkdir.Location = new System.Drawing.Point(140, 46);
            this.button1_UserMkdir.Name = "button1_UserMkdir";
            this.button1_UserMkdir.Size = new System.Drawing.Size(58, 28);
            this.button1_UserMkdir.TabIndex = 7;
            this.button1_UserMkdir.Text = "MkDir";
            this.button1_UserMkdir.UseVisualStyleBackColor = true;
            this.button1_UserMkdir.Click += new System.EventHandler(this.button1_UserMkdir_Click);
            // 
            // button1_ServerMkDir
            // 
            this.button1_ServerMkDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ServerMkDir.Location = new System.Drawing.Point(586, 46);
            this.button1_ServerMkDir.Name = "button1_ServerMkDir";
            this.button1_ServerMkDir.Size = new System.Drawing.Size(58, 28);
            this.button1_ServerMkDir.TabIndex = 8;
            this.button1_ServerMkDir.Text = "MkDir";
            this.button1_ServerMkDir.UseVisualStyleBackColor = true;
            // 
            // button1_UserDelete
            // 
            this.button1_UserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_UserDelete.Location = new System.Drawing.Point(204, 46);
            this.button1_UserDelete.Name = "button1_UserDelete";
            this.button1_UserDelete.Size = new System.Drawing.Size(58, 28);
            this.button1_UserDelete.TabIndex = 9;
            this.button1_UserDelete.Text = "Del";
            this.button1_UserDelete.UseVisualStyleBackColor = true;
            this.button1_UserDelete.Click += new System.EventHandler(this.button1_UserDelete_Click);
            // 
            // button1_ServerDelete
            // 
            this.button1_ServerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ServerDelete.Location = new System.Drawing.Point(650, 46);
            this.button1_ServerDelete.Name = "button1_ServerDelete";
            this.button1_ServerDelete.Size = new System.Drawing.Size(58, 28);
            this.button1_ServerDelete.TabIndex = 10;
            this.button1_ServerDelete.Text = "Del";
            this.button1_ServerDelete.UseVisualStyleBackColor = true;
            // 
            // button1_UserRename
            // 
            this.button1_UserRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_UserRename.Location = new System.Drawing.Point(268, 46);
            this.button1_UserRename.Name = "button1_UserRename";
            this.button1_UserRename.Size = new System.Drawing.Size(58, 28);
            this.button1_UserRename.TabIndex = 11;
            this.button1_UserRename.Text = "Ren";
            this.button1_UserRename.UseVisualStyleBackColor = true;
            this.button1_UserRename.Click += new System.EventHandler(this.button1_UserRename_Click);
            // 
            // button1_ServerRename
            // 
            this.button1_ServerRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ServerRename.Location = new System.Drawing.Point(714, 46);
            this.button1_ServerRename.Name = "button1_ServerRename";
            this.button1_ServerRename.Size = new System.Drawing.Size(58, 28);
            this.button1_ServerRename.TabIndex = 12;
            this.button1_ServerRename.Text = "Ren";
            this.button1_ServerRename.UseVisualStyleBackColor = true;
            // 
            // button1_UserDown
            // 
            this.button1_UserDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_UserDown.Location = new System.Drawing.Point(76, 46);
            this.button1_UserDown.Name = "button1_UserDown";
            this.button1_UserDown.Size = new System.Drawing.Size(58, 28);
            this.button1_UserDown.TabIndex = 13;
            this.button1_UserDown.Text = "Down";
            this.button1_UserDown.UseVisualStyleBackColor = true;
            this.button1_UserDown.Click += new System.EventHandler(this.button1_UserDown_Click);
            // 
            // button1_ServerDown
            // 
            this.button1_ServerDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ServerDown.Location = new System.Drawing.Point(522, 46);
            this.button1_ServerDown.Name = "button1_ServerDown";
            this.button1_ServerDown.Size = new System.Drawing.Size(58, 28);
            this.button1_ServerDown.TabIndex = 14;
            this.button1_ServerDown.Text = "Down";
            this.button1_ServerDown.UseVisualStyleBackColor = true;
            // 
            // label1_UserPwd
            // 
            this.label1_UserPwd.AutoSize = true;
            this.label1_UserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_UserPwd.Location = new System.Drawing.Point(200, 3);
            this.label1_UserPwd.Name = "label1_UserPwd";
            this.label1_UserPwd.Size = new System.Drawing.Size(80, 20);
            this.label1_UserPwd.TabIndex = 15;
            this.label1_UserPwd.Text = "User Path";
            // 
            // label1_ServerPath
            // 
            this.label1_ServerPath.AutoSize = true;
            this.label1_ServerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_ServerPath.Location = new System.Drawing.Point(200, 23);
            this.label1_ServerPath.Name = "label1_ServerPath";
            this.label1_ServerPath.Size = new System.Drawing.Size(92, 20);
            this.label1_ServerPath.TabIndex = 16;
            this.label1_ServerPath.Text = "Server Path";
            // 
            // button1_Refresh
            // 
            this.button1_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Refresh.Location = new System.Drawing.Point(76, 8);
            this.button1_Refresh.Name = "button1_Refresh";
            this.button1_Refresh.Size = new System.Drawing.Size(58, 28);
            this.button1_Refresh.TabIndex = 17;
            this.button1_Refresh.Text = "Dir";
            this.button1_Refresh.UseVisualStyleBackColor = true;
            this.button1_Refresh.Click += new System.EventHandler(this.button1_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Server:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_Refresh);
            this.Controls.Add(this.label1_ServerPath);
            this.Controls.Add(this.label1_UserPwd);
            this.Controls.Add(this.button1_ServerDown);
            this.Controls.Add(this.button1_UserDown);
            this.Controls.Add(this.button1_ServerRename);
            this.Controls.Add(this.button1_UserRename);
            this.Controls.Add(this.button1_ServerDelete);
            this.Controls.Add(this.button1_UserDelete);
            this.Controls.Add(this.button1_ServerMkDir);
            this.Controls.Add(this.button1_UserMkdir);
            this.Controls.Add(this.button1_ServerUp);
            this.Controls.Add(this.button1_UserUp);
            this.Controls.Add(this.button1_Login);
            this.Controls.Add(this.button1_Receive);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.listBox1_Server);
            this.Controls.Add(this.listBox1_User);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_User;
        private System.Windows.Forms.ListBox listBox1_Server;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button button1_Receive;
        private System.Windows.Forms.Button button1_Login;
        private System.Windows.Forms.Button button1_UserUp;
        private System.Windows.Forms.Button button1_ServerUp;
        private System.Windows.Forms.Button button1_UserMkdir;
        private System.Windows.Forms.Button button1_ServerMkDir;
        private System.Windows.Forms.Button button1_UserDelete;
        private System.Windows.Forms.Button button1_ServerDelete;
        private System.Windows.Forms.Button button1_UserRename;
        private System.Windows.Forms.Button button1_ServerRename;
        private System.Windows.Forms.Button button1_UserDown;
        private System.Windows.Forms.Button button1_ServerDown;
        private System.Windows.Forms.Label label1_UserPwd;
        private System.Windows.Forms.Label label1_ServerPath;
        private System.Windows.Forms.Button button1_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

