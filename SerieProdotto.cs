using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        int maxprod = 0;
        int length= digits.Length;

        if (span > length)
            throw new System.ArgumentException();
        if ( span < 0)
            throw new System.ArgumentException();
        if (span == 0)
           return 1;

        char[] array = digits.ToCharArray();
        for (int i = 0; i < length; i++)
        {
            if (char.IsLetter(array[i]))
            {
              throw new System.ArgumentException();

            }

        }

        for (int j = 0; j <= length - span; j++)
        {
            int prod = 1;
            int supp = j;


            for (int y = 0; y < span; y++)
            {
                prod = prod * (array[supp] - 48);
                supp = supp + 1;
            }

            if (prod > maxprod)
            { 
             maxprod = prod;

            }


        }
      
        return maxprod;  

    }

    
}