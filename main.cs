using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    int opcao = 0 ;
    int senha = 0 ;

    Fabrica fabrica = new Fabrica();

    Estoque est = new Estoque();
    fabrica.AssociarEstoque(est);
    
     
    

    Console.WriteLine("Digite a senha para entrar no Sistema:");
    senha =int.Parse(Console.ReadLine());

    if( senha != 1234){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(" senha invalida!!!\n Não é possivel entrar no sistema.");
    }
  
    while (opcao == 1 || senha == 1234 || opcao == 2 || opcao == 3){

    Console.WriteLine(" Digite 4 para sair:");
  
    Console.WriteLine(" Digite 1 para fabricar um produto:\n Digite 2 para entrar no sistema de estoque:\n Digite 3 para pedir produto do estoque:");
    opcao =int.Parse(Console.ReadLine());
   
    if (opcao == 1 ){
    Console.WriteLine("Digite o codigo do produto para ser fabricado: ");
    string codigo = Console.ReadLine();

    Console.WriteLine("Digite o tipo do produto para ser fabricado: ");
    string tipo = Console.ReadLine();

    Console.WriteLine("Digite o tamanho em número:");
    int tamanho = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descrição do produto: ");
    string descrição = Console.ReadLine();


    Console.WriteLine("Digite o custo de cada produto para ser fabricado: ");
    float custo = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade:");
    int quantidade = int.Parse(Console.ReadLine());

    Console.WriteLine("Valor desejado para venda:");
    int valor_desejada = int.Parse(Console.ReadLine());




    Produto produto = fabrica.Criar_Produto(codigo,tipo,tamanho,descrição,custo,quantidade,valor_desejada);
     
    Console.WriteLine(produto.ResumoDados());

    }  
    if (opcao == 2){
      int op = 0;

      Console.WriteLine("Digite a opção para analisar o estoque:");
      Console.WriteLine();

      Console.WriteLine(" opção 1 = analisar todos os produtos em estoque:\n opção 2 = analisar a quantidade total de produtos em estoque: \n opção 3 =  analisar custo total em estoque: ");
       op = int.Parse(Console.ReadLine());

      if (op == 1){
        Console.WriteLine("========================");
        est.MostrarProduto();
        Console.WriteLine("========================");

      }

      if(op == 2){
        Console.WriteLine("O total de produtos em estoque: {0} ",est.SomarQuantidade());
      }

      if (op == 3){
        Console.WriteLine("O valor total em estoque: R${0}",est.SomarCusto());
      }

    }

    if ( opcao == 3 ){
      est.MostrarProduto();

    
    Console.WriteLine("Buscar no estoque por codigo:");
    string dadoCodigo = Console.ReadLine();
    est.BuscarEstoque(dadoCodigo);

    Console.WriteLine("Digite as informação para compra:");  

    Console.WriteLine(" digite a quantidade de produtos para venda:");
    int quantidadeCompra = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o nome do cliente:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o email do cliente:");
    string email = Console.ReadLine();

    Console.WriteLine("Digite o nome da empresa:");
    string empresa = Console.ReadLine();

    VenderProd venderproduto = new VenderProd(quantidadeCompra, nome , email, empresa);

    




       

    }  
    
    if (opcao == 4){
      break;
    }
    
    Console.WriteLine("Vamos limpar a tela aperte enter:");
    
    Console.ReadLine();
      Console.Clear();     
     
  }

  }

}
  
 
