namespace _6
{
    partial class FormMore
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
            rtbInfo = new RichTextBox();
            SuspendLayout();
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(12, 12);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(300, 426);
            rtbInfo.TabIndex = 0;
            rtbInfo.Text = "";
            // 
            // FormMore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(325, 450);
            Controls.Add(rtbInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMore";
            StartPosition = FormStartPosition.CenterParent;
            Text = "More";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbInfo;
    }
}