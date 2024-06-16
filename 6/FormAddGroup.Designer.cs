namespace _6
{
    partial class FormAddGroup
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
            tbRoom = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 35);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Комната";
            // 
            // tbRoom
            // 
            tbRoom.Location = new Point(120, 32);
            tbRoom.Name = "tbRoom";
            tbRoom.Size = new Size(100, 23);
            tbRoom.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(40, 84);
            btnConfirm.Margin = new Padding(30, 3, 3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Добавить";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(162, 84);
            btnCancel.Margin = new Padding(3, 3, 30, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(275, 130);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbRoom);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAddGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление ребенка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbRoom;
        private Button btnConfirm;
        private Button btnCancel;
    }
}