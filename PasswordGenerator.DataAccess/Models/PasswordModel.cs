using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.DataAccess.Models
{
    public class PasswordModel
    {
        public string? PasswordGenerated { get; set; }
        public int NumOfChars { get; set; }
        public bool UseSpecialChars { get; set; }
    }
}
