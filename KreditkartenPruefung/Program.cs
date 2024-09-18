namespace KreditkartenPruefung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Kredirkartennummer = "9342571866601997";
            //Console.WriteLine(querSumme(55));
            Console.WriteLine(pruefzifferBerechnen(Kredirkartennummer));
        }


        public static int querSumme(int zahl)
        {
            string zahlStr = zahl.ToString();
            int quersumme = 0;

            foreach (char c in zahlStr)
            {
                quersumme += Convert.ToInt32(c.ToString());
            }
            return quersumme;
        }


        public static int rundeAuf(int zahl)
        {
            int aufgerundeteZahl = 0;

            if (zahl % 10 != 0)
            {
                return aufgerundeteZahl = zahl + (10 - (zahl % 10));
            }
            else return zahl;
        }


        public static bool pruefzifferBerechnen(string nr)
        {
            int sum = 0; int pruefziffer = 0;
            int[] Nummern = new int[nr.Length];

            for (int i = 0; i < Nummern.Length; i++)
            {
                Nummern[i] = Convert.ToInt32(nr[i].ToString());
                // For Testing Purposes: Console.WriteLine(Nummern[i]);
            }
            for (int j = 1; j < Nummern.Length - 1; j += 2)
            {
                // For Testing Purposes: Console.WriteLine("gerade mit -1: " + Nummern[j]);
                sum += querSumme(Nummern[j] * 3);
            }
            for (int j = 0; j < Nummern.Length - 1; j += 2)
            {
                // For Testing Purposes: Console.WriteLine("ungerade mit -2: " + Nummern[j]);
                sum += Nummern[j];
            }

            pruefziffer = rundeAuf(sum) - sum;

            if (pruefziffer == Nummern[15]) { return true; } else return false;
        }
    }
}