using System;
using System.Collections.Generic;

namespace DisturbanceApp
{
    public static class Solver
    {
        private static List<Dictionary<string, double>> _regressorCoefficients = new List<Dictionary<string, double>>
        {
            new Dictionary<string, double>
            {
                { "Age", 0.35 },
                { "FreeTime", 0.22 },
                { "SleepTime", 0.16 },
                { "Sex", 0.26 },
                { "IsStudying", 0.3 },
                { "IsWorking", 0.15 },
                { "Music", 0.34 },
                { "NervousPeriod", 0.44 },
                { "ChronicWeak", 0.07 },
                { "Earning", 0.47 },
            },
            new Dictionary<string, double>
            {
                { "Age", 0.19 },
                { "FreeTime", 0.27 },
                { "SleepTime", 0.27 },
                { "Sex", 0.17 },
                { "IsStudying", 0.1 },
                { "IsWorking", 0.12 },
                { "Music", 0.26 },
                { "NervousPeriod", 0.54 },
                { "ChronicWeak", 0.39 },
                { "Earning", 0.23 },
            },
            new Dictionary<string, double>
            {
                { "Age", 0.14 },
                { "FreeTime", 0 },
                { "SleepTime", 0.03 },
                { "Sex", 0.08 },
                { "IsStudying", 0.06 },
                { "IsWorking", 0.44 },
                { "Music", 0.21 },
                { "NervousPeriod", 0.26 },
                { "ChronicWeak", 0 },
                { "Earning", 0.75 },
            },
            new Dictionary<string, double>
            {
                { "Age", 0.01 },
                { "FreeTime", 0 },
                { "SleepTime", 0.08 },
                { "Sex", 0.19 },
                { "IsStudying", 0.17 },
                { "IsWorking", 0 },
                { "Music", 0.21 },
                { "NervousPeriod", 0.41 },
                { "ChronicWeak", 0.11 },
                { "Earning", 0.25 },
            },
            new Dictionary<string, double>
            {
                { "Age", 0 },
                { "FreeTime", 0.02 },
                { "SleepTime", 0.09 },
                { "Sex", 0 },
                { "IsStudying", 0 },
                { "IsWorking", 0 },
                { "Music", 0.56 },
                { "NervousPeriod", 0.54 },
                { "ChronicWeak", 0.12 },
                { "Earning", 0.04 },
            },
        };

        private static List<double> _componentCoefficients = new List<double>
        {
            -3.406,
            2.613,
            4.380,
            -6.809,
            2.556,
        };

        public static double[] GetComps(Dictionary<string, double> kvps)
        {
            kvps["Age"] = (kvps["Age"] - 20.6383) / 1.63422;
            kvps["FreeTime"] = (kvps["FreeTime"] - 214.6809) / 97.37536;
            kvps["SleepTime"] = (kvps["SleepTime"] - 7.191489) / 1.469077;

            var compValues = new double[_componentCoefficients.Count];
            
            for (int i = 0; i < compValues.Length; i++)
            {
                compValues[i] = 0;
                foreach (var reg in _regressorCoefficients[i].Keys)
                {
                    compValues[i] += kvps[reg] * _regressorCoefficients[i][reg];
                }
            }

            return compValues;
        }

        public static double GetV(double[] compValues)
        {
            double sum = 0;
            for (int i = 0; i < _componentCoefficients.Count; i++)
            {
                sum += compValues[i] * _componentCoefficients[i];
            }

            var result = 1 - Math.Exp(-Math.Exp(sum));

            return result;
        }

        public static double Predict(Dictionary<string, double> answers)
        {
            return GetV(GetComps(answers));
        }
    }
}
