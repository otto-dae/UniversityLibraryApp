namespace InterfaceLibraryApp
{
    partial class ModifyNameBookWindow
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
            CurrentName = new Label();
            NewNamePrompt = new Label();
            SearchID = new Button();
            AcceptChanges = new Button();
            SearchIDTextBox = new TextBox();
            NewNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(213, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Ingrese el ID del libro a modificar:";
            // 
            // CurrentName
            // 
            CurrentName.AutoSize = true;
            CurrentName.Font = new Font("Segoe UI", 10F);
            CurrentName.ForeColor = Color.White;
            CurrentName.Location = new Point(12, 38);
            CurrentName.Name = "CurrentName";
            CurrentName.Size = new Size(102, 19);
            CurrentName.TabIndex = 1;
            CurrentName.Text = "Nombre actual:";
            // 
            // NewNamePrompt
            // 
            NewNamePrompt.AutoSize = true;
            NewNamePrompt.Font = new Font("Segoe UI", 10F);
            NewNamePrompt.ForeColor = Color.White;
            NewNamePrompt.Location = new Point(10, 74);
            NewNamePrompt.Name = "NewNamePrompt";
            NewNamePrompt.Size = new Size(104, 19);
            NewNamePrompt.TabIndex = 2;
            NewNamePrompt.Text = "Nuevo nombre:";
            // 
            // SearchID
            // 
            SearchID.BackColor = Color.FromArgb(95, 145, 222);
            SearchID.FlatStyle = FlatStyle.Popup;
            SearchID.Location = new Point(369, 7);
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(60, 27);
            SearchID.TabIndex = 3;
            SearchID.Text = "Buscar";
            SearchID.UseVisualStyleBackColor = false;
            SearchID.Click += SearchID_Click;
            // 
            // AcceptChanges
            // 
            AcceptChanges.BackColor = Color.FromArgb(95, 145, 222);
            AcceptChanges.FlatStyle = FlatStyle.Popup;
            AcceptChanges.Location = new Point(195, 110);
            AcceptChanges.Name = "AcceptChanges";
            AcceptChanges.Size = new Size(71, 27);
            AcceptChanges.TabIndex = 4;
            AcceptChanges.Text = "Cambiar";
            AcceptChanges.UseVisualStyleBackColor = false;
            AcceptChanges.Click += AcceptChanges_Click;
            // 
            // SearchIDTextBox
            // 
            SearchIDTextBox.Location = new Point(239, 10);
            SearchIDTextBox.Name = "SearchIDTextBox";
            SearchIDTextBox.Size = new Size(124, 23);
            SearchIDTextBox.TabIndex = 5;
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(120, 74);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(338, 23);
            NewNameTextBox.TabIndex = 6;
            // 
            // ModifyNameBookWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(474, 149);
            Controls.Add(NewNameTextBox);
            Controls.Add(SearchIDTextBox);
            Controls.Add(AcceptChanges);
            Controls.Add(SearchID);
            Controls.Add(NewNamePrompt);
            Controls.Add(CurrentName);
            Controls.Add(Label1);
            Name = "ModifyNameBookWindow";
            Text = "ModifyNameBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Label CurrentName;
        private Label NewNamePrompt;
        private Button SearchID;
        private Button AcceptChanges;
        private TextBox SearchIDTextBox;
        private TextBox NewNameTextBox;
    }
}