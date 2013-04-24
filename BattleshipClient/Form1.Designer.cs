namespace BattleshipClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSingUp = new System.Windows.Forms.Button();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textUserName = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.buttonSingUp);
			this.panel1.Controls.Add(this.buttonLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxPassword);
			this.panel1.Controls.Add(this.textUserName);
			this.panel1.Location = new System.Drawing.Point(305, 269);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 123);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.Location = new System.Drawing.Point(100, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(118, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.BurlyWood;
			this.label3.Location = new System.Drawing.Point(63, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "IP:";
			// 
			// buttonSingUp
			// 
			this.buttonSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSingUp.Location = new System.Drawing.Point(3, 97);
			this.buttonSingUp.Name = "buttonSingUp";
			this.buttonSingUp.Size = new System.Drawing.Size(50, 21);
			this.buttonSingUp.TabIndex = 6;
			this.buttonSingUp.Text = "Sign Up";
			this.buttonSingUp.UseVisualStyleBackColor = true;
			this.buttonSingUp.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(118, 96);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(81, 21);
			this.buttonLogin.TabIndex = 5;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
			this.buttonLogin.Enter += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.BurlyWood;
			this.label2.Location = new System.Drawing.Point(22, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.BurlyWood;
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBoxPassword.Location = new System.Drawing.Point(100, 40);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(118, 20);
			this.textBoxPassword.TabIndex = 1;
			// 
			// textUserName
			// 
			this.textUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textUserName.Location = new System.Drawing.Point(100, 13);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(118, 20);
			this.textUserName.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::BattleshipClient.Properties.Resources.BackgroundImage;
			this.ClientSize = new System.Drawing.Size(799, 502);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Battleship";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSingUp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
    }
}

