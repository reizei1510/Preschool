namespace _6
{
    partial class FormAddChild
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
            label1 = new Label();
            tbChildLastName = new TextBox();
            tbChildFirstName = new TextBox();
            tbChildMiddleName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            label6 = new Label();
            tbAddress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            rtbInfo = new RichTextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label10 = new Label();
            label11 = new Label();
            tbParentMiddleName = new TextBox();
            tbParentFirstName = new TextBox();
            tbParentLastName = new TextBox();
            label12 = new Label();
            tbPhone = new TextBox();
            label13 = new Label();
            label14 = new Label();
            tbEmail = new TextBox();
            label15 = new Label();
            cbGroup = new ComboBox();
            gbParent = new GroupBox();
            cbParent = new ComboBox();
            gbChild = new GroupBox();
            lbMessage = new Label();
            gbParent.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // tbChildLastName
            // 
            tbChildLastName.Location = new Point(19, 62);
            tbChildLastName.Name = "tbChildLastName";
            tbChildLastName.Size = new Size(160, 23);
            tbChildLastName.TabIndex = 1;
            // 
            // tbChildFirstName
            // 
            tbChildFirstName.Location = new Point(185, 62);
            tbChildFirstName.Name = "tbChildFirstName";
            tbChildFirstName.Size = new Size(160, 23);
            tbChildFirstName.TabIndex = 2;
            // 
            // tbChildMiddleName
            // 
            tbChildMiddleName.Location = new Point(351, 62);
            tbChildMiddleName.Name = "tbChildMiddleName";
            tbChildMiddleName.Size = new Size(160, 23);
            tbChildMiddleName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 44);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 98);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Пол";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "М", "Ж" });
            cbGender.Location = new Point(19, 116);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(76, 23);
            cbGender.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(101, 116);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 98);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 10;
            label6.Text = "Дата рождения";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(19, 170);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(492, 23);
            tbAddress.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 152);
            label7.Margin = new Padding(3, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "Адрес";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 206);
            label8.Margin = new Padding(3, 10, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 15);
            label8.TabIndex = 13;
            label8.Text = "Дополнительная информация";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(19, 224);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(492, 96);
            rtbInfo.TabIndex = 14;
            rtbInfo.Text = "";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(89, 517);
            btnConfirm.Margin = new Padding(80, 20, 3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(116, 23);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Добавить";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 517);
            btnCancel.Margin = new Padding(3, 3, 80, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(172, 58);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 22;
            label11.Text = "Имя";
            // 
            // tbParentMiddleName
            // 
            tbParentMiddleName.Location = new Point(338, 76);
            tbParentMiddleName.Name = "tbParentMiddleName";
            tbParentMiddleName.Size = new Size(160, 23);
            tbParentMiddleName.TabIndex = 21;
            // 
            // tbParentFirstName
            // 
            tbParentFirstName.Location = new Point(172, 75);
            tbParentFirstName.Name = "tbParentFirstName";
            tbParentFirstName.Size = new Size(160, 23);
            tbParentFirstName.TabIndex = 20;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(173, 112);
            label14.Name = "label14";
            label14.Size = new Size(113, 15);
            label14.TabIndex = 27;
            label14.Text = "Электронная почта";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(173, 130);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(160, 23);
            tbEmail.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(307, 98);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 29;
            label15.Text = "Группа";
            // 
            // cbGroup
            // 
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroup.FormattingEnabled = true;
            cbGroup.Location = new Point(307, 116);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(76, 23);
            cbGroup.TabIndex = 30;
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
            gbParent.TabIndex = 31;
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
            // gbChild
            // 
            gbChild.Location = new Point(12, 19);
            gbChild.Margin = new Padding(3, 10, 3, 3);
            gbChild.Name = "gbChild";
            gbChild.Size = new Size(506, 308);
            gbChild.TabIndex = 32;
            gbChild.TabStop = false;
            gbChild.Text = "Ребенок";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.ForeColor = Color.Red;
            lbMessage.Location = new Point(18, 546);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 15);
            lbMessage.TabIndex = 33;
            // 
            // FormAddChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(530, 570);
            Controls.Add(lbMessage);
            Controls.Add(cbGroup);
            Controls.Add(label15);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
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
            Name = "FormAddChild";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Зачисление ребенка";
            gbParent.ResumeLayout(false);
            gbParent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbChildLastName;
        private TextBox tbChildFirstName;
        private TextBox tbChildMiddleName;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Label label6;
        private TextBox tbAddress;
        private Label label7;
        private Label label8;
        private RichTextBox rtbInfo;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label10;
        private Label label11;
        private TextBox tbParentMiddleName;
        private TextBox tbParentFirstName;
        private TextBox tbParentLastName;
        private Label label12;
        private TextBox tbPhone;
        private Label label13;
        private Label label14;
        private TextBox tbEmail;
        private Label label15;
        private ComboBox cbGroup;
        private GroupBox gbParent;
        private GroupBox gbChild;
        private Label lbMessage;
        private ComboBox cbParent;
    }
}