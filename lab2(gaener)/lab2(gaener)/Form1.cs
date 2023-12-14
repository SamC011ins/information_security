using System.Text;

namespace lab2_gaener_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string key = KeyTextBox.Text;
            string plaintext = PlainTextBox.Text;

            string ciphertext = GaenerEncrypt(plaintext, key);
            CipherTextBox.Text = ciphertext;
            PlainTextBox.Text = "";
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string key = KeyTextBox.Text;
            string ciphertext = CipherTextBox.Text;

            string decryptedText = GaenerDecrypt(ciphertext, key);
            PlainTextBox.Text = decryptedText;
            CipherTextBox.Text = "";
        }

        private string GaenerEncrypt(string text, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int charCode = (int)text[i];
                int keyChar = keyBytes[i % keyBytes.Length];
                int encryptedCharCode = charCode ^ keyChar;
                result.Append((char)encryptedCharCode);
            }

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(result.ToString()));
        }

        private string GaenerDecrypt(string encryptedText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            StringBuilder result = new StringBuilder();

            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            string encryptedString = Encoding.UTF8.GetString(encryptedBytes);

            for (int i = 0; i < encryptedString.Length; i++)
            {
                int charCode = (int)encryptedString[i];
                int keyChar = keyBytes[i % keyBytes.Length];
                int decryptedCharCode = charCode ^ keyChar;
                result.Append((char)decryptedCharCode);
            }

            return result.ToString();
        }
    }
}
