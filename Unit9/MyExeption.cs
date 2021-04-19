using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9
{
    public class MyExeption : Exception
    {
        public MyExeption(string message) : base(message)
        {
            if (message == "EnterExeptionNumber")
            {
                sMessage = "Вы ввели не допустимое числовое значение!";
            }

            if (message == "EnterExeptionSimbol")
            {
                sMessage = "Вы ввели символ отличный от числа!";
            }


            if (message == "ExeptionNullArr")
            {
                sMessage = "Не задан массив для сортировки!";
            }
        }

        private string sMessage;

        public string sMessageRet { get { return sMessage;} }


        public MyExeption() 
        { }
        
    }
}
