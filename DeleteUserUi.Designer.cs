namespace SmartCity
{
    partial class DeleteUserUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.warn = new System.Windows.Forms.Label();
            this.userName = new ProApp.customTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Tomato;
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.panel2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1251, 983);
            this.container.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delete User";
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
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userName.BorderColor = System.Drawing.Color.Violet;
            this.userName.BorderFocusColor = System.Drawing.Color.Aqua;
            this.userName.BorderRadius = 0;
            this.userName.BorderSize = 2;
            this.userName.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.userName.Location = new System.Drawing.Point(76, 161);
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.userName.PasswordChar = false;
            this.userName.PlaceholderText = "";
            this.userName.Size = new System.Drawing.Size(317, 39);
            this.userName.TabIndex = 9;
            this.userName.Texts = "Enter User\'s  Mail";
            this.userName.UnderlinedStyle = false;
            // 
            // Submit
            // 
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.Submit.FlatAppearance.BorderSize = 3;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(170, 253);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 41);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Delete";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Submit);
            this.panel2.Controls.Add(this.userName);
            this.panel2.Controls.Add(this.warn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(196, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 556);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delete User From Server";
            // 
            // DeleteUserUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 983);
            this.Controls.Add(this.container);
            this.Name = "DeleteUserUi";
            this.Text = "DeleteUserUi";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Submit;
        private ProApp.customTextBox userName;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}