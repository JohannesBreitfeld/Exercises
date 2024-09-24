namespace Arv.Extensions
{
    internal static class RandomExtensions
    {
        public static double Double(this Random rand, double minValue, double maxValue)
        {
            return minValue + rand.NextDouble() * (maxValue - minValue);
        }
    }
}
