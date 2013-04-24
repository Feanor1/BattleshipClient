namespace BattleshipClient
{
    partial class Register
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textUserName = new System.Windows.Forms.TextBox();
			this.textPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboAccountType = new System.Windows.Forms.ComboBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textVerify = new System.Windows.Forms.TextBox();
			this.Port = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// textUserName
			// 
			this.textUserName.Location = new System.Drawing.Point(83, 43);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(190, 20);
			this.textUserName.TabIndex = 4;
			// 
			// textPass
			// 
			this.textPass.Location = new System.Drawing.Point(83, 75);
			this.textPass.Name = "textPass";
			this.textPass.PasswordChar = '*';
			this.textPass.Size = new System.Drawing.Size(190, 20);
			this.textPass.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Account";
			// 
			// comboAccountType
			// 
			this.comboAccountType.FormattingEnabled = true;
			this.comboAccountType.Items.AddRange(new object[] {
            "Player",
            "Spectator"});
			this.comboAccountType.Location = new System.Drawing.Point(83, 12);
			this.comboAccountType.Name = "comboAccountType";
			this.comboAccountType.Size = new System.Drawing.Size(115, 21);
			this.comboAccountType.TabIndex = 7;
			this.comboAccountType.Text = "Player";
			this.comboAccountType.SelectedValueChanged += new System.EventHandler(this.comboAccountType_SelectedValueChanged);
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(94, 236);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(88, 23);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// label4
			// 
			this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "PassVerify";
			// 
			// textVerify
			// 
			this.textVerify.Location = new System.Drawing.Point(84, 108);
			this.textVerify.Name = "textVerify";
			this.textVerify.PasswordChar = '*';
			this.textVerify.Size = new System.Drawing.Size(189, 20);
			this.textVerify.TabIndex = 10;
			// 
			// Port
			// 
			this.Port.FormattingEnabled = true;
			this.Port.Items.AddRange(new object[] {
            "5000",
            "5001"});
			this.Port.Location = new System.Drawing.Point(84, 161);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(114, 21);
			this.Port.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Port:";
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 271);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Port);
			this.Controls.Add(this.textVerify);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.comboAccountType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textPass);
			this.Controls.Add(this.textUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Register";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVerify;
		private System.Windows.Forms.ComboBox Port;
		private System.Windows.Forms.Label label5;
    }
}