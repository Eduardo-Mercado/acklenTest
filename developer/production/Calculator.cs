using System;
using System.Linq;

namespace production
{
    public class Calculator
    {
        public int Sum(string value) {
            if(value ==  null ||  value.Length == 0)
              return 0;
             
            int position = value.IndexOf('\n');
            char customDelimeter = value.ToArray()[position-1];

          var numbers = value.Split(new char[] {',', '\n',customDelimeter} )
                .Select((element) => int.Parse(element))
                .ToArray();

            return numbers.Sum();
             
        }

      
    }
}
