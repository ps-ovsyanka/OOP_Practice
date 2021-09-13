namespace Logic_Calculator
{
    partial class FormResult
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
            this.screen_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // screen_result
            // 
            this.screen_result.BackColor = System.Drawing.Color.OrangeRed;
            this.screen_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen_result.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screen_result.ForeColor = System.Drawing.Color.Black;
            this.screen_result.Location = new System.Drawing.Point(12, 12);
            this.screen_result.Name = "screen_result";
            this.screen_result.Size = new System.Drawing.Size(408, 179);
            this.screen_result.TabIndex = 1;
            this.screen_result.Text = "A  B   A∨A∨(B⇒A)  F\n0  0    0 1  1    1\n0  1    0 0  0    0\n1  0    1 1  1    1\n1" +
    "  1    1 1  1    1\n";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(438, 203);
            this.Controls.Add(this.screen_result);
            this.Name = "FormResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox screen_result;
    }
}