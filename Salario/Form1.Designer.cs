namespace Salario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btncalulcar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo salario empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de horas trabajadas:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(29, 162);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(249, 20);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "Ingrese el valor de hora trabajada:";
            // 
            // txthoras
            // 
            this.txthoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoras.Location = new System.Drawing.Point(351, 103);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 22);
            this.txthoras.TabIndex = 3;
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(351, 162);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 4;
            // 
            // btncalulcar
            // 
            this.btncalulcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalulcar.Location = new System.Drawing.Point(559, 114);
            this.btncalulcar.Name = "btncalulcar";
            this.btncalulcar.Size = new System.Drawing.Size(101, 56);
            this.btncalulcar.TabIndex = 5;
            this.btncalulcar.Text = "Calcular";
            this.btncalulcar.UseVisualStyleBackColor = true;
            this.btncalulcar.Click += new System.EventHandler(this.btncalulcar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(339, 305);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(59, 20);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "TOTAL";
            this.lbltotal.Visible = false;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Su salario final es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncalulcar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btncalulcar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label3;
    }
}

