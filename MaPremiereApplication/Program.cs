using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] randomNumberArray = new int[7];
            Random aleatoire = new Random();

            for (int i = 0; i < 7; i++)
            {
                
                int mois = aleatoire.Next(1 , 49);

                if (randomNumberArray.Contains(mois))
                {
                    i--;
                }
                else
                {
                    randomNumberArray[i] = mois;

                }
            }

            getRandomNumber(randomNumberArray);

        }

        static void getRandomNumber(int [] array)
        {
            foreach (int element in array) {
                Console.WriteLine(element);
            }
        }
        

    }
}
