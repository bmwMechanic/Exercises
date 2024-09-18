namespace WeinBarcode   //                  Working with 2-D-Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Barcode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 }; Console.WriteLine(ermittlePruefziffer(Barcode));
            Console.WriteLine(sucheTopseller(2, 20));
        }

        public static int ermittlePruefziffer(int[] Barcode)
        {
            int summe = 0;
            int pruefziffer = 0;
            for (int i = 0; i < Barcode.Length; i += 2) //ich könnte noch genauer angeben aber  so ist auch ok, denke ich
            {
                summe += Barcode[i];
            }
            for (int i = 1; i < Barcode.Length - 1; i += 2) //hier MUSS ich genauer sein!! sonst nimmt der die 10. Arraystelle(prüfziffer) noch mit!
            {
                summe += Barcode[i] * 3;
            }
            return pruefziffer = summe % 10;
        }

        public static string sucheTopseller(int Kriterium, int Vorgabewert)
        {
            int maxValue = 0;
            string topsellerBarcode = string.Empty;
            int[,] Absatz =
        {
            { 123,456,78,9,46 },
            { 333,125,20,4,998 }
        };

            for (int i = 0; i < Absatz.GetLength(0); i++)
            {
                if (Absatz[i, Kriterium] == Vorgabewert)
                {
                    if (maxValue < Absatz[i, 4]) { maxValue = Absatz[i, 4]; }
                }
            }
            for (int j = 0; j < Absatz.GetLength(0); j++)
            {
                if (Absatz[j, Kriterium] == Vorgabewert && Absatz[j, 4] == maxValue)
                {
                    topsellerBarcode = $"{Absatz[j, 0]}-{Absatz[j, 1]}-{Absatz[j, 2]}-{Absatz[j, 3]}";
                }
            }
            return topsellerBarcode;
        }
    }
}