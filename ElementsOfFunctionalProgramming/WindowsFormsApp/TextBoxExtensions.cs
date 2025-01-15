using System.Windows.Forms;

namespace WindowsFormsApp
{
	public static class TextBoxExtensions
	{
		public static void EnableMorseCodeTranslation(this TextBox textBox, TextBox textBox2)
		{
			string morseCode = string.Empty;

			textBox.TextChanged += (sender, e) =>
			{
				string inputText = textBox.Text.ToUpper();
				string translatedText = TranslateToMorseCode(inputText);
				textBox2.Text = translatedText;
			};

			string TranslateToMorseCode(string input)
			{
				var azbuka = new string[]
				{
					".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
					".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-",
					".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
					"-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."
				};

				string result = string.Empty;
				foreach (char c in input)
				{
					if (c >= 'A' && c <= 'Z')
					{
						result += azbuka[c - 'A'] + " ";
					}
					else if (c >= '0' && c <= '9')
					{
						result += azbuka[c - '0' + 26] + " ";
					}
				}

				return result.Trim();
			}
		}
	}
}
