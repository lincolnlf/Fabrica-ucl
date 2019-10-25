class VenderProd{
  
  

  private int quantidadeCompra;
  private string email;
  private string nome;
  private string empresa;
  



  public  VenderProd(){
    quantidadeCompra = 0; 
    email = "000";
    nome = "0000";
    empresa = "0000";
  }
 
  public VenderProd( int qtc , string e , string n , string ep ){
   
   quantidadeCompra = qtc;
   email = e;
   nome = n;
   empresa = ep;
  
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

  public void setNome(string n ){
    nome = n ;
  }

  public string getEmpresa(){
    return empresa;
  }

  public void setEmpresa(string ep){
    empresa = ep;
  }

  public string MostraCompra(){
    return string.Format("empresa: {0}\n email{1}\n nome: {2} \n a quantidade de produto comprado:{3}",empresa,email,nome,quantidadeCompra);
  }

  
  
} 