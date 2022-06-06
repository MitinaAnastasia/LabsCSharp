
namespace лаба2_с_шарп
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
            this.FirmtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagonaltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoundPowtextBox = new System.Windows.Forms.TextBox();
            this.withCountrycheckbtn = new System.Windows.Forms.RadioButton();
            this.withoutCountrycheckbtn = new System.Windows.Forms.RadioButton();
            this.inputButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.SecondClasslistBox = new System.Windows.Forms.ListBox();
            this.FirstClasslistBox = new System.Windows.Forms.ListBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirmtextBox
            // 
            this.FirmtextBox.Location = new System.Drawing.Point(22, 31);
            this.FirmtextBox.Multiline = true;
            this.FirmtextBox.Name = "FirmtextBox";
            this.FirmtextBox.Size = new System.Drawing.Size(435, 31);
            this.FirmtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фирма телевизора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диагональ экрана (дюйм)";
            // 
            // DiagonaltextBox
            // 
            this.DiagonaltextBox.Location = new System.Drawing.Point(22, 86);
            this.DiagonaltextBox.Multiline = true;
            this.DiagonaltextBox.Name = "DiagonaltextBox";
            this.DiagonaltextBox.Size = new System.Drawing.Size(435, 31);
            this.DiagonaltextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Звуковая мощность (дБ)";
            // 
            // SoundPowtextBox
            // 
            this.SoundPowtextBox.Location = new System.Drawing.Point(22, 139);
            this.SoundPowtextBox.Multiline = true;
            this.SoundPowtextBox.Name = "SoundPowtextBox";
            this.SoundPowtextBox.Size = new System.Drawing.Size(435, 31);
            this.SoundPowtextBox.TabIndex = 5;
            // 
            // withCountrycheckbtn
            // 
            this.withCountrycheckbtn.AutoSize = true;
            this.withCountrycheckbtn.Location = new System.Drawing.Point(22, 187);
            this.withCountrycheckbtn.Name = "withCountrycheckbtn";
            this.withCountrycheckbtn.Size = new System.Drawing.Size(209, 21);
            this.withCountrycheckbtn.TabIndex = 6;
            this.withCountrycheckbtn.TabStop = true;
            this.withCountrycheckbtn.Text = "с страной-производителем";
            this.withCountrycheckbtn.UseVisualStyleBackColor = true;
            this.withCountrycheckbtn.CheckedChanged += new System.EventHandler(this.WithCountrycheckbtn_CheckedChanged);
            // 
            // withoutCountrycheckbtn
            // 
            this.withoutCountrycheckbtn.AutoSize = true;
            this.withoutCountrycheckbtn.Location = new System.Drawing.Point(247, 187);
            this.withoutCountrycheckbtn.Name = "withoutCountrycheckbtn";
            this.withoutCountrycheckbtn.Size = new System.Drawing.Size(210, 21);
            this.withoutCountrycheckbtn.TabIndex = 7;
            this.withoutCountrycheckbtn.TabStop = true;
            this.withoutCountrycheckbtn.Text = "без страны-производителя";
            this.withoutCountrycheckbtn.UseVisualStyleBackColor = true;
            this.withoutCountrycheckbtn.CheckedChanged += new System.EventHandler(this.WithoutCountrycheckbtn_CheckedChanged);
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(526, 54);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(120, 84);
            this.inputButton.TabIndex = 8;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Страна-производитель:";
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Enabled = false;
            this.CountrytextBox.Location = new System.Drawing.Point(190, 221);
            this.CountrytextBox.Multiline = true;
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(251, 27);
            this.CountrytextBox.TabIndex = 10;
            // 
            // SecondClasslistBox
            // 
            this.SecondClasslistBox.FormattingEnabled = true;
            this.SecondClasslistBox.HorizontalScrollbar = true;
            this.SecondClasslistBox.ItemHeight = 16;
            this.SecondClasslistBox.Location = new System.Drawing.Point(424, 305);
            this.SecondClasslistBox.Name = "SecondClasslistBox";
            this.SecondClasslistBox.Size = new System.Drawing.Size(374, 276);
            this.SecondClasslistBox.TabIndex = 12;
            // 
            // FirstClasslistBox
            // 
            this.FirstClasslistBox.FormattingEnabled = true;
            this.FirstClasslistBox.HorizontalScrollbar = true;
            this.FirstClasslistBox.ItemHeight = 16;
            this.FirstClasslistBox.Location = new System.Drawing.Point(22, 305);
            this.FirstClasslistBox.Name = "FirstClasslistBox";
            this.FirstClasslistBox.Size = new System.Drawing.Size(374, 276);
            this.FirstClasslistBox.TabIndex = 13;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(364, 265);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(93, 34);
            this.outputButton.TabIndex = 14;
            this.outputButton.Text = "Вывод";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 593);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.FirstClasslistBox);
            this.Controls.Add(this.SecondClasslistBox);
            this.Controls.Add(this.CountrytextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.withoutCountrycheckbtn);
            this.Controls.Add(this.withCountrycheckbtn);
            this.Controls.Add(this.SoundPowtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiagonaltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirmtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirmtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiagonaltextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoundPowtextBox;
        private System.Windows.Forms.RadioButton withCountrycheckbtn;
        private System.Windows.Forms.RadioButton withoutCountrycheckbtn;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.ListBox SecondClasslistBox;
        private System.Windows.Forms.ListBox FirstClasslistBox;
        private System.Windows.Forms.Button outputButton;
    }
}

