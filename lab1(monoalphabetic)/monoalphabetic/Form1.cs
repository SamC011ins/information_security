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
            {'à', 'ä'},
            {'á', 'å'},
            {'â', '¸'},
            {'ã', 'æ'},
            {'ä', 'ç'},
            {'å', 'è'},
            {'¸', 'é'},
            {'æ', 'ê'},
            {'ç', 'ë'},
            {'è', 'ì'},
            {'é', 'í'},
            {'ê', 'î'},
            {'ë', 'ï'},
            {'ì', 'ð'},
            {'í', 'ñ'},
            {'î', 'ò'},
            {'ï', 'ó'},
            {'ð', 'ô'},
            {'ñ', 'õ'},
            {'ò', 'ö'},
            {'ó', '÷'},
            {'ô', 'ø'},
            {'õ', 'ù'},
            {'ö', 'ú'},
            {'÷', 'û'},
            {'ø', 'ü'},
            {'ù', 'ý'},
            {'ú', 'þ'},
            {'û', 'ÿ'},
            {'ü', 'à'},
            {'ý', 'á'},
            {'þ', 'â'},
            {'ÿ', 'ã'},
        };


        private Dictionary<char, double> cypherProc = new Dictionary<char, double>
        {
            {'à', 7.998},
            {'á', 1.592},
            {'â', 4.533},
            {'ã', 1.687},
            {'ä', 2.977},
            {'å', 8.483},
            {'¸', 0.013},
            {'æ', 0.94},
            {'ç', 1.641},
            {'è', 7.367},
            {'é', 1.208},
            {'ê', 3.486},
            {'ë', 4.343},
            {'ì', 3.203},
            {'í', 6.7},
            {'î', 10.983},
            {'ï', 2.804},
            {'ð', 4.746},
            {'ñ', 5.473},
            {'ò', 6.318},
            {'ó', 2.615},
            {'ô', 0.267},
            {'õ', 0.967},
            {'ö', 0.486},
            {'÷', 1.45},
            {'ø', 0.718},
            {'ù', 0.361},
            {'ú', 0.037},
            {'û', 1.96},
            {'ü', 1.735},
            {'ý', 0.331},
            {'þ', 0.638},
            {'ÿ', 2.001},
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
                        if (decryptedCharCode < 'À')
                        {
                            decryptedCharCode += 33;
                        }
                    }
                    else if (char.IsLower(letter))
                    {
                        if (decryptedCharCode < 'à')
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
