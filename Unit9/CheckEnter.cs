using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9
{
    class CheckEnter
    {
        public delegate void MethodContainer(ref string[] arrstr, int MetodSort);
        public event MethodContainer onEnter;
      //  MyExeption Exept = new MyExeption();


        public void checkEnter(ref string[] arrstr, string EnterMes)
        {
            int iEnter;

            try
            {
                iEnter = int.Parse(EnterMes);
                if (iEnter > 0 && iEnter < 3)
                {
                    onEnter(ref arrstr, iEnter);
                }
                else
                {
                    throw new MyExeption("EnterExeptionNumber");
                    
                }

            }
           

            catch (FormatException)
            {
                throw new MyExeption("EnterExeptionSimbol");
               
            }

           
            if (arrstr == null)
            {
                throw new MyExeption("ExeptionNullArr");
                
            }

                        
        }

    }
}
