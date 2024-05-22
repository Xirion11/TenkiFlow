using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Systems
{
    public static class Extensions
    {
        private static System.Random _rng = new System.Random();  
        
        public static void Shuffle<T>(this IList<T> list)  
        {  
            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = _rng.Next(n + 1);  
                (list[k], list[n]) = (list[n], list[k]);
            }  
        }
    }
}
