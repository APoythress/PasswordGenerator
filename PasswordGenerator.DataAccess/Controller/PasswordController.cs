using PasswordGenerator.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.DataAccess.Controller
{
    public class PasswordController
    {
        public string CreatePassword(PasswordModel password)
        {
            const string charsNoSpecial = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            const string specialChars = "$!*#%&^";

            char ch = ' ';
            Random random = new Random();
            StringBuilder str_build = new StringBuilder();

            if (password.UseSpecialChars)
            {
                for (int i = 0; i < password.NumOfChars; i++)
                {

                    // Every 3th iteration will add in a random special character
                    if (i % 3 == 0)
                    {
                        int randomNumber = random.Next(0, 6);
                        ch = specialChars[randomNumber];
                        str_build.Append(ch);
                    }
                    else
                    {
                        int randomNumber = random.Next(0, 61);
                        ch = charsNoSpecial[randomNumber];
                        str_build.Append(ch);
                    }
                }
            }
            else
            {
                for (int i = 0; i < password.NumOfChars; i++)
                {
                    int randomNumber = random.Next(0, 61);
                    ch = charsNoSpecial[randomNumber];
                    str_build.Append(ch);

                }
            }
            password.PasswordGenerated = str_build.ToString();
            return password.PasswordGenerated;
        }

    }
}
