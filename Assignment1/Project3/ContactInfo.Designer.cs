namespace Project3
{
    partial class ContactInfo
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
            this.studentName = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.ContactInfoDisplay = new System.Windows.Forms.RichTextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(12, 15);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(35, 13);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 41);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 68);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(96, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 91);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(285, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ContactInfoDisplay
            // 
            this.ContactInfoDisplay.Location = new System.Drawing.Point(303, 12);
            this.ContactInfoDisplay.Name = "ContactInfoDisplay";
            this.ContactInfoDisplay.ReadOnly = true;
            this.ContactInfoDisplay.Size = new System.Drawing.Size(482, 131);
            this.ContactInfoDisplay.TabIndex = 14;
            this.ContactInfoDisplay.Text = "";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(96, 65);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(201, 20);
            this.phoneTextBox.TabIndex = 3;
            this.phoneTextBox.Enter += new System.EventHandler(this.phoneTextBox_Enter);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 120);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(285, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(797, 157);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ContactInfoDisplay);
            this.Controls.Add(this.add);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentName);
            this.Name = "Form1";
            this.Text = "Contact Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox ContactInfoDisplay;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

