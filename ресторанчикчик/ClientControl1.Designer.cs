namespace ресторанчикчик
{
    partial class ClientControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonCode = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(20, 29);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(217, 20);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Номер телефона (без 8/+7)";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(24, 62);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(213, 26);
            this.textBoxNum.TabIndex = 1;
            // 
            // buttonCode
            // 
            this.buttonCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCode.Location = new System.Drawing.Point(346, 62);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(183, 35);
            this.buttonCode.TabIndex = 2;
            this.buttonCode.Text = "Получить код";
            this.buttonCode.UseVisualStyleBackColor = true;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(662, 62);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(204, 26);
            this.textBoxCode.TabIndex = 3;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(663, 29);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(203, 20);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Введите полученный код";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(33, 186);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 47);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(690, 186);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(176, 47);
            this.buttonContinue.TabIndex = 6;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // ClientControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelNum);
            this.Name = "ClientControl1";
            this.Size = new System.Drawing.Size(904, 246);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonContinue;
    }
}
