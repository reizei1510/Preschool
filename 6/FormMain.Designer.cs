namespace _6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnNavigation = new Panel();
            label2 = new Label();
            lbGroups = new Label();
            lbParents = new Label();
            lbChildrens = new Label();
            label4 = new Label();
            lbEnrollments = new Label();
            label1 = new Label();
            pnMain = new Panel();
            lbHelloText = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAddGroup = new Button();
            btnAddChild = new Button();
            btnMore = new Button();
            dataGridView = new DataGridView();
            pnNavigation.SuspendLayout();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pnNavigation
            // 
            pnNavigation.BorderStyle = BorderStyle.FixedSingle;
            pnNavigation.Controls.Add(label2);
            pnNavigation.Controls.Add(lbGroups);
            pnNavigation.Controls.Add(lbParents);
            pnNavigation.Controls.Add(lbChildrens);
            pnNavigation.Controls.Add(label4);
            pnNavigation.Controls.Add(lbEnrollments);
            pnNavigation.Controls.Add(label1);
            pnNavigation.Location = new Point(-2, -3);
            pnNavigation.Margin = new Padding(0);
            pnNavigation.Name = "pnNavigation";
            pnNavigation.Size = new Size(161, 412);
            pnNavigation.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 11);
            label2.Margin = new Padding(3, 9, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Приказы";
            // 
            // lbGroups
            // 
            lbGroups.AutoSize = true;
            lbGroups.Cursor = Cursors.Hand;
            lbGroups.Location = new Point(28, 131);
            lbGroups.Margin = new Padding(18, 9, 3, 0);
            lbGroups.Name = "lbGroups";
            lbGroups.Size = new Size(49, 15);
            lbGroups.TabIndex = 7;
            lbGroups.Text = "Группы";
            lbGroups.Click += lbGroups_Click;
            // 
            // lbParents
            // 
            lbParents.AutoSize = true;
            lbParents.Cursor = Cursors.Hand;
            lbParents.Location = new Point(28, 107);
            lbParents.Margin = new Padding(18, 9, 3, 0);
            lbParents.Name = "lbParents";
            lbParents.Size = new Size(59, 15);
            lbParents.TabIndex = 6;
            lbParents.Text = "Родители";
            lbParents.Click += lbParents_Click;
            // 
            // lbChildrens
            // 
            lbChildrens.AutoSize = true;
            lbChildrens.Cursor = Cursors.Hand;
            lbChildrens.Location = new Point(28, 83);
            lbChildrens.Margin = new Padding(18, 9, 3, 0);
            lbChildrens.Name = "lbChildrens";
            lbChildrens.Size = new Size(33, 15);
            lbChildrens.TabIndex = 5;
            lbChildrens.Text = "Дети";
            lbChildrens.Click += lbChildrens_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 59);
            label4.Margin = new Padding(3, 9, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 4;
            label4.Text = "Основные каталоги";
            // 
            // lbEnrollments
            // 
            lbEnrollments.AutoSize = true;
            lbEnrollments.Cursor = Cursors.Hand;
            lbEnrollments.Location = new Point(28, 35);
            lbEnrollments.Margin = new Padding(18, 9, 3, 0);
            lbEnrollments.Name = "lbEnrollments";
            lbEnrollments.Size = new Size(73, 15);
            lbEnrollments.TabIndex = 3;
            lbEnrollments.Text = "Зачисления";
            lbEnrollments.Click += lbEnrollments_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // pnMain
            // 
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Controls.Add(lbHelloText);
            pnMain.Controls.Add(btnEdit);
            pnMain.Controls.Add(btnDelete);
            pnMain.Controls.Add(btnAddGroup);
            pnMain.Controls.Add(btnAddChild);
            pnMain.Controls.Add(btnMore);
            pnMain.Controls.Add(dataGridView);
            pnMain.Location = new Point(159, -3);
            pnMain.Margin = new Padding(0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(454, 412);
            pnMain.TabIndex = 8;
            // 
            // lbHelloText
            // 
            lbHelloText.AutoSize = true;
            lbHelloText.Location = new Point(13, 24);
            lbHelloText.Name = "lbHelloText";
            lbHelloText.Size = new Size(232, 15);
            lbHelloText.TabIndex = 6;
            lbHelloText.Text = "Для начала работы выберите категорию";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(275, 373);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(365, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(3, 373);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(129, 23);
            btnAddGroup.TabIndex = 3;
            btnAddGroup.Text = "Создать группу";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(3, 373);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(143, 23);
            btnAddChild.TabIndex = 2;
            btnAddChild.Text = "Зачислить ребенка";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // btnMore
            // 
            btnMore.Location = new Point(185, 373);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(84, 23);
            btnMore.TabIndex = 1;
            btnMore.Text = "Подробнее";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += btnMore_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 14);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(446, 349);
            dataGridView.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(612, 406);
            Controls.Add(pnMain);
            Controls.Add(pnNavigation);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "МБДОУ «Детский сад “Солнышко”»";
            pnNavigation.ResumeLayout(false);
            pnNavigation.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNavigation;
        private Label lbGroups;
        private Label lbParents;
        private Label lbChildrens;
        private Label label4;
        private Label lbEnrollments;
        private Label label1;
        private Panel pnMain;
        private DataGridView dataGridView;
        private Button btnAddChild;
        private Button btnAddGroup;
        private Button btnMore;
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Label lbHelloText;
    }
}