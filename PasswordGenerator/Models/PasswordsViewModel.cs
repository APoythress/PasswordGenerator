using System.Reflection;
using System.Text;

namespace PasswordGenerator.Models
{
    public class PasswordsViewModel
    {
        public string? PasswordGenerated { get; set; }
        public int NumOfChars { get; set; }
        public bool UseSpecialChars { get; set; }
    }
}
