namespace SmartCity
{
    partial class AddHouseUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HouseName = new ProApp.customTextBox();
            this.link = new ProApp.customTextBox();
            this.Phone = new ProApp.customTextBox();
            this.AreaName = new ProApp.customTextBox();
            this.Submit = new ProApp.button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add House Info  For Rent";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.HouseName);
            this.panel1.Controls.Add(this.link);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.AreaName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Location = new System.Drawing.Point(515, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 556);
            this.panel1.TabIndex = 2;
            // 
            // HouseName
            // 
            this.HouseName.BackColor = System.Drawing.Color.White;
            this.HouseName.BorderColor = System.Drawing.Color.Crimson;
            this.HouseName.BorderFocusColor = System.Drawing.Color.Aqua;
            this.HouseName.BorderRadius = 0;
            this.HouseName.BorderSize = 2;
            this.HouseName.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseName.ForeColor = System.Drawing.Color.DarkGreen;
            this.HouseName.Location = new System.Drawing.Point(78, 177);
            this.HouseName.Multiline = false;
            this.HouseName.Name = "HouseName";
            this.HouseName.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.HouseName.PasswordChar = false;
            this.HouseName.PlaceholderText = "";
            this.HouseName.Size = new System.Drawing.Size(317, 39);
            this.HouseName.TabIndex = 13;
            this.HouseName.Texts = "HouseName";
            this.HouseName.UnderlinedStyle = false;
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.White;
            this.link.BorderColor = System.Drawing.Color.Crimson;
            this.link.BorderFocusColor = System.Drawing.Color.Aqua;
            this.link.BorderRadius = 0;
            this.link.BorderSize = 2;
            this.link.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.DarkGreen;
            this.link.Location = new System.Drawing.Point(78, 308);
            this.link.Multiline = false;
            this.link.Name = "link";
            this.link.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.link.PasswordChar = false;
            this.link.PlaceholderText = "";
            this.link.Size = new System.Drawing.Size(317, 39);
            this.link.TabIndex = 12;
            this.link.Texts = "Location Link";
            this.link.UnderlinedStyle = false;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.BorderColor = System.Drawing.Color.Crimson;
            this.Phone.BorderFocusColor = System.Drawing.Color.Aqua;
            this.Phone.BorderRadius = 0;
            this.Phone.BorderSize = 2;
            this.Phone.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.DarkGreen;
            this.Phone.Location = new System.Drawing.Point(76, 241);
            this.Phone.Multiline = false;
            this.Phone.Name = "Phone";
            this.Phone.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Phone.PasswordChar = false;
            this.Phone.PlaceholderText = "";
            this.Phone.Size = new System.Drawing.Size(317, 39);
            this.Phone.TabIndex = 11;
            this.Phone.Texts = "Phone";
            this.Phone.UnderlinedStyle = false;
            // 
            // AreaName
            // 
            this.AreaName.BackColor = System.Drawing.Color.Snow;
            this.AreaName.BorderColor = System.Drawing.Color.Crimson;
            this.AreaName.BorderFocusColor = System.Drawing.Color.Aqua;
            this.AreaName.BorderRadius = 0;
            this.AreaName.BorderSize = 2;
            this.AreaName.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaName.ForeColor = System.Drawing.Color.DarkGreen;
            this.AreaName.Location = new System.Drawing.Point(76, 116);
            this.AreaName.Multiline = false;
            this.AreaName.Name = "AreaName";
            this.AreaName.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.AreaName.PasswordChar = false;
            this.AreaName.PlaceholderText = "";
            this.AreaName.Size = new System.Drawing.Size(317, 39);
            this.AreaName.TabIndex = 10;
            this.AreaName.Texts = "AreaName";
            this.AreaName.UnderlinedStyle = false;
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit.BackColor = System.Drawing.Color.White;
            this.Submit.BackgroundColor = System.Drawing.Color.White;
            this.Submit.BorderColor = System.Drawing.Color.Aquamarine;
            this.Submit.BorderRadius = 20;
            this.Submit.BorderSize = 3;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.Black;
            this.Submit.Location = new System.Drawing.Point(159, 384);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(163, 46);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Add";
            this.Submit.TextColor = System.Drawing.Color.Black;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddHouseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1515, 1022);
            this.Controls.Add(this.panel1);
            this.Name = "AddHouseUi";
            this.Text = "AddHouseUi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ProApp.customTextBox HouseName;
        private ProApp.customTextBox link;
        private ProApp.customTextBox Phone;
        private ProApp.customTextBox AreaName;
        private System.Windows.Forms.Label label1;
        private ProApp.button Submit;
        private System.Windows.Forms.Panel panel1;
    }
}