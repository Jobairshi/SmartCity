namespace SmartCity
{
    partial class AdminPanelUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelUi));
            this.sidePan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePan
            // 
            this.sidePan.BackColor = System.Drawing.Color.DodgerBlue;
            this.sidePan.Controls.Add(this.panel1);
            this.sidePan.Controls.Add(this.label1);
            this.sidePan.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePan.Location = new System.Drawing.Point(0, 0);
            this.sidePan.Name = "sidePan";
            this.sidePan.Size = new System.Drawing.Size(248, 1022);
            this.sidePan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.more);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 200);
            this.panel1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(0, 96);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(248, 47);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.DodgerBlue;
            this.more.Dock = System.Windows.Forms.DockStyle.Top;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.Location = new System.Drawing.Point(0, 47);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(248, 49);
            this.more.TabIndex = 1;
            this.more.Text = "More To Come..";
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(248, 47);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "DeleteUser";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 199);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Coral;
            this.container.Controls.Add(this.label2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(248, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1267, 1022);
            this.container.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 866);
            this.label2.TabIndex = 0;
            // 
            // AdminPanelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1022);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidePan);
            this.Name = "AdminPanelUi";
            this.Text = "AdminPanelUi";
            this.sidePan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePan;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
    }
}