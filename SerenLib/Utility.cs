namespace SerenLib.Util
{
    public static class Utility
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (double)((celsius * 9 / 5) + 32);
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return (double)(celsius + 273.15);
        }

        public static bool FiftyFifty()
        {
            Random random = new Random();
            return random.Next(2) == 0;           
        }
    }
}
