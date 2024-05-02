namespace Yes_No
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnswBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вопрос, на который можно ответить \"Да\" или \"Нет\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 47);
            this.textBox1.TabIndex = 1;
            // 
            // AnswBt
            // 
            this.AnswBt.BackColor = System.Drawing.Color.Thistle;
            this.AnswBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswBt.Location = new System.Drawing.Point(177, 131);
            this.AnswBt.Name = "AnswBt";
            this.AnswBt.Size = new System.Drawing.Size(203, 81);
            this.AnswBt.TabIndex = 2;
            this.AnswBt.Text = "Узнать ответ";
            this.AnswBt.UseVisualStyleBackColor = false;
            this.AnswBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(185, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ответ на ваш вопрос:";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Answer.Location = new System.Drawing.Point(241, 257);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(85, 26);
            this.Answer.TabIndex = 4;
            this.Answer.Text = "Нет/Да";
            this.Answer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(596, 378);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnswBt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Предсказатель судьбы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AnswBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Answer;
    }
}

