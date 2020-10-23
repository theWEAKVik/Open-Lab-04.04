using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
          string vzatvorke = "(" + numbers[0] + numbers[1] + numbers[2] +")";
            string predpomlckou =  "" + numbers[3] + numbers[4] + numbers[5] ;
            string zapomlckou = "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            string cele = "" + vzatvorke + " " + predpomlckou + zapomlckou + "";
            return cele;
        }
       
    }
}
