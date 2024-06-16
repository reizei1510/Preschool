namespace _6
{
    partial class FormEditEnrollment
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
            cbGroup = new ComboBox();
            label15 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            rtbInfo = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            dtpBirthday = new DateTimePicker();
            cbGender = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbChildMiddleName = new TextBox();
            tbChildFirstName = new TextBox();
            tbChildLastName = new TextBox();
            label1 = new Label();
            gbParent = new GroupBox();
            cbParent = new ComboBox();
            tbPhone = new TextBox();
            label13 = new Label();
            tbEmail = new TextBox();
            label10 = new Label();
            label14 = new Label();
            tbParentMiddleName = new TextBox();
            label11 = new Label();
            tbParentLastName = new TextBox();
            label12 = new Label();
            tbParentFirstName = new TextBox();
            gbChild = new GroupBox();
            gbParent.SuspendLayout();
            SuspendLayout();
            // 
            // cbGroup
            // 
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroup.FormattingEnabled = true;
            cbGroup.Location = new Point(307, 116);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(76, 23);
            cbGroup.TabIndex = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(307, 98);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 49;
            label15.Text = "Группа";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 517);
            btnCancel.Margin = new Padding(3, 3, 80, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 23);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(89, 517);
            btnSave.Margin = new Padding(80, 20, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 23);
            btnSave.TabIndex = 47;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(19, 224);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(492, 96);
            rtbInfo.TabIndex = 46;
            rtbInfo.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 206);
            label8.Margin = new Padding(3, 10, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 15);
            label8.TabIndex = 45;
            label8.Text = "Дополнительная информация";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 152);
            label7.Margin = new Padding(3, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 44;
            label7.Text = "Адрес";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(19, 170);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(492, 23);
            tbAddress.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 98);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 42;
            label6.Text = "Дата рождения";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(101, 116);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 41;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "М", "Ж" });
            cbGender.Location = new Point(19, 116);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(76, 23);
            cbGender.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 98);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 39;
            label5.Text = "Пол";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 44);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 38;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 37;
            label2.Text = "Имя";
            // 
            // tbChildMiddleName
            // 
            tbChildMiddleName.Location = new Point(351, 62);
            tbChildMiddleName.Name = "tbChildMiddleName";
            tbChildMiddleName.Size = new Size(160, 23);
            tbChildMiddleName.TabIndex = 36;
            // 
            // tbChildFirstName
            // 
            tbChildFirstName.Location = new Point(185, 62);
            tbChildFirstName.Name = "tbChildFirstName";
            tbChildFirstName.Size = new Size(160, 23);
            tbChildFirstName.TabIndex = 35;
            // 
            // tbChildLastName
            // 
            tbChildLastName.Location = new Point(19, 62);
            tbChildLastName.Name = "tbChildLastName";
            tbChildLastName.Size = new Size(160, 23);
            tbChildLastName.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 33;
            label1.Text = "Фамилия";
            // 
            // gbParent
            // 
            gbParent.Controls.Add(cbParent);
            gbParent.Controls.Add(tbPhone);
            gbParent.Controls.Add(label13);
            gbParent.Controls.Add(tbEmail);
            gbParent.Controls.Add(label10);
            gbParent.Controls.Add(label14);
            gbParent.Controls.Add(tbParentMiddleName);
            gbParent.Controls.Add(label11);
            gbParent.Controls.Add(tbParentLastName);
            gbParent.Controls.Add(label12);
            gbParent.Controls.Add(tbParentFirstName);
            gbParent.Location = new Point(12, 333);
            gbParent.Margin = new Padding(3, 10, 3, 3);
            gbParent.Name = "gbParent";
            gbParent.Size = new Size(506, 161);
            gbParent.TabIndex = 51;
            gbParent.TabStop = false;
            gbParent.Text = "Родитель";
            // 
            // cbParent
            // 
            cbParent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParent.FormattingEnabled = true;
            cbParent.Location = new Point(6, 22);
            cbParent.Name = "cbParent";
            cbParent.Size = new Size(492, 23);
            cbParent.TabIndex = 28;
            cbParent.SelectedIndexChanged += cbParent_SelectedIndexChanged;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(7, 130);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(160, 23);
            tbPhone.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 112);
            label13.Margin = new Padding(3, 10, 3, 0);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 24;
            label13.Text = "Телефон";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(173, 130);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(160, 23);
            tbEmail.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(338, 58);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 23;
            label10.Text = "Отчество";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(173, 112);
            label14.Name = "label14";
            label14.Size = new Size(113, 15);
            label14.TabIndex = 27;
            label14.Text = "Электронная почта";
            // 
            // tbParentMiddleName
            // 
            tbParentMiddleName.Location = new Point(338, 76);
            tbParentMiddleName.Name = "tbParentMiddleName";
            tbParentMiddleName.Size = new Size(160, 23);
            tbParentMiddleName.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(172, 58);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 22;
            label11.Text = "Имя";
            // 
            // tbParentLastName
            // 
            tbParentLastName.Location = new Point(6, 76);
            tbParentLastName.Name = "tbParentLastName";
            tbParentLastName.Size = new Size(160, 23);
            tbParentLastName.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 58);
            label12.Margin = new Padding(3, 10, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 18;
            label12.Text = "Фамилия";
            // 
            // tbParentFirstName
            // 
            tbParentFirstName.Location = new Point(172, 75);
            tbParentFirstName.Name = "tbParentFirstName";
            tbParentFirstName.Size = new Size(160, 23);
            tbParentFirstName.TabIndex = 20;
            // 
            // gbChild
            // 
            gbChild.Location = new Point(12, 19);
            gbChild.Margin = new Padding(3, 10, 3, 3);
            gbChild.Name = "gbChild";
            gbChild.Size = new Size(506, 308);
            gbChild.TabIndex = 52;
            gbChild.TabStop = false;
            gbChild.Text = "Ребенок";
            // 
            // FormEditEnrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(530, 570);
            Controls.Add(cbGroup);
            Controls.Add(label15);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbInfo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbChildMiddleName);
            Controls.Add(tbChildFirstName);
            Controls.Add(tbChildLastName);
            Controls.Add(label1);
            Controls.Add(gbParent);
            Controls.Add(gbChild);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEditEnrollment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Изменение информации";
            gbParent.ResumeLayout(false);
            gbParent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGroup;
        private Label label15;
        private Button btnCancel;
        private Button btnSave;
        private RichTextBox rtbInfo;
        private Label label8;
        private Label label7;
        private TextBox tbAddress;
        private Label label6;
        private DateTimePicker dtpBirthday;
        private ComboBox cbGender;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox tbChildMiddleName;
        private TextBox tbChildFirstName;
        private TextBox tbChildLastName;
        private Label label1;
        private GroupBox gbParent;
        private ComboBox cbParent;
        private TextBox tbPhone;
        private Label label13;
        private TextBox tbEmail;
        private Label label10;
        private Label label14;
        private TextBox tbParentMiddleName;
        private Label label11;
        private TextBox tbParentLastName;
        private Label label12;
        private TextBox tbParentFirstName;
        private GroupBox gbChild;
    }
}