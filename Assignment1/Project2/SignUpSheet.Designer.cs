namespace Project2
{
    partial class SignUpSheet
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
            System.Windows.Forms.Label studentName;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.equipmentInfo = new System.Windows.Forms.RichTextBox();
            this.snowGloves = new System.Windows.Forms.CheckBox();
            this.skis = new System.Windows.Forms.CheckBox();
            this.goggles = new System.Windows.Forms.CheckBox();
            this.coat = new System.Windows.Forms.CheckBox();
            this.skiPoles = new System.Windows.Forms.CheckBox();
            this.earmuffs = new System.Windows.Forms.CheckBox();
            this.equipmentGroupBox = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            studentName = new System.Windows.Forms.Label();
            this.equipmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new System.Drawing.Point(12, 15);
            studentName.Name = "studentName";
            studentName.Size = new System.Drawing.Size(35, 13);
            studentName.TabIndex = 0;
            studentName.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(53, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(15, 142);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(194, 23);
            this.signUp.TabIndex = 9;
            this.signUp.Text = "Sign-Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // equipmentInfo
            // 
            this.equipmentInfo.Location = new System.Drawing.Point(215, 12);
            this.equipmentInfo.Name = "equipmentInfo";
            this.equipmentInfo.ReadOnly = true;
            this.equipmentInfo.Size = new System.Drawing.Size(259, 179);
            this.equipmentInfo.TabIndex = 14;
            this.equipmentInfo.Text = "";
            // 
            // snowGloves
            // 
            this.snowGloves.AutoSize = true;
            this.snowGloves.Location = new System.Drawing.Point(6, 23);
            this.snowGloves.Name = "snowGloves";
            this.snowGloves.Size = new System.Drawing.Size(89, 17);
            this.snowGloves.TabIndex = 3;
            this.snowGloves.Text = "Snow Gloves";
            this.snowGloves.UseVisualStyleBackColor = true;
            // 
            // skis
            // 
            this.skis.AutoSize = true;
            this.skis.Location = new System.Drawing.Point(6, 46);
            this.skis.Name = "skis";
            this.skis.Size = new System.Drawing.Size(46, 17);
            this.skis.TabIndex = 5;
            this.skis.Text = "Skis";
            this.skis.UseVisualStyleBackColor = true;
            // 
            // goggles
            // 
            this.goggles.AutoSize = true;
            this.goggles.Location = new System.Drawing.Point(6, 69);
            this.goggles.Name = "goggles";
            this.goggles.Size = new System.Drawing.Size(65, 17);
            this.goggles.TabIndex = 7;
            this.goggles.Text = "Goggles";
            this.goggles.UseVisualStyleBackColor = true;
            // 
            // coat
            // 
            this.coat.AutoSize = true;
            this.coat.Location = new System.Drawing.Point(101, 46);
            this.coat.Name = "coat";
            this.coat.Size = new System.Drawing.Size(48, 17);
            this.coat.TabIndex = 6;
            this.coat.Text = "Coat";
            this.coat.UseVisualStyleBackColor = true;
            // 
            // skiPoles
            // 
            this.skiPoles.AutoSize = true;
            this.skiPoles.Location = new System.Drawing.Point(101, 69);
            this.skiPoles.Name = "skiPoles";
            this.skiPoles.Size = new System.Drawing.Size(70, 17);
            this.skiPoles.TabIndex = 8;
            this.skiPoles.Text = "Ski Poles";
            this.skiPoles.UseVisualStyleBackColor = true;
            // 
            // earmuffs
            // 
            this.earmuffs.AutoSize = true;
            this.earmuffs.Location = new System.Drawing.Point(101, 23);
            this.earmuffs.Name = "earmuffs";
            this.earmuffs.Size = new System.Drawing.Size(67, 17);
            this.earmuffs.TabIndex = 4;
            this.earmuffs.Text = "Earmuffs";
            this.earmuffs.UseVisualStyleBackColor = true;
            // 
            // equipmentGroupBox
            // 
            this.equipmentGroupBox.Controls.Add(this.snowGloves);
            this.equipmentGroupBox.Controls.Add(this.earmuffs);
            this.equipmentGroupBox.Controls.Add(this.skis);
            this.equipmentGroupBox.Controls.Add(this.skiPoles);
            this.equipmentGroupBox.Controls.Add(this.goggles);
            this.equipmentGroupBox.Controls.Add(this.coat);
            this.equipmentGroupBox.Location = new System.Drawing.Point(15, 38);
            this.equipmentGroupBox.Name = "equipmentGroupBox";
            this.equipmentGroupBox.Size = new System.Drawing.Size(194, 98);
            this.equipmentGroupBox.TabIndex = 2;
            this.equipmentGroupBox.TabStop = false;
            this.equipmentGroupBox.Text = "Equipment";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(15, 168);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(116, 168);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SignUpSheet
            // 
            this.ClientSize = new System.Drawing.Size(490, 203);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equipmentGroupBox);
            this.Controls.Add(this.equipmentInfo);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(studentName);
            this.Name = "SignUpSheet";
            this.Text = "Flyers Sports Club Sign-Up Sheet";
            this.equipmentGroupBox.ResumeLayout(false);
            this.equipmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.RichTextBox equipmentInfo;
        private System.Windows.Forms.CheckBox snowGloves;
        private System.Windows.Forms.CheckBox skis;
        private System.Windows.Forms.CheckBox goggles;
        private System.Windows.Forms.CheckBox coat;
        private System.Windows.Forms.CheckBox skiPoles;
        private System.Windows.Forms.CheckBox earmuffs;
        private System.Windows.Forms.GroupBox equipmentGroupBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;

    }
}

