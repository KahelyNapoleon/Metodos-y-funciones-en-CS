using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Ingrese dos valores");
         double n1, n2;
         n1 = Convert.ToDouble(Console.ReadLine());
         n2 = Convert.ToDouble(Console.ReadLine());

         Calculadora(n1,n2);

        }


        public static void Calculadora(double num1, double num2)
        {
          int opcion;
          do 
          {
          Console.WriteLine(); 
          Console.WriteLine("Elije una opcion: ");
          Opciones();
          opcion = Convert.ToInt32(Console.ReadLine());
          
          switch(opcion)
          {
            case 1:
            Console.WriteLine("Suma = " + sumaLocal(num1,num2));
            break;
            case 2:
            Console.WriteLine("Resta = " + restaLocal(num1, num2));
            break;
            case 3:
            Console.WriteLine("Multiplicacion = " + multiLocal(num1, num2));
            break;
            case 4:
            Console.WriteLine("Division = " + diviLocal(num1, num2));
            break;
            default:
            break;
          }

          double sumaLocal(double num1, double num2)
          {
            return num1 + num2;
          }

          double restaLocal(double num1, double num2)
          {
            return num1 - num2;
          }

          double multiLocal(double num1, double num2)
          {
            return num1 * num2;
          }
          double diviLocal(double num1, double num2)
          {
            return num1 / num2;
          }

          void Opciones()
          {
            
            Console.WriteLine("Menu: ");
            Console.WriteLine("1- Sumar");
            Console.WriteLine("2- Restar");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5- Exit"); 
           


          }

          }while(opcion != 5);

        }

        


    }


 
         
}
    
