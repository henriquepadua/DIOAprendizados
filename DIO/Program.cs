using Pilhass;
using Interface;
using Chaps;
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

            var peste1 = (Pestes)1;

            Console.WriteLine(peste1);

            Estudante n1 = new Estudante();

            n1.nome = "chaps";
            n1.idade = 34;
            n1.nota = 5;
            n1.Poisnao();

            Uber n2= new Uber();

            n2.idade = 34;
            n2.nota = 5;
            n2.Poisnao();

           Corrente nota = new Corrente();

            nota.Dim(14);
            nota.GastarDim();

            Filehelper helper = new Filehelper();
                  var caminho = ("C:\\Arquivos");
                  var andarcaminho = (Path.Combine(caminho, "oi.txt"));
                 var billijeans = new List<string>{"linha 1","linha 2","linha 3"};
                 var billijow = new List<string>{"linha 4","linha 5","linha 6"};
                 var novo = (Path.Combine(caminho,"teste2","oi.txt"));
                var teste = (Path.Combine(caminho,"oi.txt"));
                var novocaminho = (Path.Combine(caminho,"oi-o.txt"));

//            helper.ListarDiretorios("C:\\Arquivos");
//            helper.ListarArquivos("C:\\Arquivos"); 
//              helper.CriarDiretorio(Path.Combine("C:\\Arquivos", "Oloco meu.txt"));
//              helper.SumirDiretorio("C:\\Arquivos\\Oloco meu.txt");
//               helper.Criararquivotexto(andarcaminho,"ola mundo");
//                helper.Criararquivostream(andarcaminho,billijeans);
//                helper.Adicionararquivostream(andarcaminho,billijow);
//                  helper.LerArquivoStream(andarcaminho);
//                 helper.Mover(novo,novocaminho,false);

                  helper.Deletar(novocaminho);


        }


    }

}
