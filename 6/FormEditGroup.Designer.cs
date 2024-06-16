namespace _6
{
    partial class FormEditGroup
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
            btnCancel = new Button();
            btnSave = new Button();
            tbRoom = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(161, 80);
            btnCancel.Margin = new Padding(3, 3, 30, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(39, 80);
            btnSave.Margin = new Padding(30, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbRoom
            // 
            tbRoom.Location = new Point(119, 28);
            tbRoom.Name = "tbRoom";
            tbRoom.Size = new Size(100, 23);
            tbRoom.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 31);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Комната";
            // 
            // FormEditGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(275, 130);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbRoom);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEditGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Изменение группы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox tbRoom;
        private Label label1;
    }
}