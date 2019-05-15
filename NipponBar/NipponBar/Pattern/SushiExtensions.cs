using NipponBar.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Pattern
{
    public static class SushiExtensions
    {
        public static Sushi1 Copy(this Sushi1 original)
        {
            Sushi1 copy = new Sushi1
            {
                ImagePath = original.ImagePath,
                SushiName = original.SushiName,
                Option = original.Option,
                Price = original.Price

            };
            return copy;
        }
    }
}
