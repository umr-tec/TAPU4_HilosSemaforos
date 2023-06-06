
namespace TAPU4_MultiProceso
{
    partial class Semaforos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCounter1 = new System.Windows.Forms.ProgressBar();
            this.pbCounter2 = new System.Windows.Forms.ProgressBar();
            this.pbCounter3 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbCounter1
            // 
            this.pbCounter1.Location = new System.Drawing.Point(12, 12);
            this.pbCounter1.Name = "pbCounter1";
            this.pbCounter1.Size = new System.Drawing.Size(421, 67);
            this.pbCounter1.TabIndex = 2;
            // 
            // pbCounter2
            // 
            this.pbCounter2.Location = new System.Drawing.Point(12, 85);
            this.pbCounter2.Name = "pbCounter2";
            this.pbCounter2.Size = new System.Drawing.Size(421, 67);
            this.pbCounter2.TabIndex = 3;
            // 
            // pbCounter3
            // 
            this.pbCounter3.Location = new System.Drawing.Point(12, 158);
            this.pbCounter3.Name = "pbCounter3";
            this.pbCounter3.Size = new System.Drawing.Size(421, 67);
            this.pbCounter3.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(170, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 53);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Semaforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 298);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbCounter3);
            this.Controls.Add(this.pbCounter2);
            this.Controls.Add(this.pbCounter1);
            this.Name = "Semaforos";
            this.Text = "Semaforos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbCounter1;
        private System.Windows.Forms.ProgressBar pbCounter2;
        private System.Windows.Forms.ProgressBar pbCounter3;
        private System.Windows.Forms.Button btnStart;
    }
}