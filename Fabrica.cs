using System.Collections.Generic;
class Fabrica{

  Estoque  est = new Estoque();
 
  public Produto Criar_Produto(string codigo, string tipo,int tamanho , string descrição,float custo,int quantidade ){
     
    Produto  produto = new Produto(codigo,tipo,tamanho,descrição,custo,quantidade);
     
    est.IncluirProduto(produto);
    return produto;
  }
  public void AssociarEstoque(Estoque e){
    est=e;
  }

  public bool VerificarCodigo(List <Produto> p , string cod){

    List <string> codigos = new List <string>();
    foreach(Produto vc in p){
      codigos.Add(vc.getCodigo());
    }
    if(codigos.IndexOf(cod)!= -1){
      return false;
    }
    return true;
 
  }
}



