namespace lab2_gaener_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KeyTextBox = new TextBox();
            PlainTextBox = new TextBox();
            CipherTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Key = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // KeyTextBox
            // 
            KeyTextBox.BackColor = SystemColors.WindowFrame;
            KeyTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyTextBox.ForeColor = SystemColors.ButtonHighlight;
            KeyTextBox.Location = new Point(38, 74);
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.Size = new Size(146, 26);
            KeyTextBox.TabIndex = 0;
            // 
            // PlainTextBox
            // 
            PlainTextBox.BackColor = SystemColors.WindowFrame;
            PlainTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlainTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlainTextBox.Location = new Point(38, 184);
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.Size = new Size(216, 26);
            PlainTextBox.TabIndex = 1;
            // 
            // CipherTextBox
            // 
            CipherTextBox.BackColor = SystemColors.WindowFrame;
            CipherTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CipherTextBox.ForeColor = SystemColors.ButtonHighlight;
            CipherTextBox.Location = new Point(38, 292);
            CipherTextBox.Name = "CipherTextBox";
            CipherTextBox.Size = new Size(216, 26);
            CipherTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(289, 134);
            button1.Name = "button1";
            button1.Size = new Size(134, 39);
            button1.TabIndex = 3;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += EncryptButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(289, 238);
            button2.Name = "button2";
            button2.Size = new Size(148, 39);
            button2.TabIndex = 4;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DecryptButton_Click;
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Key.ForeColor = SystemColors.ButtonHighlight;
            Key.Location = new Point(38, 27);
            Key.Name = "Key";
            Key.Size = new Size(41, 16);
            Key.TabIndex = 5;
            Key.Text = "Ключ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 134);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 6;
            label1.Text = "Текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(38, 238);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 7;
            label2.Text = "Шифр текст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(479, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Key);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CipherTextBox);
            Controls.Add(PlainTextBox);
            Controls.Add(KeyTextBox);
            Name = "Form1";
            Text = "Gaener";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KeyTextBox;
        private TextBox PlainTextBox;
        private TextBox CipherTextBox;
        private Button button1;
        private Button button2;
        private Label Key;
        private Label label1;
        private Label label2;
    }
}
