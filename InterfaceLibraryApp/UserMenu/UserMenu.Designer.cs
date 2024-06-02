namespace InterfaceLibraryApp
{
    partial class UserMenu
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
            pictureBox1 = new PictureBox();
            WelcomeDisplay = new Label();
            DownPrompt = new Label();
            UserDownButton = new Button();
            SearchByPrompt = new Label();
            SearchByIdButton = new Button();
            SearchByNameButton = new Button();
            SearchByGenreButton = new Button();
            LoansPrompt = new Label();
            MakeaLoanButton = new Button();
            TransferBookUserButton = new Button();
            ReturnBookUserButton = new Button();
            CommentPrompt1 = new Label();
            CommentPrompt2 = new Label();
            CommentPrompt3 = new Label();
            CommentPrompt4 = new Label();
            CommentPrompt5 = new Label();
            CommentPrompt6 = new Label();
            CommentUserButton = new Button();
            DisplayUserLoansButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 236);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // WelcomeDisplay
            // 
            WelcomeDisplay.AutoSize = true;
            WelcomeDisplay.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeDisplay.ForeColor = Color.White;
            WelcomeDisplay.Location = new Point(12, 261);
            WelcomeDisplay.Margin = new Padding(4, 0, 4, 0);
            WelcomeDisplay.Name = "WelcomeDisplay";
            WelcomeDisplay.Size = new Size(45, 20);
            WelcomeDisplay.TabIndex = 1;
            WelcomeDisplay.Text = "Label";
            // 
            // DownPrompt
            // 
            DownPrompt.AutoSize = true;
            DownPrompt.Font = new Font("Segoe UI", 10F);
            DownPrompt.ForeColor = SystemColors.ActiveCaption;
            DownPrompt.Location = new Point(12, 286);
            DownPrompt.Name = "DownPrompt";
            DownPrompt.Size = new Size(143, 19);
            DownPrompt.TabIndex = 2;
            DownPrompt.Text = "Deseas darse de baja?";
            // 
            // UserDownButton
            // 
            UserDownButton.BackColor = Color.FromArgb(196, 121, 51);
            UserDownButton.FlatStyle = FlatStyle.Popup;
            UserDownButton.Font = new Font("Segoe UI", 9F);
            UserDownButton.ForeColor = Color.Black;
            UserDownButton.Location = new Point(12, 314);
            UserDownButton.Name = "UserDownButton";
            UserDownButton.Size = new Size(53, 24);
            UserDownButton.TabIndex = 3;
            UserDownButton.Text = "Baja";
            UserDownButton.TextAlign = ContentAlignment.TopCenter;
            UserDownButton.UseVisualStyleBackColor = false;
            UserDownButton.Click += UserDownButton_Click;
            // 
            // SearchByPrompt
            // 
            SearchByPrompt.AutoSize = true;
            SearchByPrompt.Location = new Point(240, 11);
            SearchByPrompt.Name = "SearchByPrompt";
            SearchByPrompt.Size = new Size(134, 21);
            SearchByPrompt.TabIndex = 4;
            SearchByPrompt.Text = "Buscar libros por :";
            // 
            // SearchByIdButton
            // 
            SearchByIdButton.BackColor = Color.FromArgb(95, 145, 222);
            SearchByIdButton.FlatStyle = FlatStyle.Popup;
            SearchByIdButton.Font = new Font("Segoe UI", 9F);
            SearchByIdButton.ForeColor = Color.Black;
            SearchByIdButton.Location = new Point(248, 95);
            SearchByIdButton.Name = "SearchByIdButton";
            SearchByIdButton.Size = new Size(47, 24);
            SearchByIdButton.TabIndex = 5;
            SearchByIdButton.Text = "ID";
            SearchByIdButton.UseVisualStyleBackColor = false;
            SearchByIdButton.Click += SearchByIdButton_Click;
            // 
            // SearchByNameButton
            // 
            SearchByNameButton.BackColor = Color.FromArgb(95, 145, 222);
            SearchByNameButton.FlatStyle = FlatStyle.Popup;
            SearchByNameButton.Font = new Font("Segoe UI", 8F);
            SearchByNameButton.ForeColor = Color.Black;
            SearchByNameButton.ImageAlign = ContentAlignment.TopCenter;
            SearchByNameButton.Location = new Point(248, 35);
            SearchByNameButton.Name = "SearchByNameButton";
            SearchByNameButton.Size = new Size(74, 24);
            SearchByNameButton.TabIndex = 6;
            SearchByNameButton.Text = "Nombre";
            SearchByNameButton.UseVisualStyleBackColor = false;
            SearchByNameButton.Click += SearchByNameButton_Click;
            // 
            // SearchByGenreButton
            // 
            SearchByGenreButton.BackColor = Color.FromArgb(95, 145, 222);
            SearchByGenreButton.FlatStyle = FlatStyle.Popup;
            SearchByGenreButton.Font = new Font("Segoe UI", 9F);
            SearchByGenreButton.ForeColor = Color.Black;
            SearchByGenreButton.Location = new Point(248, 65);
            SearchByGenreButton.Name = "SearchByGenreButton";
            SearchByGenreButton.Size = new Size(84, 24);
            SearchByGenreButton.TabIndex = 7;
            SearchByGenreButton.Text = "Generos";
            SearchByGenreButton.UseVisualStyleBackColor = false;
            SearchByGenreButton.Click += SearchByGenreButton_Click;
            // 
            // LoansPrompt
            // 
            LoansPrompt.AutoSize = true;
            LoansPrompt.Location = new Point(240, 138);
            LoansPrompt.Name = "LoansPrompt";
            LoansPrompt.Size = new Size(90, 21);
            LoansPrompt.TabIndex = 8;
            LoansPrompt.Text = "Prestamos :";
            // 
            // MakeaLoanButton
            // 
            MakeaLoanButton.BackColor = Color.FromArgb(95, 145, 222);
            MakeaLoanButton.FlatStyle = FlatStyle.Popup;
            MakeaLoanButton.Font = new Font("Segoe UI", 9F);
            MakeaLoanButton.ForeColor = Color.Black;
            MakeaLoanButton.Location = new Point(248, 162);
            MakeaLoanButton.Name = "MakeaLoanButton";
            MakeaLoanButton.Size = new Size(138, 24);
            MakeaLoanButton.TabIndex = 9;
            MakeaLoanButton.Text = "Realizar Prestamo";
            MakeaLoanButton.UseVisualStyleBackColor = false;
            MakeaLoanButton.Click += MakeaLoanButton_Click;
            // 
            // TransferBookUserButton
            // 
            TransferBookUserButton.BackColor = Color.FromArgb(95, 145, 222);
            TransferBookUserButton.FlatStyle = FlatStyle.Popup;
            TransferBookUserButton.Font = new Font("Segoe UI", 9F);
            TransferBookUserButton.ForeColor = Color.Black;
            TransferBookUserButton.Location = new Point(248, 192);
            TransferBookUserButton.Name = "TransferBookUserButton";
            TransferBookUserButton.Size = new Size(138, 24);
            TransferBookUserButton.TabIndex = 10;
            TransferBookUserButton.Text = "Transferir libro ";
            TransferBookUserButton.UseVisualStyleBackColor = false;
            TransferBookUserButton.Click += TransferBookUserButton_Click;
            // 
            // ReturnBookUserButton
            // 
            ReturnBookUserButton.BackColor = Color.FromArgb(95, 145, 222);
            ReturnBookUserButton.FlatStyle = FlatStyle.Popup;
            ReturnBookUserButton.Font = new Font("Segoe UI", 9F);
            ReturnBookUserButton.ForeColor = Color.Black;
            ReturnBookUserButton.Location = new Point(248, 222);
            ReturnBookUserButton.Name = "ReturnBookUserButton";
            ReturnBookUserButton.Size = new Size(138, 24);
            ReturnBookUserButton.TabIndex = 11;
            ReturnBookUserButton.Text = "Devolver libro";
            ReturnBookUserButton.UseVisualStyleBackColor = false;
            ReturnBookUserButton.Click += ReturnBookUserButton_Click;
            // 
            // CommentPrompt1
            // 
            CommentPrompt1.AutoSize = true;
            CommentPrompt1.Font = new Font("Segoe UI", 10F);
            CommentPrompt1.Location = new Point(240, 303);
            CommentPrompt1.Name = "CommentPrompt1";
            CommentPrompt1.Size = new Size(135, 19);
            CommentPrompt1.TabIndex = 12;
            CommentPrompt1.Text = "No tenemos un libro";
            // 
            // CommentPrompt2
            // 
            CommentPrompt2.AutoSize = true;
            CommentPrompt2.Font = new Font("Segoe UI", 10F);
            CommentPrompt2.Location = new Point(240, 326);
            CommentPrompt2.Name = "CommentPrompt2";
            CommentPrompt2.Size = new Size(92, 19);
            CommentPrompt2.TabIndex = 13;
            CommentPrompt2.Text = "que buscabas";
            // 
            // CommentPrompt3
            // 
            CommentPrompt3.AutoSize = true;
            CommentPrompt3.Font = new Font("Segoe UI", 10F);
            CommentPrompt3.Location = new Point(240, 351);
            CommentPrompt3.Name = "CommentPrompt3";
            CommentPrompt3.Size = new Size(127, 19);
            CommentPrompt3.TabIndex = 14;
            CommentPrompt3.Text = "deja un comentario";
            // 
            // CommentPrompt4
            // 
            CommentPrompt4.AutoSize = true;
            CommentPrompt4.Font = new Font("Segoe UI", 10F);
            CommentPrompt4.Location = new Point(240, 374);
            CommentPrompt4.Name = "CommentPrompt4";
            CommentPrompt4.Size = new Size(112, 19);
            CommentPrompt4.TabIndex = 15;
            CommentPrompt4.Text = "con su nombre y";
            // 
            // CommentPrompt5
            // 
            CommentPrompt5.AutoSize = true;
            CommentPrompt5.Font = new Font("Segoe UI", 10F);
            CommentPrompt5.Location = new Point(240, 397);
            CommentPrompt5.Name = "CommentPrompt5";
            CommentPrompt5.Size = new Size(149, 19);
            CommentPrompt5.TabIndex = 16;
            CommentPrompt5.Text = "veremos que podemos";
            // 
            // CommentPrompt6
            // 
            CommentPrompt6.AutoSize = true;
            CommentPrompt6.Font = new Font("Segoe UI", 10F);
            CommentPrompt6.Location = new Point(240, 420);
            CommentPrompt6.Name = "CommentPrompt6";
            CommentPrompt6.Size = new Size(42, 19);
            CommentPrompt6.TabIndex = 17;
            CommentPrompt6.Text = "hacer";
            // 
            // CommentUserButton
            // 
            CommentUserButton.BackColor = Color.FromArgb(95, 145, 222);
            CommentUserButton.FlatStyle = FlatStyle.Popup;
            CommentUserButton.Font = new Font("Segoe UI", 9F);
            CommentUserButton.ForeColor = Color.Black;
            CommentUserButton.Location = new Point(240, 442);
            CommentUserButton.Name = "CommentUserButton";
            CommentUserButton.Size = new Size(82, 24);
            CommentUserButton.TabIndex = 18;
            CommentUserButton.Text = "Comentar";
            CommentUserButton.UseVisualStyleBackColor = false;
            CommentUserButton.Click += CommentUserButton_Click;
            // 
            // DisplayUserLoansButton
            // 
            DisplayUserLoansButton.BackColor = Color.FromArgb(95, 145, 222);
            DisplayUserLoansButton.FlatStyle = FlatStyle.Popup;
            DisplayUserLoansButton.Font = new Font("Segoe UI", 9F);
            DisplayUserLoansButton.ForeColor = Color.Black;
            DisplayUserLoansButton.Location = new Point(248, 252);
            DisplayUserLoansButton.Name = "DisplayUserLoansButton";
            DisplayUserLoansButton.Size = new Size(159, 24);
            DisplayUserLoansButton.TabIndex = 19;
            DisplayUserLoansButton.Text = "Consultar prestamos";
            DisplayUserLoansButton.UseVisualStyleBackColor = false;
            DisplayUserLoansButton.Click += DisplayUserLoansButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(212, 38, 48);
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Segoe UI", 9F);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(397, 442);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(66, 24);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "Salir";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(476, 474);
            Controls.Add(ExitButton);
            Controls.Add(DisplayUserLoansButton);
            Controls.Add(CommentUserButton);
            Controls.Add(CommentPrompt6);
            Controls.Add(CommentPrompt5);
            Controls.Add(CommentPrompt4);
            Controls.Add(CommentPrompt3);
            Controls.Add(CommentPrompt2);
            Controls.Add(CommentPrompt1);
            Controls.Add(ReturnBookUserButton);
            Controls.Add(TransferBookUserButton);
            Controls.Add(MakeaLoanButton);
            Controls.Add(LoansPrompt);
            Controls.Add(SearchByGenreButton);
            Controls.Add(SearchByNameButton);
            Controls.Add(SearchByIdButton);
            Controls.Add(SearchByPrompt);
            Controls.Add(UserDownButton);
            Controls.Add(DownPrompt);
            Controls.Add(WelcomeDisplay);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "UserMenu";
            Text = "UserMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label WelcomeDisplay;
        private Label DownPrompt;
        private Button UserDownButton;
        private Label SearchByPrompt;
        private Button SearchByIdButton;
        private Button SearchByNameButton;
        private Button SearchByGenreButton;
        private Label LoansPrompt;
        private Button MakeaLoanButton;
        private Button TransferBookUserButton;
        private Button ReturnBookUserButton;
        private Label CommentPrompt1;
        private Label CommentPrompt2;
        private Label CommentPrompt3;
        private Label CommentPrompt4;
        private Label CommentPrompt5;
        private Label CommentPrompt6;
        private Button CommentUserButton;
        private Button DisplayUserLoansButton;
        private Button ExitButton;
    }
}