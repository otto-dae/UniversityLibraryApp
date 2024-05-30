namespace InterfaceLibraryApp
{
    partial class AdminMenu
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
            AdminUserPrompt = new Label();
            UserRegisterAdminButton = new Button();
            DeactivateUserAdminButton = new Button();
            ChangePrivilagesAdminButton = new Button();
            ModifyNameUserAdminButton = new Button();
            AdminBooksPrompt = new Label();
            AddNewBookAdminButton = new Button();
            UnregisterBookAdminButton = new Button();
            ModifyNameBookAdminButton = new Button();
            ModifyQuantityBookAdminButton = new Button();
            ReadCommentsAdminButton = new Button();
            ReadLoansAdminButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 10);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // WelcomeDisplay
            // 
            WelcomeDisplay.AutoSize = true;
            WelcomeDisplay.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeDisplay.ForeColor = Color.White;
            WelcomeDisplay.Location = new Point(11, 224);
            WelcomeDisplay.Margin = new Padding(4, 0, 4, 0);
            WelcomeDisplay.Name = "WelcomeDisplay";
            WelcomeDisplay.Size = new Size(45, 20);
            WelcomeDisplay.TabIndex = 2;
            WelcomeDisplay.Text = "Label";
            // 
            // AdminUserPrompt
            // 
            AdminUserPrompt.AutoSize = true;
            AdminUserPrompt.Font = new Font("Segoe UI", 11F);
            AdminUserPrompt.ForeColor = Color.White;
            AdminUserPrompt.Location = new Point(253, 10);
            AdminUserPrompt.Name = "AdminUserPrompt";
            AdminUserPrompt.Size = new Size(151, 20);
            AdminUserPrompt.TabIndex = 3;
            AdminUserPrompt.Text = "Administrar usuarios :";
            // 
            // UserRegisterAdminButton
            // 
            UserRegisterAdminButton.Location = new Point(261, 31);
            UserRegisterAdminButton.Margin = new Padding(3, 2, 3, 2);
            UserRegisterAdminButton.Name = "UserRegisterAdminButton";
            UserRegisterAdminButton.Size = new Size(141, 22);
            UserRegisterAdminButton.TabIndex = 4;
            UserRegisterAdminButton.Text = "Dar de alta a usuario";
            UserRegisterAdminButton.UseVisualStyleBackColor = true;
            // 
            // DeactivateUserAdminButton
            // 
            DeactivateUserAdminButton.Location = new Point(261, 58);
            DeactivateUserAdminButton.Margin = new Padding(3, 2, 3, 2);
            DeactivateUserAdminButton.Name = "DeactivateUserAdminButton";
            DeactivateUserAdminButton.Size = new Size(141, 22);
            DeactivateUserAdminButton.TabIndex = 5;
            DeactivateUserAdminButton.Text = "Dar de baja a usuario";
            DeactivateUserAdminButton.UseVisualStyleBackColor = true;
            // 
            // ChangePrivilagesAdminButton
            // 
            ChangePrivilagesAdminButton.Location = new Point(261, 85);
            ChangePrivilagesAdminButton.Margin = new Padding(3, 2, 3, 2);
            ChangePrivilagesAdminButton.Name = "ChangePrivilagesAdminButton";
            ChangePrivilagesAdminButton.Size = new Size(128, 23);
            ChangePrivilagesAdminButton.TabIndex = 6;
            ChangePrivilagesAdminButton.Text = "Cambiar privilegios";
            ChangePrivilagesAdminButton.UseVisualStyleBackColor = true;
            // 
            // ModifyNameUserAdminButton
            // 
            ModifyNameUserAdminButton.Location = new Point(261, 112);
            ModifyNameUserAdminButton.Margin = new Padding(3, 2, 3, 2);
            ModifyNameUserAdminButton.Name = "ModifyNameUserAdminButton";
            ModifyNameUserAdminButton.Size = new Size(126, 22);
            ModifyNameUserAdminButton.TabIndex = 7;
            ModifyNameUserAdminButton.Text = "Modificar nombre";
            ModifyNameUserAdminButton.UseVisualStyleBackColor = true;
            // 
            // AdminBooksPrompt
            // 
            AdminBooksPrompt.AutoSize = true;
            AdminBooksPrompt.Font = new Font("Segoe UI", 11F);
            AdminBooksPrompt.ForeColor = Color.White;
            AdminBooksPrompt.Location = new Point(253, 148);
            AdminBooksPrompt.Name = "AdminBooksPrompt";
            AdminBooksPrompt.Size = new Size(141, 20);
            AdminBooksPrompt.TabIndex = 8;
            AdminBooksPrompt.Text = "Administrar Libros : ";
            // 
            // AddNewBookAdminButton
            // 
            AddNewBookAdminButton.Location = new Point(261, 169);
            AddNewBookAdminButton.Margin = new Padding(3, 2, 3, 2);
            AddNewBookAdminButton.Name = "AddNewBookAdminButton";
            AddNewBookAdminButton.Size = new Size(94, 23);
            AddNewBookAdminButton.TabIndex = 9;
            AddNewBookAdminButton.Text = "Agregar libro";
            AddNewBookAdminButton.UseVisualStyleBackColor = true;
            // 
            // UnregisterBookAdminButton
            // 
            UnregisterBookAdminButton.Location = new Point(261, 196);
            UnregisterBookAdminButton.Margin = new Padding(3, 2, 3, 2);
            UnregisterBookAdminButton.Name = "UnregisterBookAdminButton";
            UnregisterBookAdminButton.Size = new Size(128, 22);
            UnregisterBookAdminButton.TabIndex = 10;
            UnregisterBookAdminButton.Text = "Dar de baja a libro";
            UnregisterBookAdminButton.UseVisualStyleBackColor = true;
            // 
            // ModifyNameBookAdminButton
            // 
            ModifyNameBookAdminButton.Location = new Point(261, 250);
            ModifyNameBookAdminButton.Margin = new Padding(3, 2, 3, 2);
            ModifyNameBookAdminButton.Name = "ModifyNameBookAdminButton";
            ModifyNameBookAdminButton.Size = new Size(126, 22);
            ModifyNameBookAdminButton.TabIndex = 11;
            ModifyNameBookAdminButton.Text = "Modificar nombre";
            ModifyNameBookAdminButton.UseVisualStyleBackColor = true;
            // 
            // ModifyQuantityBookAdminButton
            // 
            ModifyQuantityBookAdminButton.Location = new Point(261, 224);
            ModifyQuantityBookAdminButton.Margin = new Padding(3, 2, 3, 2);
            ModifyQuantityBookAdminButton.Name = "ModifyQuantityBookAdminButton";
            ModifyQuantityBookAdminButton.Size = new Size(128, 22);
            ModifyQuantityBookAdminButton.TabIndex = 12;
            ModifyQuantityBookAdminButton.Text = "Modificar cantidad";
            ModifyQuantityBookAdminButton.UseVisualStyleBackColor = true;
            // 
            // ReadCommentsAdminButton
            // 
            ReadCommentsAdminButton.Location = new Point(10, 250);
            ReadCommentsAdminButton.Margin = new Padding(3, 2, 3, 2);
            ReadCommentsAdminButton.Name = "ReadCommentsAdminButton";
            ReadCommentsAdminButton.Size = new Size(115, 22);
            ReadCommentsAdminButton.TabIndex = 13;
            ReadCommentsAdminButton.Text = "Leer comentarios";
            ReadCommentsAdminButton.UseVisualStyleBackColor = true;
            // 
            // ReadLoansAdminButton
            // 
            ReadLoansAdminButton.Location = new Point(10, 278);
            ReadLoansAdminButton.Margin = new Padding(3, 2, 3, 2);
            ReadLoansAdminButton.Name = "ReadLoansAdminButton";
            ReadLoansAdminButton.Size = new Size(115, 22);
            ReadLoansAdminButton.TabIndex = 14;
            ReadLoansAdminButton.Text = "Leer prestamos";
            ReadLoansAdminButton.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(479, 317);
            Controls.Add(ReadLoansAdminButton);
            Controls.Add(ReadCommentsAdminButton);
            Controls.Add(ModifyQuantityBookAdminButton);
            Controls.Add(ModifyNameBookAdminButton);
            Controls.Add(UnregisterBookAdminButton);
            Controls.Add(AddNewBookAdminButton);
            Controls.Add(AdminBooksPrompt);
            Controls.Add(ModifyNameUserAdminButton);
            Controls.Add(ChangePrivilagesAdminButton);
            Controls.Add(DeactivateUserAdminButton);
            Controls.Add(UserRegisterAdminButton);
            Controls.Add(AdminUserPrompt);
            Controls.Add(WelcomeDisplay);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label WelcomeDisplay;
        private Label AdminUserPrompt;
        private Button UserRegisterAdminButton;
        private Button DeactivateUserAdminButton;
        private Button ChangePrivilagesAdminButton;
        private Button ModifyNameUserAdminButton;
        private Label AdminBooksPrompt;
        private Button AddNewBookAdminButton;
        private Button UnregisterBookAdminButton;
        private Button ModifyNameBookAdminButton;
        private Button ModifyQuantityBookAdminButton;
        private Button ReadCommentsAdminButton;
        private Button ReadLoansAdminButton;
    }
}