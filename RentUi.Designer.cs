namespace SmartCity
{
    partial class RentUi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentUi));
            this.container = new System.Windows.Forms.Panel();
            this.Phone = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.CityBox = new ProApp.CustomComboBox();
            this.usersDataSet = new SmartCity.UsersDataSet();
            this.usersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet1 = new SmartCity.UsersDataSet1();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new SmartCity.UsersDataSet1TableAdapters.rentTableAdapter();
            this.usersDataSet2 = new SmartCity.UsersDataSet2();
            this.rentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter1 = new SmartCity.UsersDataSet2TableAdapters.rentTableAdapter();
            this.usersDataSet3 = new SmartCity.UsersDataSet3();
            this.rentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter2 = new SmartCity.UsersDataSet3TableAdapters.rentTableAdapter();
            this.container.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.BackColor = System.Drawing.SystemColors.ControlLight;
            this.container.Controls.Add(this.Phone);
            this.container.Controls.Add(this.panel3);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.panel4);
            this.container.Controls.Add(this.ButtonPanel);
            this.container.Controls.Add(this.NamePanel);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.title);
            this.container.Controls.Add(this.Submit);
            this.container.Controls.Add(this.CityBox);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1344, 983);
            this.container.TabIndex = 3;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // Phone
            // 
            this.Phone.AutoScroll = true;
            this.Phone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Phone.Location = new System.Drawing.Point(514, 506);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(392, 616);
            this.Phone.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(912, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 40);
            this.panel3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Location of the Building";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(514, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 40);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phones";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(102, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 40);
            this.panel4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name of The Place-Building";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Location = new System.Drawing.Point(912, 506);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(325, 616);
            this.ButtonPanel.TabIndex = 7;
            // 
            // NamePanel
            // 
            this.NamePanel.AutoScroll = true;
            this.NamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NamePanel.Location = new System.Drawing.Point(102, 506);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(406, 616);
            this.NamePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warning : Houses Names With ( * ) Marks Are not Safe According To Building Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Font = new System.Drawing.Font("Ink Free", 59.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.Location = new System.Drawing.Point(383, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(710, 101);
            this.title.TabIndex = 3;
            this.title.Text = "Homes For Rent!!   ";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Submit.FlatAppearance.BorderSize = 2;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Submit.Location = new System.Drawing.Point(369, 258);
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
            this.CityBox.BorderSize = 1;
            this.CityBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CityBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CityBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CityBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CityBox.ListTextColor = System.Drawing.Color.DimGray;
            this.CityBox.Location = new System.Drawing.Point(102, 258);
            this.CityBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.CityBox.Name = "CityBox";
            this.CityBox.Padding = new System.Windows.Forms.Padding(1);
            this.CityBox.Size = new System.Drawing.Size(224, 42);
            this.CityBox.TabIndex = 1;
            this.CityBox.Texts = "SelectArea";
            this.CityBox.OnSelectedIndexChanged += new System.EventHandler(this.CityBox_OnSelectedIndexChanged);
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersDataSetBindingSource
            // 
            this.usersDataSetBindingSource.DataSource = this.usersDataSet;
            this.usersDataSetBindingSource.Position = 0;
            this.usersDataSetBindingSource.CurrentChanged += new System.EventHandler(this.usersDataSetBindingSource_CurrentChanged);
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "UsersDataSet1";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "rent";
            this.rentBindingSource.DataSource = this.usersDataSet1;
            this.rentBindingSource.CurrentChanged += new System.EventHandler(this.rentBindingSource_CurrentChanged);
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet2
            // 
            this.usersDataSet2.DataSetName = "UsersDataSet2";
            this.usersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource1
            // 
            this.rentBindingSource1.DataMember = "rent";
            this.rentBindingSource1.DataSource = this.usersDataSet2;
            this.rentBindingSource1.CurrentChanged += new System.EventHandler(this.rentBindingSource1_CurrentChanged);
            // 
            // rentTableAdapter1
            // 
            this.rentTableAdapter1.ClearBeforeFill = true;
            // 
            // usersDataSet3
            // 
            this.usersDataSet3.DataSetName = "UsersDataSet3";
            this.usersDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource2
            // 
            this.rentBindingSource2.DataMember = "rent";
            this.rentBindingSource2.DataSource = this.usersDataSet3;
            this.rentBindingSource2.CurrentChanged += new System.EventHandler(this.rentBindingSource2_CurrentChanged);
            // 
            // rentTableAdapter2
            // 
            this.rentTableAdapter2.ClearBeforeFill = true;
            // 
            // RentUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1344, 983);
            this.Controls.Add(this.container);
            this.Name = "RentUi";
            this.Text = "RentUi";
            this.Load += new System.EventHandler(this.RentUi_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.BindingSource usersDataSetBindingSource;
        private UsersDataSet usersDataSet;
        private UsersDataSet1 usersDataSet1;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private UsersDataSet1TableAdapters.rentTableAdapter rentTableAdapter;
        private UsersDataSet2 usersDataSet2;
        private System.Windows.Forms.BindingSource rentBindingSource1;
        private UsersDataSet2TableAdapters.rentTableAdapter rentTableAdapter1;
        private UsersDataSet3 usersDataSet3;
        private System.Windows.Forms.BindingSource rentBindingSource2;
        private UsersDataSet3TableAdapters.rentTableAdapter rentTableAdapter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private ProApp.CustomComboBox CityBox;
    }
}