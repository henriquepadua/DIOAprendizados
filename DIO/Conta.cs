using System;

public abstract class Conta{

           public int dim;

           public int bufunfa;

           public abstract void Dim(int bufunfa);
 
           public void GastarDim(){
               int dim;
	dim = int. Parse(Console. ReadLine());
                 for(int i = dim; i > 1; i--){
                   Console.WriteLine(i);
                 }
           }

          

}