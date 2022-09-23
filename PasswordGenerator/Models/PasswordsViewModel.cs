using PasswordGeneratorClasses;
using PasswordGeneratorClasses.Models;
using System.Reflection;
using System.Text;

namespace PasswordGenerator.Models
{
    public class PasswordsViewModel
    {
        public PasswordModel CurrentPassword { get; set; }
        public List<PasswordModel> PasswordList { get; set; }
        
        public PasswordsViewModel()
        {
            CurrentPassword = GetPassword();
            CurrentPassword = new PasswordModel();
        }

        public PasswordModel GetPassword()
        {
            return PasswordController.GetPassword();
        }
    }
}
