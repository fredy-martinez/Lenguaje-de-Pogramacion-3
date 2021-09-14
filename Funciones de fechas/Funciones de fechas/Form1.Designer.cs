
namespace Funciones_de_fechas
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MesLetrastextBox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NuevoDiaTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.AgergarDiasTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(413, 40);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(133, 29);
            this.EjecutarButton.TabIndex = 2;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de dia";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(169, 125);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.ReadOnly = true;
            this.DiaTextBox.Size = new System.Drawing.Size(161, 26);
            this.DiaTextBox.TabIndex = 4;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(169, 218);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.ReadOnly = true;
            this.MesTextBox.Size = new System.Drawing.Size(161, 26);
            this.MesTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de mes";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(169, 297);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.ReadOnly = true;
            this.YearTextBox.Size = new System.Drawing.Size(161, 26);
            this.YearTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(169, 380);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.ReadOnly = true;
            this.HoraTextBox.Size = new System.Drawing.Size(161, 26);
            this.HoraTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora";
            // 
            // MesLetrastextBox
            // 
            this.MesLetrastextBox.Location = new System.Drawing.Point(605, 125);
            this.MesLetrastextBox.Name = "MesLetrastextBox";
            this.MesLetrastextBox.ReadOnly = true;
            this.MesLetrastextBox.Size = new System.Drawing.Size(161, 26);
            this.MesLetrastextBox.TabIndex = 12;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(470, 125);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(104, 20);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Mes en letras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Agregar dias";
            // 
            // NuevoDiaTextBox
            // 
            this.NuevoDiaTextBox.Location = new System.Drawing.Point(218, 452);
            this.NuevoDiaTextBox.Name = "NuevoDiaTextBox";
            this.NuevoDiaTextBox.ReadOnly = true;
            this.NuevoDiaTextBox.Size = new System.Drawing.Size(112, 26);
            this.NuevoDiaTextBox.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(927, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // AgergarDiasTextBox
            // 
            this.AgergarDiasTextBox.Location = new System.Drawing.Point(169, 452);
            this.AgergarDiasTextBox.Name = "AgergarDiasTextBox";
            this.AgergarDiasTextBox.Size = new System.Drawing.Size(43, 26);
            this.AgergarDiasTextBox.TabIndex = 14;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(166, 501);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.ReadOnly = true;
            this.EdadTextBox.Size = new System.Drawing.Size(161, 26);
            this.EdadTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 550);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NuevoDiaTextBox);
            this.Controls.Add(this.AgergarDiasTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MesLetrastextBox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MesLetrastextBox;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NuevoDiaTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AgergarDiasTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label label9;
    }
}

