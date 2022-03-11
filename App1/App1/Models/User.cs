using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class User
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
    }

    public class Mathematics
    {
        public void Divide()
        {
            int a = 1;
            int b = 0;
            var result =  a / b;
        }

        public void DivideWithHandledException()
        {
            int a = 1;
            int b = 0;
            try
            {
                var result = a / b;
            }
            catch (DivideByZeroException ex)
            {

            }
            catch (OverflowException ex)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {

            }
            //the code will will not be executed if exception throw;
            Console.Write("End");
            
        }

        public class YourOwnException : Exception
        {

        }
    }
}
