using System.Collections.Generic;
using System;

class Estoque{

  public static List<Produto> prods = new List<Produto>();

  public void IncluirProduto(Produto produto){
    prods.Add(produto);
  }

  public void MostrarProduto(){
    for(int i = 0 ; i < prods.Count ; i++){
      Console.WriteLine(prods[i].MostrarNaLista());
    }
  }

  public int  SomarQuantidade(){

    int somaquantidade = 0;

    foreach(Produto p in prods){
      somaquantidade += p.getQuantidade();
    }

    return somaquantidade;
  }

  public float SomarCusto(){

    float  somacusto = 0 ;

    foreach( Produto p in prods){
      somacusto +=p.CustoTotal();
    }

    return somacusto;
  }

  
 
 
 
 
   

}