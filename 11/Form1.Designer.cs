namespace _11
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.příjmeníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPřijmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.příjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPříjmeníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPříjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(229, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoToolStripMenuItem,
            this.příjmeníToolStripMenuItem,
            this.jménoPříjmeníToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exportToolStripMenuItem.Text = "Soubor";
            // 
            // jménoToolStripMenuItem
            // 
            this.jménoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoToolStripMenuItem1,
            this.příjmeníToolStripMenuItem1,
            this.jménoPřijmeníToolStripMenuItem});
            this.jménoToolStripMenuItem.Name = "jménoToolStripMenuItem";
            this.jménoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jménoToolStripMenuItem.Text = "Export";
            // 
            // jménoToolStripMenuItem1
            // 
            this.jménoToolStripMenuItem1.Name = "jménoToolStripMenuItem1";
            this.jménoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jménoToolStripMenuItem1.Text = "Jméno";
            this.jménoToolStripMenuItem1.Click += new System.EventHandler(this.jménoToolStripMenuItem1_Click);
            // 
            // příjmeníToolStripMenuItem1
            // 
            this.příjmeníToolStripMenuItem1.Name = "příjmeníToolStripMenuItem1";
            this.příjmeníToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.příjmeníToolStripMenuItem1.Text = "Příjmení";
            this.příjmeníToolStripMenuItem1.Click += new System.EventHandler(this.příjmeníToolStripMenuItem1_Click);
            // 
            // jménoPřijmeníToolStripMenuItem
            // 
            this.jménoPřijmeníToolStripMenuItem.Name = "jménoPřijmeníToolStripMenuItem";
            this.jménoPřijmeníToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jménoPřijmeníToolStripMenuItem.Text = "Jméno + přijmení";
            this.jménoPřijmeníToolStripMenuItem.Click += new System.EventHandler(this.jménoPřijmeníToolStripMenuItem_Click);
            // 
            // příjmeníToolStripMenuItem
            // 
            this.příjmeníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoPříjmeníToolStripMenuItem1});
            this.příjmeníToolStripMenuItem.Name = "příjmeníToolStripMenuItem";
            this.příjmeníToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.příjmeníToolStripMenuItem.Text = "Import";
            // 
            // jménoPříjmeníToolStripMenuItem1
            // 
            this.jménoPříjmeníToolStripMenuItem1.Name = "jménoPříjmeníToolStripMenuItem1";
            this.jménoPříjmeníToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jménoPříjmeníToolStripMenuItem1.Text = "Jméno + příjmení";
            this.jménoPříjmeníToolStripMenuItem1.Click += new System.EventHandler(this.jménoPříjmeníToolStripMenuItem1_Click);
            // 
            // jménoPříjmeníToolStripMenuItem
            // 
            this.jménoPříjmeníToolStripMenuItem.Name = "jménoPříjmeníToolStripMenuItem";
            this.jménoPříjmeníToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jménoPříjmeníToolStripMenuItem.Text = "Konec";
            this.jménoPříjmeníToolStripMenuItem.Click += new System.EventHandler(this.jménoPříjmeníToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 225);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(116, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(101, 225);
            this.listBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vlož jméno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vlož příjmení";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "JMÉNA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(113, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PŘÍJMENÍ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(229, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Osoby";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem příjmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPříjmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem příjmeníToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jménoPřijmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPříjmeníToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

