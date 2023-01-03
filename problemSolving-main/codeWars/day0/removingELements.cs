Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

Example:
["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]

None of the arrays will be empty, so you don't have to worry about that!


using System;
using System.Linq;
using System.Collections.Generic;
  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
        
//           var list = new List<object>();
        
//           for(int i= 0; i< arr.Length;i+=2){
//             list.Add(arr[i]);
//           }
//           return list.ToArray();
          
          return arr.Where((x,y) => y%2 == 0).ToArray();
          
        }
    }