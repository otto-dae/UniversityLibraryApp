namespace InterfaceLibraryApp
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LogInAccept = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegisterButton = new Button();
            pictureBox1 = new PictureBox();
            ExitButtonLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // LogInAccept
            // 
            LogInAccept.BackColor = Color.FromArgb(95, 145, 222);
            LogInAccept.FlatStyle = FlatStyle.Popup;
            LogInAccept.Location = new Point(82, 333);
            LogInAccept.Name = "LogInAccept";
            LogInAccept.Size = new Size(75, 23);
            LogInAccept.TabIndex = 2;
            LogInAccept.Text = "Aceptar";
            LogInAccept.UseVisualStyleBackColor = false;
            LogInAccept.Click += LogInAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 243);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 277);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 391);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Nuevo? Registrate";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(95, 145, 222);
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.Location = new Point(135, 387);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Registrar";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 141);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ExitButtonLogIn
            // 
            ExitButtonLogIn.BackColor = Color.FromArgb(212, 38, 48);
            ExitButtonLogIn.FlatStyle = FlatStyle.Popup;
            ExitButtonLogIn.Location = new Point(183, 429);
            ExitButtonLogIn.Name = "ExitButtonLogIn";
            ExitButtonLogIn.Size = new Size(49, 20);
            ExitButtonLogIn.TabIndex = 8;
            ExitButtonLogIn.Text = "Salir";
            ExitButtonLogIn.UseVisualStyleBackColor = false;
            ExitButtonLogIn.Click += ExitButtonLogIn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(244, 461);
            Controls.Add(ExitButtonLogIn);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogInAccept);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button LogInAccept;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegisterButton;
        private PictureBox pictureBox1;
        private Button ExitButtonLogIn;
    }
}
