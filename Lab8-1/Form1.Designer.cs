
namespace Lab8_1
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
            this.queTxtBox = new System.Windows.Forms.TextBox();
            this.yOrNBtn = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.magicBallLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ask a closed-ended question";
            // 
            // queTxtBox
            // 
            this.queTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queTxtBox.Location = new System.Drawing.Point(150, 120);
            this.queTxtBox.Name = "queTxtBox";
            this.queTxtBox.Size = new System.Drawing.Size(700, 30);
            this.queTxtBox.TabIndex = 1;
            // 
            // yOrNBtn
            // 
            this.yOrNBtn.Location = new System.Drawing.Point(420, 166);
            this.yOrNBtn.Name = "yOrNBtn";
            this.yOrNBtn.Size = new System.Drawing.Size(153, 55);
            this.yOrNBtn.TabIndex = 2;
            this.yOrNBtn.Text = "Click to know ANSWER!";
            this.yOrNBtn.UseVisualStyleBackColor = true;
            this.yOrNBtn.Click += new System.EventHandler(this.yOrNBtn_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(460, 269);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 51);
            this.answerLabel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Magic 8-ball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // magicBallLabel
            // 
            this.magicBallLabel.AutoSize = true;
            this.magicBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magicBallLabel.Location = new System.Drawing.Point(362, 378);
            this.magicBallLabel.Name = "magicBallLabel";
            this.magicBallLabel.Size = new System.Drawing.Size(0, 51);
            this.magicBallLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.magicBallLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.yOrNBtn);
            this.Controls.Add(this.queTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queTxtBox;
        private System.Windows.Forms.Button yOrNBtn;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label magicBallLabel;
    }
}

