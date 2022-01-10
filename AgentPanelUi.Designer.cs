namespace SmartCity
{
    partial class AgentPanelUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPanelUi));
            this.sidePan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addhouse = new System.Windows.Forms.Button();
            this.AddHotels = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.sidePan.SuspendLayout();
            this.container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePan
            // 
            this.sidePan.BackColor = System.Drawing.Color.SteelBlue;
            this.sidePan.Controls.Add(this.panel1);
            this.sidePan.Controls.Add(this.label2);
            this.sidePan.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePan.Location = new System.Drawing.Point(0, 0);
            this.sidePan.Name = "sidePan";
            this.sidePan.Size = new System.Drawing.Size(268, 1022);
            this.sidePan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 168);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.LightSlateGray;
            this.container.Controls.Add(this.label1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(268, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1247, 1022);
            this.container.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(210, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 841);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.More);
            this.panel1.Controls.Add(this.AddHotels);
            this.panel1.Controls.Add(this.Addhouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 235);
            this.panel1.TabIndex = 1;
            // 
            // Addhouse
            // 
            this.Addhouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.Addhouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addhouse.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addhouse.Location = new System.Drawing.Point(0, 0);
            this.Addhouse.Name = "Addhouse";
            this.Addhouse.Size = new System.Drawing.Size(268, 48);
            this.Addhouse.TabIndex = 1;
            this.Addhouse.Text = "AddHouseForRent";
            this.Addhouse.UseVisualStyleBackColor = true;
            this.Addhouse.Click += new System.EventHandler(this.Addhouse_Click);
            // 
            // AddHotels
            // 
            this.AddHotels.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddHotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHotels.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHotels.Location = new System.Drawing.Point(0, 48);
            this.AddHotels.Name = "AddHotels";
            this.AddHotels.Size = new System.Drawing.Size(268, 48);
            this.AddHotels.TabIndex = 2;
            this.AddHotels.Text = "AddHotels";
            this.AddHotels.UseVisualStyleBackColor = true;
            this.AddHotels.Click += new System.EventHandler(this.AddHotels_Click);
            // 
            // More
            // 
            this.More.Dock = System.Windows.Forms.DockStyle.Top;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More.Location = new System.Drawing.Point(0, 96);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(268, 48);
            this.More.TabIndex = 3;
            this.More.Text = "More To Come..";
            this.More.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(0, 144);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(268, 48);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AgentPanelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1022);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidePan);
            this.Name = "AgentPanelUi";
            this.Text = "AgentPanelUi";
            this.Load += new System.EventHandler(this.AgentPanelUi_Load);
            this.sidePan.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePan;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Addhouse;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Button AddHotels;
        private System.Windows.Forms.Button Back;
    }
}