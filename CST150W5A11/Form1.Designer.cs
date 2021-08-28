
namespace CST150W5A11
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
            this.rollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rollBtn
            // 
            this.rollBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rollBtn.Location = new System.Drawing.Point(37, 108);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(128, 128);
            this.rollBtn.TabIndex = 0;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 339);
            this.Controls.Add(this.rollBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Snake Eyes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollBtn;
    }
}

