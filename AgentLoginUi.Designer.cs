namespace SmartCity
{
    partial class AgentLoginUi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new ProApp.customTextBox();
            this.user = new ProApp.customTextBox();
            this.container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.MediumTurquoise;
            this.container.Controls.Add(this.panel2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1483, 944);
            this.container.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.Submit);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.warn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(381, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 556);
            this.panel2.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.Back.FlatAppearance.BorderSize = 3;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(255, 314);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 41);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Submit
            // 
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.Submit.FlatAppearance.BorderSize = 3;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(116, 314);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 41);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agent Login";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.password.BorderColor = System.Drawing.Color.Crimson;
            this.password.BorderFocusColor = System.Drawing.Color.Yellow;
            this.password.BorderRadius = 0;
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
            this.user.BorderColor = System.Drawing.Color.Magenta;
            this.user.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.user.BorderRadius = 0;
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
            this.user.Texts = "Agent Name";
            this.user.UnderlinedStyle = false;
            // 
            // AgentLoginUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 944);
            this.Controls.Add(this.container);
            this.Name = "AgentLoginUi";
            this.Text = "AgentLoginUi";
            this.container.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Submit;
        private ProApp.customTextBox password;
        private ProApp.customTextBox user;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label label1;
    }
}