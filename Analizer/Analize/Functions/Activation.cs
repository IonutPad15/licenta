using System;

namespace Analizer
{
    public class Activation
    {
        public static double getValue(ActivCode code, double gin, double teta=0, double g=1, double a=1)
        {
            switch(code)
            {
                case ActivCode.Treapta:
                    return Step(gin, teta);
                case ActivCode.Semn:
                    return Sign(gin, teta);
                case ActivCode.Sigmoidala:
                    return Sigmoid(gin, teta, g);
                case ActivCode.Tanh:
                    return Tanh(gin, teta, g);
                case ActivCode.Liniara:
                    return Linear(gin,a, teta);
                default:
                    throw new Exception("Not good");
            }
        }
        static double Step(double gin, double teta)
        {
            if (gin >= teta) return 1;
            return 0;
        }
        static double Sign(double gin, double teta)
        {
            if (gin >= teta) return 1;
            return -1;
        }
        static double Sigmoid(double gin, double teta, double g)
        {
            double result = 1 / (1 + Math.Pow(Math.E, (-g) * (gin - teta)));
            return result;
        }
        static double Tanh(double gin, double teta, double g)
        {
            var elag = Math.Pow(Math.E, g * (gin - teta));
            var ela_g = Math.Pow(Math.E, (-g) * (gin - teta));
            double result = (elag-ela_g)/(elag+ela_g);
            return result;
        }
        static double Linear(double gin, double a, double teta)
        {
            if (gin > (1 / a)) return 1;
            else if (gin < (-1 / a)) return -1;
            return (a * (gin-teta));
        }
    }
    
    public enum ActivCode
    {
        Treapta,
        Semn,
        Sigmoidala,
        Tanh,
        Liniara
    }
}
