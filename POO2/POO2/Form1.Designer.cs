
namespace POO2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CrearCuentaButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarCuentaButton = new System.Windows.Forms.Button();
            this.EnumerarListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.SaldotextBox = new System.Windows.Forms.TextBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Controls.Add(this.IdentidadTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaldotextBox);
            this.groupBox2.Controls.Add(this.NumeroCuentaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(461, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CrearCuentaButton
            // 
            this.CrearCuentaButton.Location = new System.Drawing.Point(897, 185);
            this.CrearCuentaButton.Name = "CrearCuentaButton";
            this.CrearCuentaButton.Size = new System.Drawing.Size(134, 59);
            this.CrearCuentaButton.TabIndex = 2;
            this.CrearCuentaButton.Text = "Crear Cuenta";
            this.CrearCuentaButton.UseVisualStyleBackColor = true;
            this.CrearCuentaButton.Click += new System.EventHandler(this.CrearCuentaButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MontoTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TipoMovimientoComboBox);
            this.groupBox3.Location = new System.Drawing.Point(26, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(837, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // TipoMovimientoComboBox
            // 
            this.TipoMovimientoComboBox.FormattingEnabled = true;
            this.TipoMovimientoComboBox.Items.AddRange(new object[] {
            "Deposito",
            "Retiro"});
            this.TipoMovimientoComboBox.Location = new System.Drawing.Point(582, 32);
            this.TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            this.TipoMovimientoComboBox.Size = new System.Drawing.Size(227, 28);
            this.TipoMovimientoComboBox.TabIndex = 0;
            // 
            // AgregarCuentaButton
            // 
            this.AgregarCuentaButton.Location = new System.Drawing.Point(897, 298);
            this.AgregarCuentaButton.Name = "AgregarCuentaButton";
            this.AgregarCuentaButton.Size = new System.Drawing.Size(134, 59);
            this.AgregarCuentaButton.TabIndex = 4;
            this.AgregarCuentaButton.Text = "Agregar Movimiento";
            this.AgregarCuentaButton.UseVisualStyleBackColor = true;
            this.AgregarCuentaButton.Click += new System.EventHandler(this.AgregarCuentaButton_Click);
            // 
            // EnumerarListBox
            // 
            this.EnumerarListBox.FormattingEnabled = true;
            this.EnumerarListBox.ItemHeight = 20;
            this.EnumerarListBox.Location = new System.Drawing.Point(26, 405);
            this.EnumerarListBox.Name = "EnumerarListBox";
            this.EnumerarListBox.Size = new System.Drawing.Size(837, 264);
            this.EnumerarListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto";
            // 
            // NumeroCuentaTextBox
            // 
            this.NumeroCuentaTextBox.Location = new System.Drawing.Point(147, 65);
            this.NumeroCuentaTextBox.Name = "NumeroCuentaTextBox";
            this.NumeroCuentaTextBox.Size = new System.Drawing.Size(227, 26);
            this.NumeroCuentaTextBox.TabIndex = 4;
            // 
            // SaldotextBox
            // 
            this.SaldotextBox.Location = new System.Drawing.Point(147, 130);
            this.SaldotextBox.Name = "SaldotextBox";
            this.SaldotextBox.ReadOnly = true;
            this.SaldotextBox.Size = new System.Drawing.Size(227, 26);
            this.SaldotextBox.TabIndex = 5;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(107, 40);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(227, 26);
            this.MontoTextBox.TabIndex = 6;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(107, 54);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(227, 26);
            this.IdentidadTextBox.TabIndex = 7;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(107, 136);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(227, 26);
            this.NombretextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 697);
            this.Controls.Add(this.EnumerarListBox);
            this.Controls.Add(this.AgregarCuentaButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CrearCuentaButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CrearCuentaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoMovimientoComboBox;
        private System.Windows.Forms.Button AgregarCuentaButton;
        private System.Windows.Forms.ListBox EnumerarListBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaldotextBox;
        private System.Windows.Forms.TextBox NumeroCuentaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

