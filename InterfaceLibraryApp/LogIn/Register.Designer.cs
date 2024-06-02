namespace InterfaceLibraryApp
{
    partial class RegisterWindow
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
            FullName = new Label();
            label1 = new Label();
            FullNameBox = new TextBox();
            PasswordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            RegisterButtonAccept = new Button();
            BackLogInButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.ForeColor = Color.White;
            FullName.Location = new Point(12, 135);
            FullName.Name = "FullName";
            FullName.Size = new Size(110, 15);
            FullName.TabIndex = 0;
            FullName.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 232);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Password: ";
            // 
            // FullNameBox
            // 
            FullNameBox.Location = new Point(10, 152);
            FullNameBox.Margin = new Padding(3, 2, 3, 2);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(240, 23);
            FullNameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(10, 250);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(240, 23);
            PasswordBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(9, 180);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre, iniciando por nombre personal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(9, 195);
            label3.Name = "label3";
            label3.Size = new Size(223, 15);
            label3.TabIndex = 5;
            label3.Text = "Seguido de primer apellido y terminando";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(9, 210);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 6;
            label4.Text = "Con segundo apellido";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 117);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // RegisterButtonAccept
            // 
            RegisterButtonAccept.BackColor = Color.FromArgb(95, 145, 222);
            RegisterButtonAccept.FlatStyle = FlatStyle.Popup;
            RegisterButtonAccept.Location = new Point(193, 296);
            RegisterButtonAccept.Margin = new Padding(3, 2, 3, 2);
            RegisterButtonAccept.Name = "RegisterButtonAccept";
            RegisterButtonAccept.Size = new Size(57, 23);
            RegisterButtonAccept.TabIndex = 8;
            RegisterButtonAccept.Text = "Aceptar";
            RegisterButtonAccept.UseVisualStyleBackColor = false;
            RegisterButtonAccept.Click += RegisterButtonAccept_Click;
            // 
            // BackLogInButton
            // 
            BackLogInButton.BackColor = Color.FromArgb(95, 145, 222);
            BackLogInButton.FlatStyle = FlatStyle.Popup;
            BackLogInButton.Location = new Point(10, 296);
            BackLogInButton.Name = "BackLogInButton";
            BackLogInButton.Size = new Size(60, 23);
            BackLogInButton.TabIndex = 9;
            BackLogInButton.Text = "Regresar";
            BackLogInButton.UseVisualStyleBackColor = false;
            BackLogInButton.Click += BackLogInButton_Click;
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(273, 331);
            Controls.Add(BackLogInButton);
            Controls.Add(RegisterButtonAccept);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(FullNameBox);
            Controls.Add(label1);
            Controls.Add(FullName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterWindow";
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FullName;
        private Label label1;
        private TextBox FullNameBox;
        private TextBox PasswordBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button RegisterButtonAccept;
        private Button BackLogInButton;
    }
}