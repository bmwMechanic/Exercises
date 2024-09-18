namespace Schnittmenge          //   Schnittmenge berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] menge1 = { 7, -1, 3, 5, 7, 0 };
            int[] menge2 = { 3, -1, 3, 5, 7, 0 };
            string schnitt = "";
            int numIndex;
            int iterationCount = menge1.Count();

            for (int i = 0; i < menge1.Count(); i++)
            {
                for (int j = 0; j < iterationCount; j++)
                {
                    if (menge1[i] == menge2[j])
                    {
                        schnitt += menge1[i].ToString() + ",";
                        menge2[j] = int.MinValue;
                        /*  good try!
                        numIndex = Array.IndexOf(menge2, menge1[i]);
                        menge2 = menge2.Where((val,idx) => idx != menge1[i]).ToArray();
                        iterationCount --;
                        Console.WriteLine("menge2 Array: ");
                        foreach(var x in menge2)
                        {
                            Console.Write(x+",");
                        }
                        Console.WriteLine();
                        Console.WriteLine("iterationCount= "+iterationCount);
                        */
                        break;
                    }
                }
            }
            Console.WriteLine(schnitt);
        }
    }
}
