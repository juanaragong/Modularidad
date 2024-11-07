namespace Modularidad
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
            txtNombre = new TextBox();
            txtDiasTrabajados = new TextBox();
            txtSueldoDiario = new TextBox();
            button1 = new Button();
            lsvDatos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtDiasTrabajados
            // 
            txtDiasTrabajados.Location = new Point(181, 142);
            txtDiasTrabajados.Name = "txtDiasTrabajados";
            txtDiasTrabajados.Size = new Size(150, 31);
            txtDiasTrabajados.TabIndex = 1;
            // 
            // txtSueldoDiario
            // 
            txtSueldoDiario.Location = new Point(181, 105);
            txtSueldoDiario.Name = "txtSueldoDiario";
            txtSueldoDiario.Size = new Size(150, 31);
            txtSueldoDiario.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(483, 78);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lsvDatos
            // 
            lsvDatos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvDatos.GridLines = true;
            lsvDatos.Location = new Point(172, 209);
            lsvDatos.Name = "lsvDatos";
            lsvDatos.Size = new Size(423, 146);
            lsvDatos.TabIndex = 4;
            lsvDatos.UseCompatibleStateImageBehavior = false;
            lsvDatos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dias Trabajados";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sueldo Diario";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sueldo Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsvDatos);
            Controls.Add(button1);
            Controls.Add(txtSueldoDiario);
            Controls.Add(txtDiasTrabajados);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDiasTrabajados;
        private TextBox txtSueldoDiario;
        private Button button1;
        private ListView lsvDatos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
