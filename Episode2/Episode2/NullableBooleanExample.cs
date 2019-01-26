using System.Reflection.Metadata;

namespace Episode2
{
    public class NullableBooleanExample
    {
        public string GetValue(bool? hasItems = null)
        {
            if (hasItems == true)
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
