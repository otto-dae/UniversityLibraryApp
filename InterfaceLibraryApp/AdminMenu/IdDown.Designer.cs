namespace InterfaceLibraryApp
{
    partial class IdDown
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
            IdDownTextBox = new TextBox();
            AcceptIdDownButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID a dar de baja:";
            // 
            // IdDownTextBox
            // 
            IdDownTextBox.Location = new Point(180, 8);
            IdDownTextBox.Name = "IdDownTextBox";
            IdDownTextBox.Size = new Size(100, 23);
            IdDownTextBox.TabIndex = 1;
            // 
            // AcceptIdDownButton
            // 
            AcceptIdDownButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptIdDownButton.FlatStyle = FlatStyle.Popup;
            AcceptIdDownButton.Location = new Point(115, 38);
            AcceptIdDownButton.Name = "AcceptIdDownButton";
            AcceptIdDownButton.Size = new Size(56, 23);
            AcceptIdDownButton.TabIndex = 2;
            AcceptIdDownButton.Text = "Aceptar";
            AcceptIdDownButton.UseVisualStyleBackColor = false;
            AcceptIdDownButton.Click += AcceptIdDownButton_Click;
            // 
            // IdDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(294, 71);
            Controls.Add(AcceptIdDownButton);
            Controls.Add(IdDownTextBox);
            Controls.Add(label1);
            Name = "IdDown";
            Text = "IdDown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdDownTextBox;
        private Button AcceptIdDownButton;
    }
}