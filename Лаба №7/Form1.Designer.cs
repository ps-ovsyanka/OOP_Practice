namespace Лаба__7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ragged_array = new System.Windows.Forms.Button();
            this.btn_two_array = new System.Windows.Forms.Button();
            this.btn_one_array = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ragged_array
            // 
            this.btn_ragged_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ragged_array.Location = new System.Drawing.Point(301, 19);
            this.btn_ragged_array.Margin = new System.Windows.Forms.Padding(10);
            this.btn_ragged_array.Name = "btn_ragged_array";
            this.btn_ragged_array.Size = new System.Drawing.Size(121, 100);
            this.btn_ragged_array.TabIndex = 5;
            this.btn_ragged_array.Text = "Рваный массив";
            this.btn_ragged_array.UseVisualStyleBackColor = true;
            this.btn_ragged_array.Click += new System.EventHandler(this.onClick);
            // 
            // btn_two_array
            // 
            this.btn_two_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_two_array.Location = new System.Drawing.Point(160, 19);
            this.btn_two_array.Margin = new System.Windows.Forms.Padding(10);
            this.btn_two_array.Name = "btn_two_array";
            this.btn_two_array.Size = new System.Drawing.Size(121, 100);
            this.btn_two_array.TabIndex = 4;
            this.btn_two_array.Text = "Двумерный массив";
            this.btn_two_array.UseVisualStyleBackColor = true;
            this.btn_two_array.Click += new System.EventHandler(this.onClick);
            // 
            // btn_one_array
            // 
            this.btn_one_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_one_array.Location = new System.Drawing.Point(19, 19);
            this.btn_one_array.Margin = new System.Windows.Forms.Padding(10);
            this.btn_one_array.Name = "btn_one_array";
            this.btn_one_array.Size = new System.Drawing.Size(121, 100);
            this.btn_one_array.TabIndex = 3;
            this.btn_one_array.Text = "Одномерный массив";
            this.btn_one_array.UseVisualStyleBackColor = true;
            this.btn_one_array.Click += new System.EventHandler(this.onClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 137);
            this.Controls.Add(this.btn_ragged_array);
            this.Controls.Add(this.btn_two_array);
            this.Controls.Add(this.btn_one_array);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ragged_array;
        private System.Windows.Forms.Button btn_two_array;
        private System.Windows.Forms.Button btn_one_array;
    }
}

