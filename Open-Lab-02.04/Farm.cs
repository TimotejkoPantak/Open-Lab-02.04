using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            chickens = chickens*2;
            cows = cows*4;
            pigs = pigs*4;
            return chickens + cows + pigs ;
            
        }
    }
}
