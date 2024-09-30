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
            this.lbNumbers = new System.Windows.Forms.Label();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ltbnumbers = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.AutoSize = true;
            this.lbNumbers.Location = new System.Drawing.Point(25, 49);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(107, 16);
            this.lbNumbers.TabIndex = 0;
            this.lbNumbers.Text = "Ingresar numero:";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(170, 43);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(166, 22);
            this.tbNumbers.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 75);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ltbnumbers
            // 
            this.ltbnumbers.FormattingEnabled = true;
            this.ltbnumbers.ItemHeight = 16;
            this.ltbnumbers.Location = new System.Drawing.Point(152, 191);
            this.ltbnumbers.Name = "ltbnumbers";
            this.ltbnumbers.Size = new System.Drawing.Size(222, 116);
            this.ltbnumbers.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(491, 177);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(111, 67);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.ltbnumbers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.lbNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumbers;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox ltbnumbers;
        private System.Windows.Forms.Button btnSort;
    }
}

