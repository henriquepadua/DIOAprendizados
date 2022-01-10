using System;
using Interface;

namespace Interface{

enum Pestes{
          Paulo,
          MariaAlice,
          Kiara,
          Juli
}

interface IAnimal{
        void Nome(string nome);
        void Dono(string nomedono);
        void Especie(string especie);

}

class Animal : IAnimal{
           public string nome;
           public string nomedono;
           public string especie;
           
        void IAnimal.Nome(string nome){
             this.nome = nome;
        }

        void IAnimal.Dono(string nomedono){
              this.nomedono = nomedono;
        }        

        void IAnimal.Especie(string especie){
              this.especie = especie;
        }

}
}

class Henrique{

       static void Main(string[] args){
          var peste1 =  (Pestes)3;
              Console.WriteLine(peste1);
                                                          
         }
}
