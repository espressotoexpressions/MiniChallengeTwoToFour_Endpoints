using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFour_Endpoints.Services
{
    public class AddTwoNumbersService
    {
        public int sum = 0;

        public AddTwoNumbersService(){ 
            // constructor class
            //enter anything here to run first
        } 

        public int AddTwoNumbers(int num1, int num2)
        {
            sum = num1+num2;
            return sum;
        }
    }
}