namespace DOtel
{
    partial class AUTH
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
            this.EXIT = new System.Windows.Forms.Button();
            this.SINGIN = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grayTXT2 = new DOtel.TXTy.grayTXT();
            this.grayTXT1 = new DOtel.TXTy.grayTXT();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXIT.Location = new System.Drawing.Point(36, 221);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(100, 26);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "Выход";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // SINGIN
            // 
            this.SINGIN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SINGIN.Location = new System.Drawing.Point(240, 221);
            this.SINGIN.Name = "SINGIN";
            this.SINGIN.Size = new System.Drawing.Size(100, 26);
            this.SINGIN.TabIndex = 3;
            this.SINGIN.Text = "Вход";
            this.SINGIN.UseVisualStyleBackColor = true;
            this.SINGIN.Click += new System.EventHandler(this.SINGIN_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(263, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Tag = "";
            this.checkBox1.Text = "Показать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "НИИ РОССТАТ";
            // 
            // grayTXT2
            // 
            this.grayTXT2.Cue = "Пароль";
            this.grayTXT2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grayTXT2.Location = new System.Drawing.Point(36, 140);
            this.grayTXT2.Name = "grayTXT2";
            this.grayTXT2.Size = new System.Drawing.Size(215, 27);
            this.grayTXT2.TabIndex = 1;
            this.grayTXT2.UseSystemPasswordChar = true;
            // 
            // grayTXT1
            // 
            this.grayTXT1.Cue = "Логин";
            this.grayTXT1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grayTXT1.Location = new System.Drawing.Point(36, 83);
            this.grayTXT1.Name = "grayTXT1";
            this.grayTXT1.Size = new System.Drawing.Size(215, 27);
            this.grayTXT1.TabIndex = 0;
            // 
            // AUTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SINGIN);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.grayTXT2);
            this.Controls.Add(this.grayTXT1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AUTH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTy.grayTXT grayTXT1;
        private TXTy.grayTXT grayTXT2;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button SINGIN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

