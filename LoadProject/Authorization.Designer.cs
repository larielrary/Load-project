namespace LoadProject
{
    partial class Authorization
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
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.InputBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginTextBox
			// 
			this.loginTextBox.Location = new System.Drawing.Point(33, 50);
			this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(132, 30);
			this.loginTextBox.TabIndex = 0;
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(33, 137);
			this.passTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.PasswordChar = '*';
			this.passTextBox.Size = new System.Drawing.Size(132, 30);
			this.passTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(73, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 98);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// InputBtn
			// 
			this.InputBtn.Location = new System.Drawing.Point(12, 191);
			this.InputBtn.Name = "InputBtn";
			this.InputBtn.Size = new System.Drawing.Size(75, 31);
			this.InputBtn.TabIndex = 4;
			this.InputBtn.Text = "Войти";
			this.InputBtn.UseVisualStyleBackColor = true;
			this.InputBtn.Click += new System.EventHandler(this.InputBtnClick);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(108, 191);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 31);
			this.ExitBtn.TabIndex = 5;
			this.ExitBtn.Text = "Выход";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// Authorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 250);
			this.ControlBox = false;
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.InputBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.loginTextBox);
			this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Authorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Authorization_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Button ExitBtn;
	}
}