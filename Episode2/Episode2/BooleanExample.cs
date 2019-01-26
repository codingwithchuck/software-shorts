using System;

namespace Episode2
{
    public class BooleanExample
    {
        public string Check(bool hasValue)
        {
            if (!hasValue)
            {
                return GetChuck();
            }

            return GetErin();
        }

        private string GetChuck()
        {
            return "Chuck";
        }

        private string GetErin()
        {
            return "Erin";
        }
    }
}
 