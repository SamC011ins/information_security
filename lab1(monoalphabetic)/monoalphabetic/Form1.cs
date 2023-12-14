using System.Text;

namespace monoalphabetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<char, char> cypher = new Dictionary<char, char>
        {
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
            {'�', '�'},
        };


        private Dictionary<char, double> cypherProc = new Dictionary<char, double>
        {
            {'�', 7.998},
            {'�', 1.592},
            {'�', 4.533},
            {'�', 1.687},
            {'�', 2.977},
            {'�', 8.483},
            {'�', 0.013},
            {'�', 0.94},
            {'�', 1.641},
            {'�', 7.367},
            {'�', 1.208},
            {'�', 3.486},
            {'�', 4.343},
            {'�', 3.203},
            {'�', 6.7},
            {'�', 10.983},
            {'�', 2.804},
            {'�', 4.746},
            {'�', 5.473},
            {'�', 6.318},
            {'�', 2.615},
            {'�', 0.267},
            {'�', 0.967},
            {'�', 0.486},
            {'�', 1.45},
            {'�', 0.718},
            {'�', 0.361},
            {'�', 0.037},
            {'�', 1.96},
            {'�', 1.735},
            {'�', 0.331},
            {'�', 0.638},
            {'�', 2.001},
        };

        private double CalculateMSE(Dictionary<char, int> textCounts)
        {
            double mse = 0;
            var keys = textCounts.Keys.ToList();

            foreach (var key in keys)
            {
                if (cypherProc.ContainsKey(key))
                {
                    var diff = textCounts[key] - cypherProc[key];
                    mse += Math.Pow(diff, 2);
                }
            }

            if (keys.Count == 0)
            {
                return double.NaN;
            }

            mse /= keys.Count;
            return mse;
        }

        private void GetCypherButton_Click(object sender, EventArgs e)
        {
            var word = WordTextBox.Text.ToLower().Where(char.IsLetter).ToArray();

            if (!int.TryParse(word, out _))
            {

                var answer = word.Select(c => cypher.ContainsKey(c) ? cypher[c] : c).ToArray();
                CypherLabel.Text = new string(answer);
            }
        }

        private void GetDecryptButton_Click(object sender, EventArgs e)
        {
            var encryptedText = CypherLabel.Text.ToLowerInvariant();

            var reverseCypher = cypher.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            var decryptedText = new StringBuilder();

            foreach (var c in encryptedText)
            {
                if (reverseCypher.TryGetValue(c, out var decryptedChar))
                    decryptedText.Append(decryptedChar);
                else
                    decryptedText.Append(c);
            }
            DecryptLabel.Text = decryptedText.ToString();
        }

        private int PerformFrequencyAnalysis(string encryptedText)
        {
            var bestShift = 0;
            var lowestMSE = double.PositiveInfinity;

            for (var shift = 0; shift < 33; shift++)
            {
                var decryptedText = DecryptCaesarCipher(encryptedText, shift);
                var textCounts = new Dictionary<char, int>();

                foreach (var letter in decryptedText)
                {
                    if (cypherProc.ContainsKey(letter))
                    {
                        if (!textCounts.ContainsKey(letter))
                        {
                            textCounts[letter] = 0;
                        }
                        textCounts[letter]++;
                    }
                }

                var mse = CalculateMSE(textCounts);

                if (mse < lowestMSE)
                {
                    lowestMSE = mse;
                    bestShift = shift;
                }
            }

            return bestShift;
        }

        private string DecryptCaesarCipher(string encryptedText, int shift)
        {
            var decryptedText = new StringBuilder();

            foreach (var letter in encryptedText)
            {
                if (cypherProc.ContainsKey(letter))
                {
                    var decryptedCharCode = letter - shift;
                    if (char.IsUpper(letter))
                    {
                        if (decryptedCharCode < '�')
                        {
                            decryptedCharCode += 33;
                        }
                    }
                    else if (char.IsLower(letter))
                    {
                        if (decryptedCharCode < '�')
                        {
                            decryptedCharCode += 33;
                        }
                    }
                    decryptedText.Append((char)decryptedCharCode);
                }
                else
                {
                    decryptedText.Append(letter);
                }
            }

            return decryptedText.ToString();
        }

        private void HackerButton_Click(object sender, EventArgs e)
        {
            var displayDecrypt = CypherLabel.Text.ToLower();
            var textCounts = new Dictionary<char, int>();

            foreach (var letter in displayDecrypt)
            {
                if (cypher.ContainsKey(letter))
                {
                    if (!textCounts.ContainsKey(letter))
                    {
                        textCounts[letter] = 0;
                    }
                    textCounts[letter]++;
                }
            }

            var mse = CalculateMSE(textCounts);

            if (!double.IsNaN(mse))
            {
                Console.WriteLine($"Mean Squared Error: {mse}");

                var shift = PerformFrequencyAnalysis(displayDecrypt);
                var decryptedText = DecryptCaesarCipher(displayDecrypt, shift);

                HackLabel.Text = $"Found Shift: {shift}\nDecrypted Text: {decryptedText}";
            }
            else
            {
                Console.WriteLine("Error: Unable to calculate MSE.");
            }
        }
    }
}
