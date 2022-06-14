using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Password min {length} xarakter olmalidir",
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {

                Code = "PasswordRequiresUpper",
                Description = "En az 1 kicik herf olmalidi"

            };
        }
    }
}
