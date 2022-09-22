using System.Reflection;
using System.Text;

namespace PasswordGenerator.Models
{
    public class GenerateRandomPasswordViewModel
    {
        public GenerateRandomPasswordViewModel(int numberOfCharacters, bool useSpecialCharacters)
        {
            _numberOfCharacters = numberOfCharacters;
            _useSpecialCharacters = useSpecialCharacters;
        }

        public GenerateRandomPasswordViewModel()
        {

        }

        public void PrepPasswordParameters(int numberOfCharacters, bool useSpecialCharacters)
        {
            int numCharacters = _numberOfCharacters;
            bool specialChar = _useSpecialCharacters;
        }


        public string RandomString()
        {
            GenerateRandomPasswordViewModel model = new GenerateRandomPasswordViewModel();

            const string charsNoSpecial = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string charsWithSpecial = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789$!*#%&^abcdefghijklmnopqrstuvwxyz";

            char ch = ' ';
            Random random = new Random();
            StringBuilder str_build = new StringBuilder();

            if (model._useSpecialCharacters)
            {
                for (int i = 0; i < _numberOfCharacters; i++)
                {
                    int randomNumber = random.Next(0, 68);
                    ch = charsWithSpecial[randomNumber];
                    str_build.Append(ch);

                }
            }
            else
            {
                for (int i = 0; i < _numberOfCharacters; i++)
                {
                    int randomNumber = random.Next(0, 68);
                    ch = charsNoSpecial[randomNumber];
                    str_build.Append(ch);

                }
            }
            return model._generatedPassword = str_build.ToString();
        }

        private int _numberOfCharacters { get; set; }
        private bool _useSpecialCharacters { get; set; }
        private string _generatedPassword { get; set; }
    }
}
