
namespace Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EjecutrarButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.CheckedListBox();
            this.OrdenarButton = new System.Windows.Forms.Button();
            this.OrdenarListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // EjecutrarButton
            // 
            this.EjecutrarButton.Location = new System.Drawing.Point(56, 44);
            this.EjecutrarButton.Name = "EjecutrarButton";
            this.EjecutrarButton.Size = new System.Drawing.Size(132, 55);
            this.EjecutrarButton.TabIndex = 0;
            this.EjecutrarButton.Text = "Ejecutar";
            this.EjecutrarButton.UseVisualStyleBackColor = true;
            this.EjecutrarButton.Click += new System.EventHandler(this.EjecutrarButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(56, 152);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(132, 188);
            this.ListBox.TabIndex = 1;
            // 
            // OrdenarButton
            // 
            this.OrdenarButton.Location = new System.Drawing.Point(299, 44);
            this.OrdenarButton.Name = "OrdenarButton";
            this.OrdenarButton.Size = new System.Drawing.Size(132, 55);
            this.OrdenarButton.TabIndex = 2;
            this.OrdenarButton.Text = "Ordenar";
            this.OrdenarButton.UseVisualStyleBackColor = true;
            this.OrdenarButton.Click += new System.EventHandler(this.OrdenarButton_Click);
            // 
            // OrdenarListBox
            // 
            this.OrdenarListBox.FormattingEnabled = true;
            this.OrdenarListBox.Location = new System.Drawing.Point(299, 152);
            this.OrdenarListBox.Name = "OrdenarListBox";
            this.OrdenarListBox.Size = new System.Drawing.Size(132, 188);
            this.OrdenarListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 556);
            this.Controls.Add(this.OrdenarListBox);
            this.Controls.Add(this.OrdenarButton);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.EjecutrarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EjecutrarButton;
        private System.Windows.Forms.CheckedListBox ListBox;
        private System.Windows.Forms.Button OrdenarButton;
        private System.Windows.Forms.CheckedListBox OrdenarListBox;
    }
}

