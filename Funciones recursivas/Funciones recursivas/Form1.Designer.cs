
namespace Funciones_recursivas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FactorizarTextBox = new System.Windows.Forms.TextBox();
            this.FactorizarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(263, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 284);
            this.listBox1.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(87, 64);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(131, 50);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ejecutar For";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FactorizarTextBox
            // 
            this.FactorizarTextBox.Location = new System.Drawing.Point(511, 76);
            this.FactorizarTextBox.Name = "FactorizarTextBox";
            this.FactorizarTextBox.Size = new System.Drawing.Size(136, 26);
            this.FactorizarTextBox.TabIndex = 3;
            // 
            // FactorizarButton
            // 
            this.FactorizarButton.Location = new System.Drawing.Point(679, 73);
            this.FactorizarButton.Name = "FactorizarButton";
            this.FactorizarButton.Size = new System.Drawing.Size(123, 36);
            this.FactorizarButton.TabIndex = 4;
            this.FactorizarButton.Text = "Factorizar";
            this.FactorizarButton.UseVisualStyleBackColor = true;
            this.FactorizarButton.Click += new System.EventHandler(this.FactorizarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 535);
            this.Controls.Add(this.FactorizarButton);
            this.Controls.Add(this.FactorizarTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FactorizarTextBox;
        private System.Windows.Forms.Button FactorizarButton;
    }
}

