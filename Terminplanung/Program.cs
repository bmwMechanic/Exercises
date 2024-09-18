namespace Terminplanung                         //  Working With 2-D-Arrays  
{
    internal class Terminplanung
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getAppointment(9, 30, 11111));    //slot is -1. looks for at least 1 Zero from DocArray[2 to 9] 
        }


        //public static bool (DateTime DayAndMonth, int ArztID, )
        public static bool getAppointment(int month, int day, int id, int slot = -1)
        {
            //int[][] DocArray = getTimeTable(id);
            bool b = false;
            int[,] DocArray =
                {
                { 9,30,1,1,1,1,0,1,1,1 },
                { 10,1,0,0,1,1,0,0,1,1 },
                { 10,2,0,0,0,1,1,1,1,1 }
                };


            for (int i = 0; i < DocArray.GetLength(0); i++)
            {
                if (DocArray[i, 0] == month && DocArray[i, 1] == day)
                {
                    if (slot == -1)
                    {
                        for (int j = 2; j < 8; j++)
                        {
                            if (DocArray[i, j] == 0) { b = true; break; }
                        }
                    }
                    else
                    {
                        if (DocArray[i, slot + 2] == 1)
                        {
                            b = false;
                        }
                        else { b = true; }
                    }
                }
            }
            return b;
        }
    }
}
