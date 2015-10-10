namespace Project4
{
    partial class EmployeeData
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.contactInfoDisplay = new System.Windows.Forms.RichTextBox();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.clearAll = new System.Windows.Forms.Button();
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
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 41);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Number";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 68);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(51, 13);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Pay Rate";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(96, 38);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(201, 20);
            this.numberTextBox.TabIndex = 2;
            this.numberTextBox.Enter += new System.EventHandler(this.numberTextBox_Enter);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 117);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(140, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // contactInfoDisplay
            // 
            this.contactInfoDisplay.Location = new System.Drawing.Point(303, 12);
            this.contactInfoDisplay.Name = "contactInfoDisplay";
            this.contactInfoDisplay.ReadOnly = true;
            this.contactInfoDisplay.Size = new System.Drawing.Size(332, 157);
            this.contactInfoDisplay.TabIndex = 14;
            this.contactInfoDisplay.Text = "";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(96, 65);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(201, 20);
            this.payRateTextBox.TabIndex = 3;
            this.payRateTextBox.Enter += new System.EventHandler(this.payRateTextBox_Enter);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 146);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            this.saveFileDialog.Title = "Save File";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(96, 91);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(201, 20);
            this.hoursWorkedTextBox.TabIndex = 4;
            this.hoursWorkedTextBox.Enter += new System.EventHandler(this.hoursWorkedTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hours Worked";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(158, 146);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(139, 23);
            this.load.TabIndex = 8;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Open File";
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(158, 117);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(140, 23);
            this.clearAll.TabIndex = 6;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(654, 178);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.load);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.contactInfoDisplay);
            this.Controls.Add(this.add);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentName);
            this.Name = "Form1";
            this.Text = "Employee Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox contactInfoDisplay;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button clearAll;

    }
}

