namespace TI3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_p = new TextBox();
            tb_q = new TextBox();
            tb_n = new TextBox();
            tb_b = new TextBox();
            btn_dosmth = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            btn_open = new ToolStripMenuItem();
            btn_save = new ToolStripMenuItem();
            btn_exit = new ToolStripMenuItem();
            tb_plaintext = new TextBox();
            tb_ciphertext = new TextBox();
            label7 = new Label();
            btn_undocipher = new Button();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 76);
            label1.Name = "label1";
            label1.Size = new Size(24, 23);
            label1.TabIndex = 0;
            label1.Text = "p:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(13, 119);
            label2.Name = "label2";
            label2.Size = new Size(24, 23);
            label2.TabIndex = 1;
            label2.Text = "q:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(13, 203);
            label3.Name = "label3";
            label3.Size = new Size(24, 23);
            label3.TabIndex = 2;
            label3.Text = "n:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(13, 246);
            label4.Name = "label4";
            label4.Size = new Size(24, 23);
            label4.TabIndex = 3;
            label4.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(13, 44);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 4;
            label5.Text = "Закрытый ключ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(11, 165);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 5;
            label6.Text = "Открытый ключ";
            // 
            // tb_p
            // 
            tb_p.Font = new Font("Segoe UI", 10F);
            tb_p.Location = new Point(43, 76);
            tb_p.Name = "tb_p";
            tb_p.Size = new Size(125, 30);
            tb_p.TabIndex = 6;
            // 
            // tb_q
            // 
            tb_q.Font = new Font("Segoe UI", 10F);
            tb_q.Location = new Point(43, 119);
            tb_q.Name = "tb_q";
            tb_q.Size = new Size(125, 30);
            tb_q.TabIndex = 7;
            tb_q.TextChanged += tb_q_TextChanged;
            // 
            // tb_n
            // 
            tb_n.Enabled = false;
            tb_n.Font = new Font("Segoe UI", 10F);
            tb_n.Location = new Point(43, 200);
            tb_n.Name = "tb_n";
            tb_n.Size = new Size(125, 30);
            tb_n.TabIndex = 8;
            // 
            // tb_b
            // 
            tb_b.Font = new Font("Segoe UI", 10F);
            tb_b.Location = new Point(43, 246);
            tb_b.Name = "tb_b";
            tb_b.Size = new Size(125, 30);
            tb_b.TabIndex = 9;
            // 
            // btn_dosmth
            // 
            btn_dosmth.BackColor = SystemColors.ActiveCaption;
            btn_dosmth.Font = new Font("Segoe UI", 10F);
            btn_dosmth.Location = new Point(13, 293);
            btn_dosmth.Name = "btn_dosmth";
            btn_dosmth.Size = new Size(155, 48);
            btn_dosmth.TabIndex = 10;
            btn_dosmth.Text = "Зашифровать";
            btn_dosmth.UseVisualStyleBackColor = false;
            btn_dosmth.Click += btn_dosmth_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(554, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btn_open, btn_save, btn_exit });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // btn_open
            // 
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(166, 26);
            btn_open.Text = "Открыть";
            btn_open.Click += btn_open_Click;
            // 
            // btn_save
            // 
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(166, 26);
            btn_save.Text = "Сохранить";
            btn_save.Click += btn_save_Click;
            // 
            // btn_exit
            // 
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(166, 26);
            btn_exit.Text = "Выход";
            btn_exit.Click += btn_exit_Click;
            // 
            // tb_plaintext
            // 
            tb_plaintext.Enabled = false;
            tb_plaintext.Location = new Point(204, 64);
            tb_plaintext.Multiline = true;
            tb_plaintext.Name = "tb_plaintext";
            tb_plaintext.ScrollBars = ScrollBars.Vertical;
            tb_plaintext.Size = new Size(326, 144);
            tb_plaintext.TabIndex = 12;
            // 
            // tb_ciphertext
            // 
            tb_ciphertext.Enabled = false;
            tb_ciphertext.Location = new Point(204, 256);
            tb_ciphertext.Multiline = true;
            tb_ciphertext.Name = "tb_ciphertext";
            tb_ciphertext.ScrollBars = ScrollBars.Vertical;
            tb_ciphertext.Size = new Size(326, 138);
            tb_ciphertext.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(204, 230);
            label7.Name = "label7";
            label7.Size = new Size(188, 23);
            label7.TabIndex = 14;
            label7.Text = "Зашифрованный текст";
            // 
            // btn_undocipher
            // 
            btn_undocipher.BackColor = SystemColors.ActiveCaption;
            btn_undocipher.Font = new Font("Segoe UI", 10F);
            btn_undocipher.Location = new Point(13, 347);
            btn_undocipher.Name = "btn_undocipher";
            btn_undocipher.Size = new Size(155, 47);
            btn_undocipher.TabIndex = 15;
            btn_undocipher.Text = "Расшифровать";
            btn_undocipher.UseVisualStyleBackColor = false;
            btn_undocipher.Click += btn_undocipher_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(204, 38);
            label8.Name = "label8";
            label8.Size = new Size(134, 23);
            label8.TabIndex = 16;
            label8.Text = "Исходный текст";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(554, 414);
            Controls.Add(label8);
            Controls.Add(btn_undocipher);
            Controls.Add(label7);
            Controls.Add(tb_ciphertext);
            Controls.Add(tb_plaintext);
            Controls.Add(btn_dosmth);
            Controls.Add(tb_b);
            Controls.Add(tb_n);
            Controls.Add(tb_q);
            Controls.Add(tb_p);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Алгоритм Рабина";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_p;
        private TextBox tb_q;
        private TextBox tb_n;
        private TextBox tb_b;
        private Button btn_dosmth;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem btn_open;
        private ToolStripMenuItem btn_save;
        private ToolStripMenuItem btn_exit;
        private TextBox tb_plaintext;
        private TextBox tb_ciphertext;
        private Label label7;
        private Button btn_undocipher;
        private Label label8;
    }
}
