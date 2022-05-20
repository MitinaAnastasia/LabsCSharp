
namespace лаба3_с_шарп
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.PowerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FotoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DelFotoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WatchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnOnButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnOffButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 356);
            this.listBox1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.AddButton,
            this.DeleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(363, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TurnOnButton,
            this.PowerButton,
            this.FotoButton,
            this.ZoomingButton,
            this.DelFotoButton,
            this.WatchButton,
            this.TurnOffButton});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(179, 28);
            this.toolStripSplitButton1.Text = "Работа с устройством";
            // 
            // PowerButton
            // 
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(381, 26);
            this.PowerButton.Text = "Узнать статус зарядки";
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // FotoButton
            // 
            this.FotoButton.Name = "FotoButton";
            this.FotoButton.Size = new System.Drawing.Size(381, 26);
            this.FotoButton.Text = "Сделать фото";
            this.FotoButton.Click += new System.EventHandler(this.FotoButton_Click);
            // 
            // DelFotoButton
            // 
            this.DelFotoButton.Name = "DelFotoButton";
            this.DelFotoButton.Size = new System.Drawing.Size(381, 26);
            this.DelFotoButton.Text = "Удалить фото";
            this.DelFotoButton.Click += new System.EventHandler(this.DelFotoButton_Click);
            // 
            // WatchButton
            // 
            this.WatchButton.Name = "WatchButton";
            this.WatchButton.Size = new System.Drawing.Size(381, 26);
            this.WatchButton.Text = "Включить режим просмотра фотографий";
            this.WatchButton.Click += new System.EventHandler(this.WatchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 28);
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(69, 28);
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ZoomingButton
            // 
            this.ZoomingButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NearButton,
            this.FarButton});
            this.ZoomingButton.Name = "ZoomingButton";
            this.ZoomingButton.Size = new System.Drawing.Size(381, 26);
            this.ZoomingButton.Text = "Приблизить/отдалить";
            // 
            // NearButton
            // 
            this.NearButton.Name = "NearButton";
            this.NearButton.Size = new System.Drawing.Size(224, 26);
            this.NearButton.Text = "Приблизить";
            this.NearButton.Click += new System.EventHandler(this.NearButton_Click);
            // 
            // FarButton
            // 
            this.FarButton.Name = "FarButton";
            this.FarButton.Size = new System.Drawing.Size(224, 26);
            this.FarButton.Text = "Отдалить";
            this.FarButton.Click += new System.EventHandler(this.FarButton_Click);
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Size = new System.Drawing.Size(381, 26);
            this.TurnOnButton.Text = "Включить устройство";
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // TurnOffButton
            // 
            this.TurnOffButton.Name = "TurnOffButton";
            this.TurnOffButton.Size = new System.Drawing.Size(381, 26);
            this.TurnOffButton.Text = "Выключить устройство";
            this.TurnOffButton.Click += new System.EventHandler(this.TurnOffButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 417);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem PowerButton;
        private System.Windows.Forms.ToolStripMenuItem FotoButton;
        private System.Windows.Forms.ToolStripMenuItem DelFotoButton;
        private System.Windows.Forms.ToolStripMenuItem WatchButton;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem ZoomingButton;
        private System.Windows.Forms.ToolStripMenuItem NearButton;
        private System.Windows.Forms.ToolStripMenuItem FarButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TurnOnButton;
        private System.Windows.Forms.ToolStripMenuItem TurnOffButton;
    }
}

