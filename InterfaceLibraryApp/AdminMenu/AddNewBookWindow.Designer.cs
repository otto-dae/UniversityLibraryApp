namespace InterfaceLibraryApp
{
    partial class AddNewBookWindow
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
            NewBookNameTextBox = new TextBox();
            labelgenre = new Label();
            label2 = new Label();
            NewBookGenresTextBox = new TextBox();
            label3 = new Label();
            AmountAvailableBook = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del libro:";
            // 
            // NewBookNameTextBox
            // 
            NewBookNameTextBox.Location = new Point(12, 31);
            NewBookNameTextBox.Name = "NewBookNameTextBox";
            NewBookNameTextBox.Size = new Size(319, 23);
            NewBookNameTextBox.TabIndex = 1;
            // 
            // labelgenre
            // 
            labelgenre.AutoSize = true;
            labelgenre.Font = new Font("Segoe UI", 10F);
            labelgenre.ForeColor = Color.White;
            labelgenre.Location = new Point(12, 61);
            labelgenre.Name = "labelgenre";
            labelgenre.Size = new Size(188, 19);
            labelgenre.TabIndex = 2;
            labelgenre.Text = "Ingrese los generos del libro: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(13, 53, 115);
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(169, 19);
            label2.TabIndex = 3;
            label2.Text = "(SEPARADOS POR COMA)";
            // 
            // NewBookGenresTextBox
            // 
            NewBookGenresTextBox.Location = new Point(12, 102);
            NewBookGenresTextBox.Name = "NewBookGenresTextBox";
            NewBookGenresTextBox.Size = new Size(319, 23);
            NewBookGenresTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(215, 19);
            label3.TabIndex = 5;
            label3.Text = "Ingrese la cantidad de ejemplares:";
            // 
            // AmountAvailableBook
            // 
            AmountAvailableBook.Location = new Point(12, 162);
            AmountAvailableBook.Name = "AmountAvailableBook";
            AmountAvailableBook.Size = new Size(77, 23);
            AmountAvailableBook.TabIndex = 6;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(95, 145, 222);
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Location = new Point(128, 196);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(72, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "Agregar";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // AddNewBookWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(343, 231);
            Controls.Add(AddButton);
            Controls.Add(AmountAvailableBook);
            Controls.Add(label3);
            Controls.Add(NewBookGenresTextBox);
            Controls.Add(label2);
            Controls.Add(labelgenre);
            Controls.Add(NewBookNameTextBox);
            Controls.Add(label1);
            Name = "AddNewBookWindow";
            Text = "AddNewBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewBookNameTextBox;
        private Label labelgenre;
        private Label label2;
        private TextBox NewBookGenresTextBox;
        private Label label3;
        private TextBox AmountAvailableBook;
        private Button AddButton;
    }
}