using System.IO;
using System.Text;
using System.IO;
using System.Text;

class VenderProd{
  

  private int quantidadeCompra;
  private string email;
  private string nome;
  private string empresa;
  private float valor_desejada;
  
  public  VenderProd(){
    quantidadeCompra = 0; 
    email = "000";
    nome = "0000";
    empresa = "0000";
    valor_desejada = 0;
  }
 
  public VenderProd( int qtc , string e , string n , string ep, float vld){
   
   quantidadeCompra = qtc;
   email = e;
   nome = n;
   empresa = ep;
   valor_desejada = vld;
  
  }
  
  public int getQuantidadeCompra(){
    return quantidadeCompra;
  }
  // metodos set  

  public void setQuantidade(int qt ){
    quantidadeCompra = qt;
  }

  public  string getEmail(){
   return email;
  }

  public void setEmail(string e){
     email = e;
  }

  public string getNome(){
   return nome;
  }

  public float getValorDesejada(){
    return valor_desejada;
  }

  public void setNome(string n ){
    nome = n ;
  }

  public string getEmpresa(){
    return empresa;
  }

  public void setEmpresa(string ep){
    empresa = ep;
  }

  public void setValorDesejado(int vl_desajada){
    valor_desejada = vl_desajada;
  }

  public string MostraCompra(){
    return string.Format("empresa: {0}\n email{1}\n nome: {2} \n a quantidade de produto comprado:{3} \n valor de venda: {4}",empresa,email,nome,quantidadeCompra,valor_desejada);
  }

  public float  CustoCliente(){
     return valor_desejada*quantidadeCompra;
  }

  public void ControleDeVendas(string eml,string ep, string nm, int q,float vl ){

  StreamWriter sw = new StreamWriter("compras.txt", true);

  string str = string.Empty;
  int qtd;
  float vld;


  str = eml;
  sw.WriteLine(("Email: ")+str);
  str = ep;
  sw.WriteLine(("empresa: ")+str);
  str = nm;
  sw.WriteLine(("Nome do cliente: ")+str);
  qtd = q;
  sw.WriteLine(("Quantidade: ")+qtd);
  vld = vl;
  sw.WriteLine(("Valor do Produto: ")+vld);

  sw.Close();

}

  
  
} 