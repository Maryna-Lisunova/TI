namespace TI_lab2
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            menu_file = new ToolStripMenuItem();
            menu_open = new ToolStripMenuItem();
            menu_save = new ToolStripMenuItem();
            menu_exit = new ToolStripMenuItem();
            tb_origin_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_key = new TextBox();
            btn_cipher = new Button();
            tb_ciphertext = new TextBox();
            label3 = new Label();
            btn_clear = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_file });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(845, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { menu_open, menu_save, menu_exit });
            menu_file.Name = "menu_file";
            menu_file.Size = new Size(59, 24);
            menu_file.Text = "Файл";
            // 
            // menu_open
            // 
            menu_open.Name = "menu_open";
            menu_open.Size = new Size(224, 26);
            menu_open.Text = "Открыть";
            menu_open.Click += menu_open_Click;
            // 
            // menu_save
            // 
            menu_save.Name = "menu_save";
            menu_save.Size = new Size(224, 26);
            menu_save.Text = "Сохранить";
            menu_save.Click += menu_save_Click;
            // 
            // menu_exit
            // 
            menu_exit.Name = "menu_exit";
            menu_exit.Size = new Size(224, 26);
            menu_exit.Text = "Выход";
            menu_exit.Click += menu_exit_Click;
            // 
            // tb_origin_text
            // 
            tb_origin_text.Location = new Point(12, 62);
            tb_origin_text.Multiline = true;
            tb_origin_text.Name = "tb_origin_text";
            tb_origin_text.ScrollBars = ScrollBars.Vertical;
            tb_origin_text.Size = new Size(812, 126);
            tb_origin_text.TabIndex = 2;
            tb_origin_text.TextChanged += Edit_fields;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "Исходный текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Ключ:";
            // 
            // tb_key
            // 
            tb_key.Location = new Point(12, 214);
            tb_key.Multiline = true;
            tb_key.Name = "tb_key";
            tb_key.ScrollBars = ScrollBars.Vertical;
            tb_key.Size = new Size(812, 94);
            tb_key.TabIndex = 5;
            tb_key.TextChanged += Edit_fields;
            // 
            // btn_cipher
            // 
            btn_cipher.Enabled = false;
            btn_cipher.Location = new Point(12, 324);
            btn_cipher.Name = "btn_cipher";
            btn_cipher.Size = new Size(638, 46);
            btn_cipher.TabIndex = 6;
            btn_cipher.Text = "Зашифровать";
            btn_cipher.UseVisualStyleBackColor = true;
            btn_cipher.Click += btn_cipher_Click;
            // 
            // tb_ciphertext
            // 
            tb_ciphertext.Location = new Point(12, 396);
            tb_ciphertext.Multiline = true;
            tb_ciphertext.Name = "tb_ciphertext";
            tb_ciphertext.ReadOnly = true;
            tb_ciphertext.ScrollBars = ScrollBars.Vertical;
            tb_ciphertext.Size = new Size(812, 201);
            tb_ciphertext.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 373);
            label3.Name = "label3";
            label3.Size = new Size(302, 20);
            label3.TabIndex = 8;
            label3.Text = "Зашифрованный/расшифрованный текст:";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(669, 324);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(155, 47);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Очистить";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 615);
            Controls.Add(btn_clear);
            Controls.Add(label3);
            Controls.Add(tb_ciphertext);
            Controls.Add(btn_cipher);
            Controls.Add(tb_key);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_origin_text);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Потоковое шифрование";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_file;
        private ToolStripMenuItem menu_open;
        private ToolStripMenuItem menu_save;
        private ToolStripMenuItem menu_exit;
        private TextBox tb_origin_text;
        private Label label1;
        private Label label2;
        private TextBox tb_key;
        private Button btn_cipher;
        private TextBox tb_ciphertext;
        private Label label3;
        private Button btn_clear;
    }
}
