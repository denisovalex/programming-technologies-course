namespace App.FuzzyNumbers
{
    public class HarmonicFuzzyNumber : IFuzzyNumber
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public HarmonicFuzzyNumber(double a, double b)
        {
            A = a;
            B = b;
        }

        public int Defuzzify()
        {
            var numerator = 0.0;
            var denominator = 0.0;

            for (var x = B - A; x <= B + A; x += 1)
            {
                var membershipFunctionValue = CalculateMembershipFunction(x);

                numerator += x * membershipFunctionValue;
                denominator += membershipFunctionValue;

                Console.WriteLine("\tx = {0}, \u00b5(x) = {1}", x, membershipFunctionValue);
            }

            int defuzzifiedValue;
            if (denominator == 0)
                defuzzifiedValue = 0;
            else
                defuzzifiedValue = (int)Math.Round(numerator / denominator);

            Console.WriteLine("\tDefuzzified value is {0}", defuzzifiedValue);

            return defuzzifiedValue;
        }

        private double CalculateMembershipFunction(double x)
        {
            if (x >= B - A && x <= B + A)
                return 0.5 * (1 + Math.Cos(Math.PI * (x - B) / A));
            else
                return 0;
        }
    }
}
