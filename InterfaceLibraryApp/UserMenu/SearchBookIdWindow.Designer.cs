namespace InterfaceLibraryApp
{
    partial class SearchBookIdWindow
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
            IdBookTextBox = new TextBox();
            label2 = new Label();
            NameLabelBook = new Label();
            GenreLabelBook = new Label();
            QuantityBookLabel = new Label();
            SearchButtonID = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(203, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Id del libro a buscar : ";
            // 
            // IdBookTextBox
            // 
            IdBookTextBox.Location = new Point(238, 16);
            IdBookTextBox.Margin = new Padding(3, 2, 3, 2);
            IdBookTextBox.Name = "IdBookTextBox";
            IdBookTextBox.Size = new Size(153, 23);
            IdBookTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 2;
            label2.Text = "Libro Encontrado:";
            // 
            // NameLabelBook
            // 
            NameLabelBook.AutoSize = true;
            NameLabelBook.Font = new Font("Segoe UI", 10F);
            NameLabelBook.ForeColor = Color.White;
            NameLabelBook.Location = new Point(123, 60);
            NameLabelBook.Name = "NameLabelBook";
            NameLabelBook.Size = new Size(45, 19);
            NameLabelBook.TabIndex = 3;
            NameLabelBook.Text = "Name";
            // 
            // GenreLabelBook
            // 
            GenreLabelBook.AutoSize = true;
            GenreLabelBook.Font = new Font("Segoe UI", 10F);
            GenreLabelBook.ForeColor = Color.White;
            GenreLabelBook.Location = new Point(10, 86);
            GenreLabelBook.Name = "GenreLabelBook";
            GenreLabelBook.Size = new Size(67, 19);
            GenreLabelBook.TabIndex = 4;
            GenreLabelBook.Text = "Generos: ";
            // 
            // QuantityBookLabel
            // 
            QuantityBookLabel.AutoSize = true;
            QuantityBookLabel.Font = new Font("Segoe UI", 9F);
            QuantityBookLabel.ForeColor = Color.White;
            QuantityBookLabel.Location = new Point(291, 119);
            QuantityBookLabel.Name = "QuantityBookLabel";
            QuantityBookLabel.Size = new Size(71, 15);
            QuantityBookLabel.TabIndex = 5;
            QuantityBookLabel.Text = "Disponibles:";
            // 
            // SearchButtonID
            // 
            SearchButtonID.Location = new Point(396, 16);
            SearchButtonID.Margin = new Padding(3, 2, 3, 2);
            SearchButtonID.Name = "SearchButtonID";
            SearchButtonID.Size = new Size(52, 20);
            SearchButtonID.TabIndex = 6;
            SearchButtonID.Text = "Buscar";
            SearchButtonID.UseVisualStyleBackColor = true;
            SearchButtonID.Click += SearchButtonID_Click;
            // 
            // SearchBookIdWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(458, 149);
            Controls.Add(SearchButtonID);
            Controls.Add(QuantityBookLabel);
            Controls.Add(GenreLabelBook);
            Controls.Add(NameLabelBook);
            Controls.Add(label2);
            Controls.Add(IdBookTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchBookIdWindow";
            Text = "SearchBookIdWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdBookTextBox;
        private Label label2;
        private Label NameLabelBook;
        private Label GenreLabelBook;
        private Label QuantityBookLabel;
        private Button SearchButtonID;
    }
}