namespace RocketView
{
    partial class SelectMoneyType
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectMoneyComboBox = new System.Windows.Forms.ComboBox();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете тип выплат";
            // 
            // selectMoneyComboBox
            // 
            this.selectMoneyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMoneyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectMoneyComboBox.FormattingEnabled = true;
            this.selectMoneyComboBox.Items.AddRange(new object[] {
            "Alive",
            "Injury",
            "Death"});
            this.selectMoneyComboBox.Location = new System.Drawing.Point(24, 51);
            this.selectMoneyComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectMoneyComboBox.Name = "selectMoneyComboBox";
            this.selectMoneyComboBox.Size = new System.Drawing.Size(265, 37);
            this.selectMoneyComboBox.TabIndex = 1;
            this.selectMoneyComboBox.SelectedIndexChanged += new System.EventHandler(this.selectMoneyComboBox_SelectedIndexChanged);
            // 
            // agreeButton
            // 
            this.agreeButton.Enabled = false;
            this.agreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeButton.Location = new System.Drawing.Point(24, 103);
            this.agreeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(182, 51);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Выбрать";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // SelectMoneyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 175);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.selectMoneyComboBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectMoneyType";
            this.Text = "Выберете тип выплат";
            this.Load += new System.EventHandler(this.SelectDoctorType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectMoneyComboBox;
        private System.Windows.Forms.Button agreeButton;
    }
}