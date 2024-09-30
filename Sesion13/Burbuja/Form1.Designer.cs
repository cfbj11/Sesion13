namespace Burbuja
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 13);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(98, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Ingresa un numero:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(118, 13);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(254, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(118, 40);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(254, 212);
            this.lbNumbers.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 59);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(99, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnSort;
    }
}

