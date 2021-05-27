using System;

namespace z._1
{
    class Program
    {


        public static double Srednia(int[][] tab)
        {
            double s = 0f;
            double w = 0f;
            int counter = 0;
            if (tab == null)
            {
                w = 0.00f;
                return w;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] != null)
                {
                    for (int j = 0; j < tab[i].Length; j++)
                    {
                        if (tab[i][j] > 0)
                        {
                            s += tab[i][j];
                            counter++;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                w = 0.00f;
                return w;
            }
            else
            {
                w = Math.Round(s / counter, 2);
                return w;
            }

        }
    }
}
