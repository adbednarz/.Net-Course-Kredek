
namespace AdamBednarzLab1
{
    partial class FormNew
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
            this.labelFromMainValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFromMainValue
            // 
            this.labelFromMainValue.AutoSize = true;
            this.labelFromMainValue.Location = new System.Drawing.Point(222, 79);
            this.labelFromMainValue.Name = "labelFromMainValue";
            this.labelFromMainValue.Size = new System.Drawing.Size(77, 15);
            this.labelFromMainValue.TabIndex = 0;
            this.labelFromMainValue.Text = "brak wartości";
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFromMainValue);
            this.Name = "FormNew";
            this.Text = "Now Okno";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFromMainValue;
    }
}