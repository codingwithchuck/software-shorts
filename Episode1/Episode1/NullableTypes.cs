using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1
{
    public class NullableTypes
    {
        //public int ConvertToInt(decimal? kids)
        //{

        //}

        public decimal ConvertToDecimal(decimal? kids)
        {
            return (decimal) kids;
        }
    }
}
