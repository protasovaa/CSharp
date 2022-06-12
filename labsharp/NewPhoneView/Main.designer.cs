
namespace lab4csharp
{
    partial class Main
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
            this.CreateObjButton = new System.Windows.Forms.Button();
            this.RunMethodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ObjComboBox = new System.Windows.Forms.ComboBox();
            this.MethodsComboBox = new System.Windows.Forms.ComboBox();
            this.InputFieldsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldsListBox = new System.Windows.Forms.ListBox();
            this.paramsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateObjButton
            // 
            this.CreateObjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateObjButton.Location = new System.Drawing.Point(17, 135);
            this.CreateObjButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateObjButton.Name = "CreateObjButton";
            this.CreateObjButton.Size = new System.Drawing.Size(205, 32);
            this.CreateObjButton.TabIndex = 1;
            this.CreateObjButton.Text = "создать объект";
            this.CreateObjButton.UseVisualStyleBackColor = true;
            this.CreateObjButton.Click += new System.EventHandler(this.CreateObjButton_Click);
            // 
            // RunMethodButton
            // 
            this.RunMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunMethodButton.Location = new System.Drawing.Point(17, 235);
            this.RunMethodButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunMethodButton.Name = "RunMethodButton";
            this.RunMethodButton.Size = new System.Drawing.Size(205, 32);
            this.RunMethodButton.TabIndex = 2;
            this.RunMethodButton.Text = "выполнить метод";
            this.RunMethodButton.UseVisualStyleBackColor = true;
            this.RunMethodButton.Click += new System.EventHandler(this.RunMethodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Метод";
            // 
            // ObjComboBox
            // 
            this.ObjComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjComboBox.FormattingEnabled = true;
            this.ObjComboBox.Location = new System.Drawing.Point(17, 46);
            this.ObjComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObjComboBox.Name = "ObjComboBox";
            this.ObjComboBox.Size = new System.Drawing.Size(204, 28);
            this.ObjComboBox.TabIndex = 5;
            this.ObjComboBox.SelectedIndexChanged += new System.EventHandler(this.ObjComboBox_SelectedIndexChanged);
            // 
            // MethodsComboBox
            // 
            this.MethodsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(17, 99);
            this.MethodsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(204, 28);
            this.MethodsComboBox.TabIndex = 6;
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged);
            // 
            // InputFieldsButton
            // 
            this.InputFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFieldsButton.Location = new System.Drawing.Point(17, 186);
            this.InputFieldsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputFieldsButton.Name = "InputFieldsButton";
            this.InputFieldsButton.Size = new System.Drawing.Size(205, 32);
            this.InputFieldsButton.TabIndex = 7;
            this.InputFieldsButton.Text = "ввести параметры";
            this.InputFieldsButton.UseVisualStyleBackColor = true;
            this.InputFieldsButton.Click += new System.EventHandler(this.InputFieldsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(266, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поля обьекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(265, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Параметры метода";
            // 
            // fieldsListBox
            // 
            this.fieldsListBox.Enabled = false;
            this.fieldsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldsListBox.FormattingEnabled = true;
            this.fieldsListBox.ItemHeight = 20;
            this.fieldsListBox.Location = new System.Drawing.Point(269, 47);
            this.fieldsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fieldsListBox.Name = "fieldsListBox";
            this.fieldsListBox.Size = new System.Drawing.Size(296, 204);
            this.fieldsListBox.TabIndex = 11;
            // 
            // paramsListBox
            // 
            this.paramsListBox.Enabled = false;
            this.paramsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramsListBox.FormattingEnabled = true;
            this.paramsListBox.ItemHeight = 20;
            this.paramsListBox.Location = new System.Drawing.Point(269, 287);
            this.paramsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramsListBox.Name = "paramsListBox";
            this.paramsListBox.Size = new System.Drawing.Size(296, 84);
            this.paramsListBox.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 397);
            this.Controls.Add(this.paramsListBox);
            this.Controls.Add(this.fieldsListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputFieldsButton);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.ObjComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunMethodButton);
            this.Controls.Add(this.CreateObjButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateObjButton;
        private System.Windows.Forms.Button RunMethodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ObjComboBox;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.Button InputFieldsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox fieldsListBox;
        private System.Windows.Forms.ListBox paramsListBox;
    }
}

