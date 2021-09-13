namespace Logic_Calculator
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
            this.btn_res = new System.Windows.Forms.Button();
            this.main_screen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_shtrih = new System.Windows.Forms.Button();
            this.btn_pirs = new System.Windows.Forms.Button();
            this.btn_xor = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_implicat = new System.Windows.Forms.Button();
            this.btn_not = new System.Windows.Forms.Button();
            this.btn_or = new System.Windows.Forms.Button();
            this.btn_and = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_bracket_close = new System.Windows.Forms.Button();
            this.btn_bracket_open = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_res
            // 
            this.btn_res.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_res.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_res.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_res.FlatAppearance.BorderSize = 0;
            this.btn_res.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_res.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_res.Location = new System.Drawing.Point(0, 70);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(365, 54);
            this.btn_res.TabIndex = 2;
            this.btn_res.Text = "RESULT";
            this.btn_res.UseCompatibleTextRendering = true;
            this.btn_res.UseMnemonic = false;
            this.btn_res.UseVisualStyleBackColor = false;
            this.btn_res.UseWaitCursor = true;
            this.btn_res.Click += new System.EventHandler(this.onClick);
            // 
            // main_screen
            // 
            this.main_screen.BackColor = System.Drawing.Color.OrangeRed;
            this.main_screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_screen.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_screen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.main_screen.Location = new System.Drawing.Point(0, 0);
            this.main_screen.Name = "main_screen";
            this.main_screen.Size = new System.Drawing.Size(365, 42);
            this.main_screen.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn_shtrih, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_pirs, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_xor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_equal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_implicat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_not, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_or, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_and, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_clear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_bracket_close, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_bracket_open, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_B, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_A, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 343);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_shtrih
            // 
            this.btn_shtrih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shtrih.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_shtrih.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_shtrih.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_shtrih.FlatAppearance.BorderSize = 0;
            this.btn_shtrih.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_shtrih.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_shtrih.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_shtrih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shtrih.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shtrih.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_shtrih.Location = new System.Drawing.Point(3, 275);
            this.btn_shtrih.Name = "btn_shtrih";
            this.btn_shtrih.Size = new System.Drawing.Size(115, 65);
            this.btn_shtrih.TabIndex = 13;
            this.btn_shtrih.Text = "|";
            this.btn_shtrih.UseCompatibleTextRendering = true;
            this.btn_shtrih.UseMnemonic = false;
            this.btn_shtrih.UseVisualStyleBackColor = false;
            this.btn_shtrih.UseWaitCursor = true;
            this.btn_shtrih.Click += new System.EventHandler(this.onClick);
            // 
            // btn_pirs
            // 
            this.btn_pirs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pirs.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_pirs.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_pirs.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_pirs.FlatAppearance.BorderSize = 0;
            this.btn_pirs.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_pirs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_pirs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_pirs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pirs.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pirs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pirs.Location = new System.Drawing.Point(124, 275);
            this.btn_pirs.Name = "btn_pirs";
            this.btn_pirs.Size = new System.Drawing.Size(115, 65);
            this.btn_pirs.TabIndex = 12;
            this.btn_pirs.Text = "↓";
            this.btn_pirs.UseCompatibleTextRendering = true;
            this.btn_pirs.UseMnemonic = false;
            this.btn_pirs.UseVisualStyleBackColor = false;
            this.btn_pirs.UseWaitCursor = true;
            this.btn_pirs.Click += new System.EventHandler(this.onClick);
            // 
            // btn_xor
            // 
            this.btn_xor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xor.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_xor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_xor.FlatAppearance.BorderSize = 0;
            this.btn_xor.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_xor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_xor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_xor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xor.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_xor.Location = new System.Drawing.Point(245, 207);
            this.btn_xor.Name = "btn_xor";
            this.btn_xor.Size = new System.Drawing.Size(117, 62);
            this.btn_xor.TabIndex = 11;
            this.btn_xor.Text = "+";
            this.btn_xor.UseCompatibleTextRendering = true;
            this.btn_xor.UseMnemonic = false;
            this.btn_xor.UseVisualStyleBackColor = false;
            this.btn_xor.UseWaitCursor = true;
            this.btn_xor.Click += new System.EventHandler(this.onClick);
            // 
            // btn_equal
            // 
            this.btn_equal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_equal.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_equal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_equal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_equal.Location = new System.Drawing.Point(124, 207);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(115, 62);
            this.btn_equal.TabIndex = 10;
            this.btn_equal.Text = "⇔";
            this.btn_equal.UseCompatibleTextRendering = true;
            this.btn_equal.UseMnemonic = false;
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.UseWaitCursor = true;
            this.btn_equal.Click += new System.EventHandler(this.onClick);
            // 
            // btn_implicat
            // 
            this.btn_implicat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_implicat.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_implicat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_implicat.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_implicat.FlatAppearance.BorderSize = 0;
            this.btn_implicat.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_implicat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_implicat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_implicat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_implicat.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_implicat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_implicat.Location = new System.Drawing.Point(3, 207);
            this.btn_implicat.Name = "btn_implicat";
            this.btn_implicat.Size = new System.Drawing.Size(115, 62);
            this.btn_implicat.TabIndex = 9;
            this.btn_implicat.Text = "⇒";
            this.btn_implicat.UseCompatibleTextRendering = true;
            this.btn_implicat.UseMnemonic = false;
            this.btn_implicat.UseVisualStyleBackColor = false;
            this.btn_implicat.UseWaitCursor = true;
            this.btn_implicat.Click += new System.EventHandler(this.onClick);
            // 
            // btn_not
            // 
            this.btn_not.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_not.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_not.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_not.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_not.FlatAppearance.BorderSize = 0;
            this.btn_not.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_not.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_not.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_not.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_not.Location = new System.Drawing.Point(245, 139);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(117, 62);
            this.btn_not.TabIndex = 8;
            this.btn_not.Text = "¬";
            this.btn_not.UseCompatibleTextRendering = true;
            this.btn_not.UseMnemonic = false;
            this.btn_not.UseVisualStyleBackColor = false;
            this.btn_not.UseWaitCursor = true;
            this.btn_not.Click += new System.EventHandler(this.onClick);
            // 
            // btn_or
            // 
            this.btn_or.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_or.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_or.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_or.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_or.FlatAppearance.BorderSize = 0;
            this.btn_or.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_or.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_or.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_or.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_or.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_or.Location = new System.Drawing.Point(124, 139);
            this.btn_or.Name = "btn_or";
            this.btn_or.Size = new System.Drawing.Size(115, 62);
            this.btn_or.TabIndex = 7;
            this.btn_or.Text = "∨";
            this.btn_or.UseCompatibleTextRendering = true;
            this.btn_or.UseMnemonic = false;
            this.btn_or.UseVisualStyleBackColor = false;
            this.btn_or.UseWaitCursor = true;
            this.btn_or.Click += new System.EventHandler(this.onClick);
            // 
            // btn_and
            // 
            this.btn_and.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_and.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_and.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_and.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_and.FlatAppearance.BorderSize = 0;
            this.btn_and.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_and.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_and.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_and.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_and.Font = new System.Drawing.Font("ROG Fonts", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_and.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_and.Location = new System.Drawing.Point(3, 139);
            this.btn_and.Name = "btn_and";
            this.btn_and.Size = new System.Drawing.Size(115, 62);
            this.btn_and.TabIndex = 6;
            this.btn_and.Text = "∧";
            this.btn_and.UseCompatibleTextRendering = true;
            this.btn_and.UseMnemonic = false;
            this.btn_and.UseVisualStyleBackColor = false;
            this.btn_and.UseWaitCursor = true;
            this.btn_and.Click += new System.EventHandler(this.onClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(245, 71);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(117, 62);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "CE";
            this.btn_clear.UseCompatibleTextRendering = true;
            this.btn_clear.UseMnemonic = false;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.UseWaitCursor = true;
            this.btn_clear.Click += new System.EventHandler(this.onClick);
            // 
            // btn_bracket_close
            // 
            this.btn_bracket_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bracket_close.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_bracket_close.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_bracket_close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_bracket_close.FlatAppearance.BorderSize = 0;
            this.btn_bracket_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_bracket_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_bracket_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_bracket_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bracket_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_bracket_close.Location = new System.Drawing.Point(124, 71);
            this.btn_bracket_close.Name = "btn_bracket_close";
            this.btn_bracket_close.Size = new System.Drawing.Size(115, 62);
            this.btn_bracket_close.TabIndex = 4;
            this.btn_bracket_close.Text = ")";
            this.btn_bracket_close.UseCompatibleTextRendering = true;
            this.btn_bracket_close.UseMnemonic = false;
            this.btn_bracket_close.UseVisualStyleBackColor = false;
            this.btn_bracket_close.UseWaitCursor = true;
            this.btn_bracket_close.Click += new System.EventHandler(this.onClick);
            // 
            // btn_bracket_open
            // 
            this.btn_bracket_open.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bracket_open.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_bracket_open.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_bracket_open.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_bracket_open.FlatAppearance.BorderSize = 0;
            this.btn_bracket_open.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_bracket_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_bracket_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_bracket_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bracket_open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_bracket_open.Location = new System.Drawing.Point(3, 71);
            this.btn_bracket_open.Name = "btn_bracket_open";
            this.btn_bracket_open.Size = new System.Drawing.Size(115, 62);
            this.btn_bracket_open.TabIndex = 3;
            this.btn_bracket_open.Text = "(";
            this.btn_bracket_open.UseCompatibleTextRendering = true;
            this.btn_bracket_open.UseMnemonic = false;
            this.btn_bracket_open.UseVisualStyleBackColor = false;
            this.btn_bracket_open.UseWaitCursor = true;
            this.btn_bracket_open.Click += new System.EventHandler(this.onClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(245, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 62);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "<=";
            this.btn_delete.UseCompatibleTextRendering = true;
            this.btn_delete.UseMnemonic = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.UseWaitCursor = true;
            this.btn_delete.Click += new System.EventHandler(this.onClick);
            // 
            // btn_B
            // 
            this.btn_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_B.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_B.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_B.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_B.FlatAppearance.BorderSize = 0;
            this.btn_B.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_B.Location = new System.Drawing.Point(124, 3);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(115, 62);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "B";
            this.btn_B.UseCompatibleTextRendering = true;
            this.btn_B.UseMnemonic = false;
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.UseWaitCursor = true;
            this.btn_B.Click += new System.EventHandler(this.onClick);
            // 
            // btn_A
            // 
            this.btn_A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_A.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_A.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_A.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_A.FlatAppearance.BorderSize = 0;
            this.btn_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btn_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_A.Location = new System.Drawing.Point(3, 3);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(115, 62);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseCompatibleTextRendering = true;
            this.btn_A.UseMnemonic = false;
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.UseWaitCursor = true;
            this.btn_A.Click += new System.EventHandler(this.onClick);
            // 
            // label_msg
            // 
            this.label_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_msg.ForeColor = System.Drawing.Color.Red;
            this.label_msg.Location = new System.Drawing.Point(3, 45);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(359, 23);
            this.label_msg.TabIndex = 3;
            this.label_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(365, 482);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.main_screen);
            this.Controls.Add(this.btn_res);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox main_screen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_implicat;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.Button btn_or;
        private System.Windows.Forms.Button btn_and;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_bracket_close;
        private System.Windows.Forms.Button btn_bracket_open;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_shtrih;
        private System.Windows.Forms.Button btn_pirs;
        private System.Windows.Forms.Button btn_xor;
    }
}

