namespace Project1
{
    partial class NewStudentForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label studentLevelLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataLabel1 = new System.Windows.Forms.Label();
            this.studentLevelComboBox = new System.Windows.Forms.ComboBox();
            this.dataTextBox2 = new System.Windows.Forms.TextBox();
            this.dataLabel2 = new System.Windows.Forms.Label();
            this.dataTextBox3 = new System.Windows.Forms.TextBox();
            this.dataLabel3 = new System.Windows.Forms.Label();
            this.dataComboBox1 = new System.Windows.Forms.ComboBox();
            this.createStudent = new System.Windows.Forms.Button();
            this.NewStudentInfo = new System.Windows.Forms.RichTextBox();
            studentName = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            studentLevelLabel = new System.Windows.Forms.Label();
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "ID";
            // 
            // studentLevelLabel
            // 
            studentLevelLabel.AutoSize = true;
            studentLevelLabel.Location = new System.Drawing.Point(12, 68);
            studentLevelLabel.Name = "studentLevelLabel";
            studentLevelLabel.Size = new System.Drawing.Size(73, 13);
            studentLevelLabel.TabIndex = 6;
            studentLevelLabel.Text = "Student Level";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(166, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(174, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // dataLabel1
            // 
            this.dataLabel1.AutoSize = true;
            this.dataLabel1.Location = new System.Drawing.Point(12, 95);
            this.dataLabel1.Name = "dataLabel1";
            this.dataLabel1.Size = new System.Drawing.Size(60, 13);
            this.dataLabel1.TabIndex = 4;
            this.dataLabel1.Text = "dataLabel1";
            this.dataLabel1.Visible = false;
            // 
            // studentLevelComboBox
            // 
            this.studentLevelComboBox.FormattingEnabled = true;
            this.studentLevelComboBox.Items.AddRange(new object[] {
            "Undergraduate",
            "Graduate"});
            this.studentLevelComboBox.Location = new System.Drawing.Point(166, 65);
            this.studentLevelComboBox.Name = "studentLevelComboBox";
            this.studentLevelComboBox.Size = new System.Drawing.Size(174, 21);
            this.studentLevelComboBox.TabIndex = 3;
            this.studentLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.studentLevelComboBox_SelectedIndexChanged);
            // 
            // dataTextBox2
            // 
            this.dataTextBox2.Location = new System.Drawing.Point(166, 120);
            this.dataTextBox2.Name = "dataTextBox2";
            this.dataTextBox2.Size = new System.Drawing.Size(174, 20);
            this.dataTextBox2.TabIndex = 5;
            this.dataTextBox2.Visible = false;
            // 
            // dataLabel2
            // 
            this.dataLabel2.AutoSize = true;
            this.dataLabel2.Location = new System.Drawing.Point(12, 123);
            this.dataLabel2.Name = "dataLabel2";
            this.dataLabel2.Size = new System.Drawing.Size(60, 13);
            this.dataLabel2.TabIndex = 8;
            this.dataLabel2.Text = "dataLabel2";
            this.dataLabel2.Visible = false;
            // 
            // dataTextBox3
            // 
            this.dataTextBox3.Location = new System.Drawing.Point(166, 146);
            this.dataTextBox3.Name = "dataTextBox3";
            this.dataTextBox3.Size = new System.Drawing.Size(174, 20);
            this.dataTextBox3.TabIndex = 6;
            this.dataTextBox3.Visible = false;
            // 
            // dataLabel3
            // 
            this.dataLabel3.AutoSize = true;
            this.dataLabel3.Location = new System.Drawing.Point(12, 149);
            this.dataLabel3.Name = "dataLabel3";
            this.dataLabel3.Size = new System.Drawing.Size(60, 13);
            this.dataLabel3.TabIndex = 10;
            this.dataLabel3.Text = "dataLabel3";
            this.dataLabel3.Visible = false;
            // 
            // dataComboBox1
            // 
            this.dataComboBox1.FormattingEnabled = true;
            this.dataComboBox1.Location = new System.Drawing.Point(166, 92);
            this.dataComboBox1.Name = "dataComboBox1";
            this.dataComboBox1.Size = new System.Drawing.Size(174, 21);
            this.dataComboBox1.TabIndex = 4;
            this.dataComboBox1.Visible = false;
            // 
            // createStudent
            // 
            this.createStudent.Location = new System.Drawing.Point(15, 172);
            this.createStudent.Name = "createStudent";
            this.createStudent.Size = new System.Drawing.Size(325, 23);
            this.createStudent.TabIndex = 7;
            this.createStudent.Text = "Create Student";
            this.createStudent.UseVisualStyleBackColor = true;
            this.createStudent.Click += new System.EventHandler(this.createStudent_Click);
            // 
            // NewStudentInfo
            // 
            this.NewStudentInfo.Location = new System.Drawing.Point(346, 12);
            this.NewStudentInfo.Name = "NewStudentInfo";
            this.NewStudentInfo.ReadOnly = true;
            this.NewStudentInfo.Size = new System.Drawing.Size(332, 183);
            this.NewStudentInfo.TabIndex = 14;
            this.NewStudentInfo.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 209);
            this.Controls.Add(this.NewStudentInfo);
            this.Controls.Add(this.createStudent);
            this.Controls.Add(this.dataComboBox1);
            this.Controls.Add(this.dataTextBox3);
            this.Controls.Add(this.dataLabel3);
            this.Controls.Add(this.dataTextBox2);
            this.Controls.Add(this.dataLabel2);
            this.Controls.Add(this.studentLevelComboBox);
            this.Controls.Add(studentLevelLabel);
            this.Controls.Add(this.dataLabel1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(studentName);
            this.Name = "Form1";
            this.Text = "New Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label dataLabel1;
        private System.Windows.Forms.ComboBox studentLevelComboBox;
        private System.Windows.Forms.TextBox dataTextBox2;
        private System.Windows.Forms.Label dataLabel2;
        private System.Windows.Forms.TextBox dataTextBox3;
        private System.Windows.Forms.Label dataLabel3;
        private System.Windows.Forms.ComboBox dataComboBox1;
        private System.Windows.Forms.Button createStudent;
        private System.Windows.Forms.RichTextBox NewStudentInfo;

    }
}

