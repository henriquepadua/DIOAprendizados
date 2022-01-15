using System;


namespace Chaps{

public class Filehelper{

     public void ListarDiretorios(string caminhos){

          var retornoCaminhos = Directory.GetDirectories(caminhos, "*",SearchOption.AllDirectories);

           foreach(var retornar in retornoCaminhos){
                Console.WriteLine(retornar);
           }
}

     public void ListarArquivos(string caminhos){
          var retornoArquivos = Directory.GetFiles(caminhos, "*",SearchOption.AllDirectories);

           foreach(var retornar in retornoArquivos){
               Console.WriteLine(retornar);
           }
      }

     public void CriarDiretorio(string caminho){
     
         var retorno =  Directory.CreateDirectory(caminho);
             Console.WriteLine(retorno.FullName);
       }

     public void SumirDiretorio (string caminho){
           
           Directory.Delete(caminho);
    }

    public void Criararquivotexto(string caminho,string conteudo){
        if(!File.Exists(caminho)){
          File.WriteAllText(caminho,conteudo);
        }
   }
    
     public void Criararquivostream(string caminho, List<string> conteudo)    {
      using (var stream =  File.CreateText(caminho))
      {

       foreach(var linha in conteudo){
           stream.WriteLine(linha);
        }
      }
    }

    public void Adicionar(string caminho,string conteudo){

       File.AppendAllText(caminho,conteudo);
    }	

    public void Adicionararquivostream(string caminho, List<string> conteudo)    {
      using (var stream =  File.AppendText(caminho))
      {

       foreach(var linha in conteudo){
           stream.WriteLine(linha);
        }
      }
    }

     public void LerArquivo(string caminhos){
          var contem = File.ReadAllLines(caminhos);
 
         foreach(var retorno in contem){
             Console.WriteLine(retorno);
        }
    }

    public void LerArquivoStream(string caminho){
          string contem = string.Empty;

          using (var stream = File.OpenText(caminho))
          {
            while((contem = stream.ReadLine()) != null){
               Console.WriteLine(contem);
            }
 
          } 
   }

   public void Mover(string caminho,string caminho2,bool sobrescrever){
           File.Move(caminho,caminho2,sobrescrever);
   }

   public void Copiar(string caminho,string copia,bool sobrescrever){
           File.Copy(caminho,copia,sobrescrever);
   }

   public void Deletar(string caminho){
         File.Delete(caminho);
   }

}
}
