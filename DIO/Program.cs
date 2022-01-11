using Pilhass;
using Interface;
namespace Programs
{
    class Program
    {

        static void Main(string[] args)
        {
            Pilha chaps = new Pilha();

            chaps.Empilha(1);
            chaps.Empilha(2);
            chaps.Empilha(3);
            chaps.Empilha(4);
            Console.WriteLine(chaps.Desempilha());
            Console.WriteLine(chaps.Desempilha());
            Console.WriteLine(chaps.Desempilha());
            Console.WriteLine(chaps.Desempilha());

            var peste1 =  (Pestes)1;
    
          Console.WriteLine(peste1);
                                                         
         }


        }

    }
