using Pilhass;

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


        }

    }
}