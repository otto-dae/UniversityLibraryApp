namespace InterfaceLibraryApp
{
    partial class SearchBookGenreWindows
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
            GenreBookTextBox = new TextBox();
            SearchGenreButton = new Button();
            label2 = new Label();
            GenreBookSearchGrid = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            NameBook = new DataGridViewTextBoxColumn();
            GenresBook = new DataGridViewTextBoxColumn();
            QuantityBook = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GenreBookSearchGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese genero/s a buscar:";
            // 
            // GenreBookTextBox
            // 
            GenreBookTextBox.Location = new Point(188, 16);
            GenreBookTextBox.Name = "GenreBookTextBox";
            GenreBookTextBox.Size = new Size(347, 23);
            GenreBookTextBox.TabIndex = 1;
            // 
            // SearchGenreButton
            // 
            SearchGenreButton.BackColor = Color.FromArgb(95, 145, 222);
            SearchGenreButton.FlatStyle = FlatStyle.Popup;
            SearchGenreButton.ForeColor = Color.Black;
            SearchGenreButton.Location = new Point(541, 16);
            SearchGenreButton.Name = "SearchGenreButton";
            SearchGenreButton.Size = new Size(59, 22);
            SearchGenreButton.TabIndex = 2;
            SearchGenreButton.Text = "Buscar";
            SearchGenreButton.UseVisualStyleBackColor = false;
            SearchGenreButton.Click += SearchGenreButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(185, 41);
            label2.Name = "label2";
            label2.Size = new Size(350, 19);
            label2.TabIndex = 4;
            label2.Text = "En caso de ingresar multiples generos separar por coma";
            // 
            // GenreBookSearchGrid
            // 
            GenreBookSearchGrid.BackgroundColor = Color.FromArgb(13, 53, 115);
            GenreBookSearchGrid.BorderStyle = BorderStyle.None;
            GenreBookSearchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GenreBookSearchGrid.Columns.AddRange(new DataGridViewColumn[] { BookId, NameBook, GenresBook, QuantityBook });
            GenreBookSearchGrid.Location = new Point(12, 74);
            GenreBookSearchGrid.Margin = new Padding(3, 2, 3, 2);
            GenreBookSearchGrid.Name = "GenreBookSearchGrid";
            GenreBookSearchGrid.RowHeadersWidth = 51;
            GenreBookSearchGrid.Size = new Size(696, 234);
            GenreBookSearchGrid.TabIndex = 5;
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
            // SearchBookGenreWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(730, 401);
            Controls.Add(GenreBookSearchGrid);
            Controls.Add(label2);
            Controls.Add(SearchGenreButton);
            Controls.Add(GenreBookTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.Black;
            Name = "SearchBookGenreWindows";
            Text = "SearchBookGenreWindows";
            ((System.ComponentModel.ISupportInitialize)GenreBookSearchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox GenreBookTextBox;
        private Button SearchGenreButton;
        private Label label2;
        private DataGridView GenreBookSearchGrid;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn GenresBook;
        private DataGridViewTextBoxColumn QuantityBook;
    }
}