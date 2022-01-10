namespace SmartCity
{
    partial class UserUi
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
            this.container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new ProApp.customTextBox();
            this.user = new ProApp.customTextBox();
            this.warn = new System.Windows.Forms.Label();
            this.Back = new ProApp.button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new ProApp.button();
            this.container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.panel1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1515, 1022);
            this.container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.warn);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(399, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 556);
            this.panel1.TabIndex = 1;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.password.BorderColor = System.Drawing.Color.Crimson;
            this.password.BorderFocusColor = System.Drawing.Color.Yellow;
            this.password.BorderRadius = 15;
            this.password.BorderSize = 2;
            this.password.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.password.Location = new System.Drawing.Point(97, 235);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.password.PasswordChar = false;
            this.password.PlaceholderText = "";
            this.password.Size = new System.Drawing.Size(276, 39);
            this.password.TabIndex = 10;
            this.password.Texts = "PassWord";
            this.password.UnderlinedStyle = false;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.user.BorderColor = System.Drawing.Color.Crimson;
            this.user.BorderFocusColor = System.Drawing.Color.Aqua;
            this.user.BorderRadius = 15;
            this.user.BorderSize = 2;
            this.user.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.user.Location = new System.Drawing.Point(76, 161);
            this.user.Multiline = false;
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.user.PasswordChar = false;
            this.user.PlaceholderText = "";
            this.user.Size = new System.Drawing.Size(317, 39);
            this.user.TabIndex = 9;
            this.user.Texts = "UserName";
            this.user.UnderlinedStyle = false;
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(47, 101);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(0, 25);
            this.warn.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Back.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Back.BorderColor = System.Drawing.Color.Aquamarine;
            this.Back.BorderRadius = 20;
            this.Back.BorderSize = 3;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(286, 332);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 40);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.TextColor = System.Drawing.Color.White;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(241, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create new Account";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(93, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Don\'t have account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(159, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BorderColor = System.Drawing.Color.Aquamarine;
            this.button1.BorderRadius = 20;
            this.button1.BorderSize = 3;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(112, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1515, 1022);
            this.Controls.Add(this.container);
            this.Name = "UserUi";
            this.Text = "UserUi";
            this.Load += new System.EventHandler(this.UserUi_Load);
            this.container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
     
        private ProApp.button button1;
        private ProApp.button Back;
        private System.Windows.Forms.Label warn;
        private ProApp.customTextBox user;
        private ProApp.customTextBox password;
    }
}