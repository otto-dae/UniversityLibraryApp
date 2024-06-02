namespace InterfaceLibraryApp
{
    partial class UnregisterUserMenu
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
            PasswordUserDownBox = new TextBox();
            label1 = new Label();
            AcceptButtonUserDown = new Button();
            SuspendLayout();
            // 
            // PasswordUserDownBox
            // 
            PasswordUserDownBox.Location = new Point(50, 12);
            PasswordUserDownBox.Name = "PasswordUserDownBox";
            PasswordUserDownBox.Size = new Size(259, 23);
            PasswordUserDownBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 38);
            label1.Name = "label1";
            label1.Size = new Size(259, 19);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su contraseña para darse de baja";
            // 
            // AcceptButtonUserDown
            // 
            AcceptButtonUserDown.BackColor = Color.FromArgb(95, 145, 222);
            AcceptButtonUserDown.FlatStyle = FlatStyle.Popup;
            AcceptButtonUserDown.Location = new Point(142, 60);
            AcceptButtonUserDown.Name = "AcceptButtonUserDown";
            AcceptButtonUserDown.Size = new Size(64, 25);
            AcceptButtonUserDown.TabIndex = 2;
            AcceptButtonUserDown.Text = "Aceptar";
            AcceptButtonUserDown.UseVisualStyleBackColor = false;
            AcceptButtonUserDown.Click += AcceptButtonUserDown_Click;
            // 
            // UnregisterUserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(359, 100);
            Controls.Add(AcceptButtonUserDown);
            Controls.Add(label1);
            Controls.Add(PasswordUserDownBox);
            Name = "UnregisterUserMenu";
            Text = "UnregisterUserMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordUserDownBox;
        private Label label1;
        private Button AcceptButtonUserDown;
    }
}