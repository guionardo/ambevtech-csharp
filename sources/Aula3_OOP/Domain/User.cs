using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Domain
{
    public class User
    {
        public string Name { get; init; } = "";
        public string Email { get; init; } = "";

        public override string ToString() => $"{Name} ({Email})";

    }
}
