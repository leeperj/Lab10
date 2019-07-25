using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    public class Validator
    {
        
            
            
            public Validator()
            {

            }
            public static bool Double(string input)
            {
            return double.TryParse(input, out double input2);
            }
      
        }
        
    }

