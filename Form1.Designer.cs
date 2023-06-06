
namespace TAPU4_MultiProceso
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pbCounter1 = new System.Windows.Forms.ProgressBar();
            this.pbCounter2 = new System.Windows.Forms.ProgressBar();
            this.pbCounter3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(184, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 53);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbCounter1
            // 
            this.pbCounter1.Location = new System.Drawing.Point(12, 12);
            this.pbCounter1.Name = "pbCounter1";
            this.pbCounter1.Size = new System.Drawing.Size(421, 67);
            this.pbCounter1.TabIndex = 1;
            // 
            // pbCounter2
            // 
            this.pbCounter2.Location = new System.Drawing.Point(12, 85);
            this.pbCounter2.Name = "pbCounter2";
            this.pbCounter2.Size = new System.Drawing.Size(421, 67);
            this.pbCounter2.TabIndex = 2;
            // 
            // pbCounter3
            // 
            this.pbCounter3.Location = new System.Drawing.Point(12, 158);
            this.pbCounter3.Name = "pbCounter3";
            this.pbCounter3.Size = new System.Drawing.Size(421, 67);
            this.pbCounter3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 358);
            this.Controls.Add(this.pbCounter3);
            this.Controls.Add(this.pbCounter2);
            this.Controls.Add(this.pbCounter1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Hilos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pbCounter1;
        private System.Windows.Forms.ProgressBar pbCounter2;
        private System.Windows.Forms.ProgressBar pbCounter3;
    }
}

