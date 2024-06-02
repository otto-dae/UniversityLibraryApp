namespace InterfaceLibraryApp
{
    partial class DeactivateBookWindow
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
            SearchIdTextBox = new TextBox();
            AcceptButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 0;
            label1.Text = "ID de libro a dar de baja:";
            // 
            // SearchIdTextBox
            // 
            SearchIdTextBox.Location = new Point(176, 18);
            SearchIdTextBox.Name = "SearchIdTextBox";
            SearchIdTextBox.Size = new Size(116, 23);
            SearchIdTextBox.TabIndex = 1;
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptButton.FlatStyle = FlatStyle.Popup;
            AcceptButton.Location = new Point(122, 56);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(60, 23);
            AcceptButton.TabIndex = 2;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // DeactivateBookWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(304, 91);
            Controls.Add(AcceptButton);
            Controls.Add(SearchIdTextBox);
            Controls.Add(label1);
            Name = "DeactivateBookWindow";
            Text = "DeactivateBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchIdTextBox;
        private Button AcceptButton;
    }
}