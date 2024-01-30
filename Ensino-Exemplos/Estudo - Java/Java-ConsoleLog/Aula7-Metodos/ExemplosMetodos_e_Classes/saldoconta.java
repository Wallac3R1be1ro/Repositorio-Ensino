/*public class saldoconta{
	
	private Double saldo;
	
	public void setSaldo(Double saldo) {
		this.saldo = saldo;
	}
	public Double getSaldo() {
		return saldo;
	}
	public void depositar(Double valor){
		saldo += valor;
	}
	public void verificaSaldo(){
		System.out.println("Valor do Saldo: "+getSaldo());
	}
}	
/*No exemplo abaixo usamos uma variável que contém uma referência a
um objeto, sequido por um ponto (.) que faz a invocação de todos os
métodos e variáveis públicas.*/


public static void main(String[] args){
	
	//INSTANCIA A CLASSE
	saldoconta conta = new saldoconta();
	
	//DEFINE UM VALOR DE SALDO
	conta.setSaldo(633.00);
	
	//DEFINE VALOR PARA DEPOSITAR
	conta.depositar(555.0);
	
	//RESGATA VALOR
	conta.verificaSaldo();
}

