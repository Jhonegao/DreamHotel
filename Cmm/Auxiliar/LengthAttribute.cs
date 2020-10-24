using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon.Auxiliar
{
    public class LengthAttribute : Attribute
    {
        public int FieldLength { get; set; }
       
        public LengthAttribute(int fieldLength)
        {
            FieldLength = fieldLength;
        }
    }
    public class MinLength : Attribute
    {
        public int MinFieldLength { get; set; }
        public MinLength(int minFieldLength)
        {
            MinFieldLength = minFieldLength;
        }
    }
}

