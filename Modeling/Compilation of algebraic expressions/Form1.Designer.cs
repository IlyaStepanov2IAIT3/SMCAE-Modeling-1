
namespace Compilation_of_algebraic_expressions
{
    partial class MainWindow
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
            this.setBtn = new System.Windows.Forms.Button();
            this.immutInfixLb = new System.Windows.Forms.Label();
            this.infixLb = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.tactBtn = new System.Windows.Forms.Button();
            this.postfixLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(324, 100);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(385, 37);
            this.setBtn.TabIndex = 0;
            this.setBtn.Text = "Задать";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // immutInfixLb
            // 
            this.immutInfixLb.AutoSize = true;
            this.immutInfixLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.immutInfixLb.Location = new System.Drawing.Point(318, 9);
            this.immutInfixLb.Name = "immutInfixLb";
            this.immutInfixLb.Size = new System.Drawing.Size(336, 31);
            this.immutInfixLb.TabIndex = 1;
            this.immutInfixLb.Text = "Неизменяемый инфикс...";
            // 
            // infixLb
            // 
            this.infixLb.AutoSize = true;
            this.infixLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infixLb.Location = new System.Drawing.Point(318, 52);
            this.infixLb.Name = "infixLb";
            this.infixLb.Size = new System.Drawing.Size(138, 31);
            this.infixLb.TabIndex = 2;
            this.infixLb.Text = "Инфикс...";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(324, 143);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(385, 37);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // tactBtn
            // 
            this.tactBtn.Location = new System.Drawing.Point(324, 186);
            this.tactBtn.Name = "tactBtn";
            this.tactBtn.Size = new System.Drawing.Size(385, 37);
            this.tactBtn.TabIndex = 4;
            this.tactBtn.Text = "Такт";
            this.tactBtn.UseVisualStyleBackColor = true;
            this.tactBtn.Click += new System.EventHandler(this.TactBtn_Click);
            // 
            // postfixLb
            // 
            this.postfixLb.AutoSize = true;
            this.postfixLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postfixLb.Location = new System.Drawing.Point(12, 9);
            this.postfixLb.Name = "postfixLb";
            this.postfixLb.Size = new System.Drawing.Size(0, 31);
            this.postfixLb.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.postfixLb);
            this.Controls.Add(this.tactBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.infixLb);
            this.Controls.Add(this.immutInfixLb);
            this.Controls.Add(this.setBtn);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Label immutInfixLb;
        private System.Windows.Forms.Label infixLb;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button tactBtn;
        private System.Windows.Forms.Label postfixLb;
    }
}

