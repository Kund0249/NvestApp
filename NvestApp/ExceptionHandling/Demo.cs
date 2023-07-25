using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ExceptionHandling
{
    class Demo
    {
        static void Main(string[] args)
        {

            try
            {
                //open the connection with resources
                Console.Write("Enter N1 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter N2 : ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                    throw new CustomException("NV01","Value must be greater than Zero");

                int c = a / b;
                Console.WriteLine("Result : " + c);

                //close the connection
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("a number can not be divided by zero.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please Enter a Intefer Value");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Enter Value less than or equal to " + int.MaxValue);
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Status Code : " + ex.StatusCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine("System can  not process this request, kindly contact to admin");
            }

            finally
            {
                Console.WriteLine("Program End!");
            }
        }
    }
}
