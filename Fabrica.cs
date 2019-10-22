using System.Collections.Generic;
class Fabrica{

  Estoque  est = new Estoque();


   
   
  // aqui usei um metodo para criar um produto, estou usando public Produto para retornar o proprio produto 

  public Produto Criar_Produto(string codigo, string tipo,int tamanho , string descrição,float custo,int quantidade){
    // dentro do parâmetro eu coloquei os atributos que vão receber as informações 

    // aqui estou criando um novo produto com os as informações que o usuario passar 
    Produto  produto = new Produto(codigo,tipo,tamanho,descrição,custo,quantidade);
    // estou retornando o produto
    

    est.IncluirProduto(produto);

    return produto;
   
    
  }
  public void AssociarEstoque(Estoque e){
    est=e;
  }
  


  
}



