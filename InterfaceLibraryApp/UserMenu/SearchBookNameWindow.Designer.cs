namespace InterfaceLibraryApp
{
    partial class SearchBookNameWindow
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
            Label1 = new Label();
            NameBookTextBox = new TextBox();
            SearchNameButton = new Button();
            ShowBooksGrid = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            NameBook = new DataGridViewTextBoxColumn();
            GenresBook = new DataGridViewTextBoxColumn();
            QuantityBook = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ShowBooksGrid).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(19, 15);
            Label1.Name = "Label1";
            Label1.Size = new Size(164, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Ingrese nombre a buscar:";
            // 
            // NameBookTextBox
            // 
            NameBookTextBox.Location = new Point(203, 15);
            NameBookTextBox.Margin = new Padding(3, 2, 3, 2);
            NameBookTextBox.Name = "NameBookTextBox";
            NameBookTextBox.Size = new Size(274, 23);
            NameBookTextBox.TabIndex = 1;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Location = new Point(482, 15);
            SearchNameButton.Margin = new Padding(3, 2, 3, 2);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(64, 20);
            SearchNameButton.TabIndex = 2;
            SearchNameButton.Text = "Buscar";
            SearchNameButton.UseVisualStyleBackColor = true;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // ShowBooksGrid
            // 
            ShowBooksGrid.BackgroundColor = Color.FromArgb(13, 53, 115);
            ShowBooksGrid.BorderStyle = BorderStyle.None;
            ShowBooksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowBooksGrid.Columns.AddRange(new DataGridViewColumn[] { BookId, NameBook, GenresBook, QuantityBook });
            ShowBooksGrid.Location = new Point(10, 89);
            ShowBooksGrid.Margin = new Padding(3, 2, 3, 2);
            ShowBooksGrid.Name = "ShowBooksGrid";
            ShowBooksGrid.RowHeadersWidth = 51;
            ShowBooksGrid.Size = new Size(696, 265);
            ShowBooksGrid.TabIndex = 3;
            // 
            // BookId
            // 
            BookId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookId.HeaderText = "ID";
            BookId.MinimumWidth = 6;
            BookId.Name = "BookId";
            BookId.Resizable = DataGridViewTriState.True;
            BookId.Width = 43;
            // 
            // NameBook
            // 
            NameBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NameBook.HeaderText = "Nombre";
            NameBook.MinimumWidth = 6;
            NameBook.Name = "NameBook";
            NameBook.Width = 76;
            // 
            // GenresBook
            // 
            GenresBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GenresBook.HeaderText = "Generos";
            GenresBook.MinimumWidth = 6;
            GenresBook.Name = "GenresBook";
            GenresBook.Width = 75;
            // 
            // QuantityBook
            // 
            QuantityBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            QuantityBook.HeaderText = "Disponibles";
            QuantityBook.MinimumWidth = 6;
            QuantityBook.Name = "QuantityBook";
            QuantityBook.Width = 93;
            // 
            // SearchBookNameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(719, 370);
            Controls.Add(ShowBooksGrid);
            Controls.Add(SearchNameButton);
            Controls.Add(NameBookTextBox);
            Controls.Add(Label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchBookNameWindow";
            Text = "SearchBookNameWindow";
            ((System.ComponentModel.ISupportInitialize)ShowBooksGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox NameBookTextBox;
        private Button SearchNameButton;
        private DataGridView ShowBooksGrid;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn GenresBook;
        private DataGridViewTextBoxColumn QuantityBook;
    }
}