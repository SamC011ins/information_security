
namespace monoalphabetic
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
            button1 = new Button();
            WordTextBox = new TextBox();
            CypherLabel = new Label();
            DecryptLabel = new Label();
            HackLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(702, 80);
            button1.Name = "button1";
            button1.Size = new Size(132, 44);
            button1.TabIndex = 0;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += GetCypherButton_Click;
            // 
            // WordTextBox
            // 
            WordTextBox.BackColor = SystemColors.MenuText;
            WordTextBox.ForeColor = SystemColors.ControlLightLight;
            WordTextBox.Location = new Point(63, 31);
            WordTextBox.Name = "WordTextBox";
            WordTextBox.Size = new Size(771, 23);
            WordTextBox.TabIndex = 1;
            // 
            // CypherLabel
            // 
            CypherLabel.AutoSize = true;
            CypherLabel.ForeColor = SystemColors.ButtonHighlight;
            CypherLabel.Location = new Point(63, 95);
            CypherLabel.Name = "CypherLabel";
            CypherLabel.Size = new Size(57, 15);
            CypherLabel.TabIndex = 2;
            CypherLabel.Text = "тут пусто";
            // 
            // DecryptLabel
            // 
            DecryptLabel.AutoSize = true;
            DecryptLabel.ForeColor = SystemColors.ControlLightLight;
            DecryptLabel.Location = new Point(63, 264);
            DecryptLabel.Name = "DecryptLabel";
            DecryptLabel.Size = new Size(87, 15);
            DecryptLabel.TabIndex = 3;
            DecryptLabel.Text = "Тут никого нет";
            // 
            // HackLabel
            // 
            HackLabel.AutoSize = true;
            HackLabel.ForeColor = SystemColors.ButtonHighlight;
            HackLabel.Location = new Point(63, 496);
            HackLabel.Name = "HackLabel";
            HackLabel.Size = new Size(87, 15);
            HackLabel.TabIndex = 4;
            HackLabel.Text = "тут тоже пусто";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(63, 172);
            button2.Name = "button2";
            button2.Size = new Size(147, 41);
            button2.TabIndex = 5;
            button2.Text = "Дешифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += GetDecryptButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(63, 394);
            button3.Name = "button3";
            button3.Size = new Size(209, 64);
            button3.TabIndex = 6;
            button3.Text = "Взломать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += HackerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(884, 589);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(HackLabel);
            Controls.Add(DecryptLabel);
            Controls.Add(CypherLabel);
            Controls.Add(WordTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Одноалфавитный шифр";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private TextBox WordTextBox;
        private Label CypherLabel;
        private Label DecryptLabel;
        private Label HackLabel;
        private Button button2;
        private Button button3;
    }
}
