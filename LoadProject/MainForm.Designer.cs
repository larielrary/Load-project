namespace LoadProject
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.YearLoadBtn = new System.Windows.Forms.Button();
            this.TeacherLoadBtn = new System.Windows.Forms.Button();
            this.exportToAccessBtn = new System.Windows.Forms.Button();
            this.configurationBtn = new System.Windows.Forms.Button();
            this.loadJarBtn = new System.Windows.Forms.Button();
            this.WebsiteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // YearLoadBtn
            // 
            resources.ApplyResources(this.YearLoadBtn, "YearLoadBtn");
            this.YearLoadBtn.Name = "YearLoadBtn";
            this.YearLoadBtn.UseVisualStyleBackColor = true;
            this.YearLoadBtn.Click += new System.EventHandler(this.YearBtnClick);
            // 
            // TeacherLoadBtn
            // 
            resources.ApplyResources(this.TeacherLoadBtn, "TeacherLoadBtn");
            this.TeacherLoadBtn.Name = "TeacherLoadBtn";
            this.TeacherLoadBtn.UseVisualStyleBackColor = true;
            this.TeacherLoadBtn.Click += new System.EventHandler(this.TeacherBtnClick);
            // 
            // exportToAccessBtn
            // 
            resources.ApplyResources(this.exportToAccessBtn, "exportToAccessBtn");
            this.exportToAccessBtn.Name = "exportToAccessBtn";
            this.exportToAccessBtn.UseVisualStyleBackColor = true;
            this.exportToAccessBtn.Click += new System.EventHandler(this.exportToAccessBtnClick);
            // 
            // configurationBtn
            // 
            resources.ApplyResources(this.configurationBtn, "configurationBtn");
            this.configurationBtn.Name = "configurationBtn";
            this.configurationBtn.UseVisualStyleBackColor = true;
            this.configurationBtn.Click += new System.EventHandler(this.configurationBtnClick);
            // 
            // loadJarBtn
            // 
            resources.ApplyResources(this.loadJarBtn, "loadJarBtn");
            this.loadJarBtn.Name = "loadJarBtn";
            this.loadJarBtn.UseVisualStyleBackColor = true;
            this.loadJarBtn.Click += new System.EventHandler(this.loadJarBtnClick);
            // 
            // WebsiteBtn
            // 
            resources.ApplyResources(this.WebsiteBtn, "WebsiteBtn");
            this.WebsiteBtn.Name = "WebsiteBtn";
            this.WebsiteBtn.UseVisualStyleBackColor = true;
            this.WebsiteBtn.Click += new System.EventHandler(this.WebsiteBtnClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.WebsiteBtn);
            this.Controls.Add(this.loadJarBtn);
            this.Controls.Add(this.configurationBtn);
            this.Controls.Add(this.exportToAccessBtn);
            this.Controls.Add(this.TeacherLoadBtn);
            this.Controls.Add(this.YearLoadBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button YearLoadBtn;
        private System.Windows.Forms.Button TeacherLoadBtn;
        private System.Windows.Forms.Button exportToAccessBtn;
        private System.Windows.Forms.Button configurationBtn;
        private System.Windows.Forms.Button loadJarBtn;
        private System.Windows.Forms.Button WebsiteBtn;
    }
}

