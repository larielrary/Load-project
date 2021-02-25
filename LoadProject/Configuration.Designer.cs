
namespace LoadProject
{
    partial class Configuration
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
            this.standartPathCheckBox = new System.Windows.Forms.CheckBox();
            this.userPathCheckBox = new System.Windows.Forms.CheckBox();
            this.standartPathTextBox = new System.Windows.Forms.TextBox();
            this.userPathTextBox = new System.Windows.Forms.TextBox();
            this.ChosePathBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standartPathCheckBox
            // 
            this.standartPathCheckBox.AutoSize = true;
            this.standartPathCheckBox.Location = new System.Drawing.Point(30, 36);
            this.standartPathCheckBox.Name = "standartPathCheckBox";
            this.standartPathCheckBox.Size = new System.Drawing.Size(359, 31);
            this.standartPathCheckBox.TabIndex = 0;
            this.standartPathCheckBox.Text = "Использовать стандартный путь";
            this.standartPathCheckBox.UseVisualStyleBackColor = true;
            // 
            // userPathCheckBox
            // 
            this.userPathCheckBox.AutoSize = true;
            this.userPathCheckBox.Location = new System.Drawing.Point(30, 174);
            this.userPathCheckBox.Name = "userPathCheckBox";
            this.userPathCheckBox.Size = new System.Drawing.Size(238, 31);
            this.userPathCheckBox.TabIndex = 1;
            this.userPathCheckBox.Text = "Выбрать другой путь";
            this.userPathCheckBox.UseVisualStyleBackColor = true;
            // 
            // standartPathTextBox
            // 
            this.standartPathTextBox.Location = new System.Drawing.Point(61, 95);
            this.standartPathTextBox.Name = "standartPathTextBox";
            this.standartPathTextBox.Size = new System.Drawing.Size(445, 34);
            this.standartPathTextBox.TabIndex = 2;
            // 
            // userPathTextBox
            // 
            this.userPathTextBox.Location = new System.Drawing.Point(61, 242);
            this.userPathTextBox.Name = "userPathTextBox";
            this.userPathTextBox.Size = new System.Drawing.Size(415, 34);
            this.userPathTextBox.TabIndex = 3;
            // 
            // ChosePathBtn
            // 
            this.ChosePathBtn.Location = new System.Drawing.Point(524, 242);
            this.ChosePathBtn.Name = "ChosePathBtn";
            this.ChosePathBtn.Size = new System.Drawing.Size(103, 34);
            this.ChosePathBtn.TabIndex = 4;
            this.ChosePathBtn.Text = "Выбрать";
            this.ChosePathBtn.UseVisualStyleBackColor = true;
            this.ChosePathBtn.Click += new System.EventHandler(this.chosePathBtnClick);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(524, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChosePathBtn);
            this.Controls.Add(this.userPathTextBox);
            this.Controls.Add(this.standartPathTextBox);
            this.Controls.Add(this.userPathCheckBox);
            this.Controls.Add(this.standartPathCheckBox);
            this.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox standartPathCheckBox;
        private System.Windows.Forms.CheckBox userPathCheckBox;
        private System.Windows.Forms.TextBox standartPathTextBox;
        private System.Windows.Forms.TextBox userPathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ChosePathBtn;
    }
}