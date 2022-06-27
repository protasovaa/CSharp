
namespace RocketView
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAstronautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRocketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.AddAstronautToolStripMenuItem,
            this.AddMoneyToolStripMenuItem,
            this.AddRocketToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1782, 40);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.StartToolStripMenuItem.Text = "Запуск";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // AddAstronautToolStripMenuItem
            // 
            this.AddAstronautToolStripMenuItem.Enabled = false;
            this.AddAstronautToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddAstronautToolStripMenuItem.Name = "AddAstronautToolStripMenuItem";
            this.AddAstronautToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.AddAstronautToolStripMenuItem.Text = "Добавить космонавта";
            this.AddAstronautToolStripMenuItem.Click += new System.EventHandler(this.AddAstronautToolStripMenuItem_Click);
            // 
            // AddMoneyToolStripMenuItem
            // 
            this.AddMoneyToolStripMenuItem.Enabled = false;
            this.AddMoneyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddMoneyToolStripMenuItem.Name = "AddMoneyToolStripMenuItem";
            this.AddMoneyToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.AddMoneyToolStripMenuItem.Text = "Добавить выплаты";
            this.AddMoneyToolStripMenuItem.Click += new System.EventHandler(this.AddMoneyToolStripMenuItem_Click);
            // 
            // AddRocketToolStripMenuItem
            // 
            this.AddRocketToolStripMenuItem.Enabled = false;
            this.AddRocketToolStripMenuItem.Name = "AddRocketToolStripMenuItem";
            this.AddRocketToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.AddRocketToolStripMenuItem.Text = "Добавить ракету";
            this.AddRocketToolStripMenuItem.Click += new System.EventHandler(this.AddRocketToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.notificationTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1782, 931);
            this.splitContainer1.SplitterDistance = 483;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationTextBox.Location = new System.Drawing.Point(0, 0);
            this.notificationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.ReadOnly = true;
            this.notificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notificationTextBox.Size = new System.Drawing.Size(483, 931);
            this.notificationTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1293, 931);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 971);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Sport Competitions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAstronautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMoneyToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem AddRocketToolStripMenuItem;
    }
}

