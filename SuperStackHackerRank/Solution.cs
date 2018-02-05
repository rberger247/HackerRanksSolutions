using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStackHackerRank
{
  public static  class Solution
    {
        public static int Superstack(string[] operations)
        {

            List<int> oCurrentStack = new List<int>();
            List<int> TopOfStacksAtAllPoints = new List<int>();
            int answer = 0;
            int k = -1;
            int e = -1;
            if (operations.Length > 2 * (Math.Pow(10, 5)) || operations.Length < 1)
            {
                Console.WriteLine("The amount of operations must be between 1 and 2 * 10^5 ");
              
            }

            //loop through the operations and perform the appropriate operation  
            for (int z = 0; z < operations.Length; z++)
            {
                string theCommand = operations[z];
                string[] aCommand = theCommand.Split(' ');


                if (aCommand.Contains("push"))
                {
                    k = Convert.ToInt32(aCommand[1].Trim());
                    oCurrentStack = Push(oCurrentStack, Convert.ToInt32(aCommand[1]));
                }


                if (aCommand.Contains("pop"))
                {
                    if (oCurrentStack.Count == 0)
                    {
                        Console.WriteLine("Can't remove from an empty stack");
                        Console.ReadLine();
                    }
                    else

                        oCurrentStack = Pop(oCurrentStack);

                    if (oCurrentStack.Count == 0)
                    {
                       Console.WriteLine("Empty");
                   
                    }
                    else
                    {                  
                        Console.WriteLine(oCurrentStack[0]);
                                         
                    }
                }


                if (theCommand.Contains("inc"))
                {
                    k = Convert.ToInt32(aCommand[1].Trim());
                    e = Convert.ToInt32(aCommand[2].Trim());
                    if (k > Math.Pow(10, 9) || k < Math.Pow(-10, 9))
                    {

                        Console.WriteLine("you must enter a number between -10^9 and 10^9");

                    }

                    if (e > oCurrentStack.Count)
                    {
                        Console.WriteLine("Bottom Number Can't be larger then stack size");
                    }

                    else
                    {
                        oCurrentStack = inc(e, k, oCurrentStack);
                    }               
            

                }


                TopOfStacksAtAllPoints.Add(oCurrentStack[0]);

            
                answer = oCurrentStack[0];
            }
            foreach (var topOfStack in TopOfStacksAtAllPoints)
            {
                Console.WriteLine(topOfStack);
            }

            return answer;
        }

        public  static List<int> Push(List<int> oStack, int number)
            {
                
         
                oStack.Insert(0, number); 
                var topNumber = oStack.ElementAt(0);
                return oStack;
            }

            public  static List<int> Pop(List<int> oStack)
            {               
                // Remove Top Item
                oStack.RemoveAt(0);         
          
                return oStack;

            }
            public  static List<int> inc(int k, int e, List<int> oStack)
            {            
        
      
                var count = oStack.Count;
              
                //get bottom e  items
                var bottomItems = oStack.Skip(count - e).ToList();
          
                // add to bottom e items  int K
                for (int i = 0; i < bottomItems.Count; i++)
                {
                    bottomItems[i] +=  k;
                }

                // get the top of the list
                var topOfList = oStack.Take(count - e).ToList();

                // combine the botttom and top of lists
                topOfList.AddRange(bottomItems);
 
                // give appropriate name to the combined list
                var CompleteListWithNumbersAddedAtTheBottom = topOfList;                   

                return CompleteListWithNumbersAddedAtTheBottom;
            }    
       
    }

   
}
