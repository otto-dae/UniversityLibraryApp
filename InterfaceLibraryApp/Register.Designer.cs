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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.ForeColor = Color.White;
            FullName.Location = new Point(14, 180);
            FullName.Name = "FullName";
            FullName.Size = new Size(137, 20);
            FullName.TabIndex = 0;
            FullName.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 310);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Password: ";
            // 
            // FullNameBox
            // 
            FullNameBox.Location = new Point(12, 203);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(274, 27);
            FullNameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(12, 333);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(274, 27);
            PasswordBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(10, 240);
            label2.Name = "label2";
            label2.Size = new Size(276, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre, iniciando por nombre personal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(10, 260);
            label3.Name = "label3";
            label3.Size = new Size(284, 20);
            label3.TabIndex = 5;
            label3.Text = "Seguido de primer apellido y terminando";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(10, 280);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 6;
            label4.Text = "Con segundo apellido";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 156);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // RegisterButtonAccept
            // 
            RegisterButtonAccept.Location = new Point(108, 381);
            RegisterButtonAccept.Name = "RegisterButtonAccept";
            RegisterButtonAccept.Size = new Size(94, 29);
            RegisterButtonAccept.TabIndex = 8;
            RegisterButtonAccept.Text = "Aceptar";
            RegisterButtonAccept.UseVisualStyleBackColor = true;
            RegisterButtonAccept.Click += RegisterButtonAccept_Click;
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(312, 441);
            Controls.Add(RegisterButtonAccept);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(FullNameBox);
            Controls.Add(label1);
            Controls.Add(FullName);
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
    }
}