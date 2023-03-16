using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
      
      int i = 0;
      while (p0 < p) {
        p0 = p0 + Convert.ToInt32(p0 * percent * 0.01) + aug;
        i++;
      }
      return i;
      }
    }
