
namespace CST150W5A11
{
    partial class Die
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dieLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.dieLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dieLbl.Font = new System.Drawing.Font("Segoe UI", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dieLbl.Location = new System.Drawing.Point(0, 0);
            this.dieLbl.Name = "label1";
            this.dieLbl.Size = new System.Drawing.Size(150, 150);
            this.dieLbl.TabIndex = 0;
            this.dieLbl.Text = "20";
            this.dieLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Die
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.dieLbl);
            this.Name = "Die";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dieLbl;
    }
}
