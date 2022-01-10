namespace SmartCity
{
    partial class EmergencyUi
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
            this.title = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.CityBox = new ProApp.CustomComboBox();
            this.Phone = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.EmerBox = new ProApp.CustomComboBox();
            this.container.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Font = new System.Drawing.Font("Ink Free", 59.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.Location = new System.Drawing.Point(286, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(735, 101);
            this.title.TabIndex = 3;
            this.title.Text = "In Your Emergency!!";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.LightCoral;
            this.container.Controls.Add(this.EmerBox);
            this.container.Controls.Add(this.Phone);
            this.container.Controls.Add(this.panel3);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.panel4);
            this.container.Controls.Add(this.ButtonPanel);
            this.container.Controls.Add(this.NamePanel);
            this.container.Controls.Add(this.title);
            this.container.Controls.Add(this.Submit);
            this.container.Controls.Add(this.CityBox);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1249, 983);
            this.container.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Submit.FlatAppearance.BorderSize = 2;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Submit.Location = new System.Drawing.Point(332, 231);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 42);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CityBox
            // 
            this.CityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CityBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CityBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CityBox.BorderSize = 2;
            this.CityBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CityBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.CityBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CityBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CityBox.ListTextColor = System.Drawing.Color.DimGray;
            this.CityBox.Location = new System.Drawing.Point(72, 179);
            this.CityBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.CityBox.Name = "CityBox";
            this.CityBox.Padding = new System.Windows.Forms.Padding(2);
            this.CityBox.Size = new System.Drawing.Size(224, 42);
            this.CityBox.TabIndex = 1;
            this.CityBox.Texts = "SelectCity";
            // 
            // Phone
            // 
            this.Phone.AutoScroll = true;
            this.Phone.BackColor = System.Drawing.Color.Turquoise;
            this.Phone.Location = new System.Drawing.Point(481, 442);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(392, 616);
            this.Phone.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(879, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 40);
            this.panel3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Location of the Hospitals";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(481, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 40);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phones";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(69, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 40);
            this.panel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name of The Hospitals";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonPanel.Location = new System.Drawing.Point(879, 442);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(325, 616);
            this.ButtonPanel.TabIndex = 24;
            // 
            // NamePanel
            // 
            this.NamePanel.AutoScroll = true;
            this.NamePanel.BackColor = System.Drawing.Color.Turquoise;
            this.NamePanel.Location = new System.Drawing.Point(69, 442);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(406, 616);
            this.NamePanel.TabIndex = 23;
            // 
            // EmerBox
            // 
            this.EmerBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EmerBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EmerBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmerBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.EmerBox.BorderSize = 2;
            this.EmerBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.EmerBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmerBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmerBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.EmerBox.Items.AddRange(new object[] {
            "BloodBank",
            "Police",
            "Ambulance"});
            this.EmerBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.EmerBox.ListTextColor = System.Drawing.Color.DimGray;
            this.EmerBox.Location = new System.Drawing.Point(72, 280);
            this.EmerBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.EmerBox.Name = "EmerBox";
            this.EmerBox.Padding = new System.Windows.Forms.Padding(2);
            this.EmerBox.Size = new System.Drawing.Size(224, 42);
            this.EmerBox.TabIndex = 29;
            this.EmerBox.Texts = "Select";
            // 
            // EmergencyUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 983);
            this.Controls.Add(this.container);
            this.Name = "EmergencyUi";
            this.Text = "EmergencyUi";
            this.Load += new System.EventHandler(this.EmergencyUi_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button Submit;
        private ProApp.CustomComboBox CityBox;
        private ProApp.CustomComboBox EmerBox;
        private System.Windows.Forms.Panel Phone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel NamePanel;
    }
}