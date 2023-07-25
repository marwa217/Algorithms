using System;
using System.Collections.Generic;
using System.Linq;

namespace GetMaxSquadio
{
    internal  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entetr M");
            string M = Console.ReadLine();
            Console.WriteLine("entetr N");
            string NStr = Console.ReadLine();
            int.TryParse(NStr, out int N);

            var result = maximum_count(N, M, M.Length);
            Console.WriteLine("repeated Times = {0}", result);
        }

        static int maximum_count(int N,string M , int S)
        {
            int maximumCount = 0;
            Dictionary<int,int> repeatedNum= new Dictionary<int, int> ();
            var givenChars= new char[S];
            //245769
            givenChars = M.ToCharArray();
            for(int i =0; i<S; i++)
            {
                int.TryParse(givenChars[i].ToString(),out int temp);
                if (temp == 2)
                    temp = 5;
                else if (temp == 6)
                    temp = 9;
                if (repeatedNum.ContainsKey(temp))
                {
                    int value = repeatedNum[temp];
                    repeatedNum[temp] = value +1;
                    
                }
                else
                {
                    repeatedNum.Add(temp, 1);
                }  
            }

            if (N<=0)
                return maximumCount;
                // 5,6
            var NList=N.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            
            var checkRepeat = true;
            while (checkRepeat)
            {
                for (int j = 0; j < NList.Length; j++)
                {
                    int convertN = NList[j];
                    if (convertN == 2)
                        convertN = 5;
                    else if(convertN == 6)
                        convertN = 9;
                    if (repeatedNum.ContainsKey(convertN) && repeatedNum[convertN] > 0)
                    {
                        repeatedNum[convertN]--;

                    }
                    else
                    {
                        checkRepeat = false;
                        maximumCount -= 1;
                        break;
                    }
                }
                maximumCount += 1;
            }
            





            return maximumCount;
        }
    }
}
