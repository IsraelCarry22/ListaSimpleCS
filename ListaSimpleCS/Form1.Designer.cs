namespace ListaSimpleCS
{
    partial class Form1
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
            btmAdd = new Button();
            btmRemove = new Button();
            txtNombre = new TextBox();
            listLista = new ListBox();
            btmCreate = new Button();
            txtNumNodos = new TextBox();
            SuspendLayout();
            // 
            // btmAdd
            // 
            btmAdd.Location = new Point(359, 12);
            btmAdd.Name = "btmAdd";
            btmAdd.Size = new Size(75, 23);
            btmAdd.TabIndex = 2;
            btmAdd.Text = "ADD";
            btmAdd.UseVisualStyleBackColor = true;
            btmAdd.Click += btmAdd_Click;
            // 
            // btmRemove
            // 
            btmRemove.Location = new Point(359, 41);
            btmRemove.Name = "btmRemove";
            btmRemove.Size = new Size(75, 23);
            btmRemove.TabIndex = 3;
            btmRemove.Text = "REMOVE";
            btmRemove.UseVisualStyleBackColor = true;
            btmRemove.Click += btmRemove_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(8, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 23);
            txtNombre.TabIndex = 4;
            // 
            // listLista
            // 
            listLista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listLista.FormattingEnabled = true;
            listLista.ItemHeight = 21;
            listLista.Location = new Point(8, 41);
            listLista.Name = "listLista";
            listLista.Size = new Size(345, 193);
            listLista.TabIndex = 5;
            // 
            // btmCreate
            // 
            btmCreate.Location = new Point(359, 245);
            btmCreate.Name = "btmCreate";
            btmCreate.Size = new Size(75, 23);
            btmCreate.TabIndex = 7;
            btmCreate.Text = "CREATE";
            btmCreate.UseVisualStyleBackColor = true;
            btmCreate.Click += btmCreate_Click;
            // 
            // txtNumNodos
            // 
            txtNumNodos.Location = new Point(253, 246);
            txtNumNodos.Name = "txtNumNodos";
            txtNumNodos.Size = new Size(100, 23);
            txtNumNodos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 281);
            Controls.Add(btmCreate);
            Controls.Add(txtNumNodos);
            Controls.Add(listLista);
            Controls.Add(txtNombre);
            Controls.Add(btmRemove);
            Controls.Add(btmAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btmAdd;
        private Button btmRemove;
        private TextBox txtNombre;
        private ListBox listLista;
        private Button btmCreate;
        private TextBox txtNumNodos;
    }
}