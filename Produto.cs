using System.Collections.Generic;
class Produto{
  // ATRIBUTOS  
  private  string codigo;
  private string tipo;
  private int tamanho;
  private string descrição;
  private  float  custo;
  private  int quantidade;
  private float valor_desejada;

  public float CustoTotal(){
    return custo*quantidade;
  }

  public Produto(){
    codigo = "000";
    tipo = "000";
    tamanho = 00;
    descrição = "000";
    custo = 000;
    quantidade = 00;
    valor_desejada = 0;
  }

   public Produto(string c, string t , int tm , string d,float  cp, int q ,  float vl_desajada){
    codigo = c;
    tipo  = t; 
    tamanho = tm;
    descrição = d;  
    custo = cp;
    quantidade = q;
    valor_desejada = vl_desajada;

  }
  // metodos get 
  public string getCodigo(){
    return codigo;
  }  

  public string getTipo(){
    return tipo;
  }

  public int getTamanho(){
    return tamanho;
  }

  public string getDescrição(){
    return descrição;
  }

  public float getCusto(){
    return custo;
  }

  public int getQuantidade(){
    return quantidade; 
  }

  public float getValorDesejada(){
    return valor_desejada;
  }

  // metodos set 
  public void setCodigo(string c){
    codigo = c;
  }

  public void setTipo(string t){
    tipo = t;    
  }

  public void setTamanho( int tm ){
    tamanho = tm;
  }
  
  public void setDescrição( string  d ){
    descrição = d;
  }

  public void setCusto(float c){
    custo = c;
  }

  public void setQuatindade(int q){
    quantidade = q ;
  }

  public void setValorDesejado(int vl_desajada){
    valor_desejada = vl_desajada;
  }
  
  public string ResumoDados(){
    return string.Format(" codigo do produto: {0} \n tipo: {1}\n valor de custo desse cada produto: {2} \n quantidade fabricada: {3}\n custo total para fabricar essa(s) peça(s): R$:{4} \n tamanho do produto: {5}\n descrição do produto {6} \n valor desejado para venda:{7}",codigo,tipo,custo,quantidade, CustoTotal(),tamanho,descrição,valor_desejada);
  }

  public string MostrarNaLista(){
    return string.Format(" codigo:{0}\n descrição: {1}\n valor do produto: {2}\n quantidade feita: {3}\n tamanho:  {4} \n descrição {5} \n valor desejado para venda:{6} \n================",codigo,tipo,custo,quantidade,tamanho,descrição,valor_desejada);
  }

  
  
}
  