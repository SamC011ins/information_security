namespace protect_inf_LR1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEncodeKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDecodeKeyWord = new System.Windows.Forms.TextBox();
            this.TextBoxVal = new System.Windows.Forms.TextBox();
            this.TextBoxVal1 = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEncrypt.Location = new System.Drawing.Point(30, 107);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(135, 37);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonDecipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecipher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDecipher.Location = new System.Drawing.Point(383, 107);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(138, 37);
            this.buttonDecipher.TabIndex = 2;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = false;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ключевое слово:";
            // 
            // textBoxEncodeKeyWord
            // 
            this.textBoxEncodeKeyWord.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEncodeKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEncodeKeyWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEncodeKeyWord.Location = new System.Drawing.Point(30, 52);
            this.textBoxEncodeKeyWord.Name = "textBoxEncodeKeyWord";
            this.textBoxEncodeKeyWord.Size = new System.Drawing.Size(135, 26);
            this.textBoxEncodeKeyWord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(380, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключевое слово:";
            // 
            // textBoxDecodeKeyWord
            // 
            this.textBoxDecodeKeyWord.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDecodeKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodeKeyWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDecodeKeyWord.Location = new System.Drawing.Point(383, 52);
            this.textBoxDecodeKeyWord.Name = "textBoxDecodeKeyWord";
            this.textBoxDecodeKeyWord.Size = new System.Drawing.Size(138, 26);
            this.textBoxDecodeKeyWord.TabIndex = 6;
            // 
            // TextBoxVal
            // 
            this.TextBoxVal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxVal.Location = new System.Drawing.Point(383, 201);
            this.TextBoxVal.Name = "TextBoxVal";
            this.TextBoxVal.Size = new System.Drawing.Size(138, 26);
            this.TextBoxVal.TabIndex = 7;
            // 
            // TextBoxVal1
            // 
            this.TextBoxVal1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxVal1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxVal1.Location = new System.Drawing.Point(30, 201);
            this.TextBoxVal1.Name = "TextBoxVal1";
            this.TextBoxVal1.Size = new System.Drawing.Size(135, 26);
            this.TextBoxVal1.TabIndex = 8;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(26, 258);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(55, 20);
            this.Label.TabIndex = 9;
            this.Label.Text = "Шифр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(379, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Расшифровка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(379, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(581, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBoxVal1);
            this.Controls.Add(this.TextBoxVal);
            this.Controls.Add(this.textBoxDecodeKeyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEncodeKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEncodeKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDecodeKeyWord;
        private System.Windows.Forms.TextBox TextBoxVal;
        private System.Windows.Forms.TextBox TextBoxVal1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

