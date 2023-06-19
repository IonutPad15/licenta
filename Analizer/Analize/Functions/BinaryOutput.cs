namespace Analizer
{
    public class BinaryOutput
    {
        public static double getValue(double activ, ActivCode code)
        {
            if (code == ActivCode.Treapta || code == ActivCode.Semn)
                return activ;
            if (code == ActivCode.Sigmoidala)
            {
                return Sigmoid(activ);
            }
            else return TanLinear(activ);
        }
        private static double Sigmoid(double activ)
        {
            if (activ >= 0.5) return 1;
            return 0;
        }
        private static double TanLinear(double activ)
        {
            if (activ >= 0) return 1;
            return -1;
        }
    }

}
