public class MyAppSet{
	/*Dentro do método, colocamos o atributo da classe
	recebendo o valor recebido como parâmetro.*/
	public void setNomeProduto(String nomeproduto) {
		this.nomeproduto=nomeproduto;
	}
	public void setQuantidade(int quantidade) {
		this.quantidade = quantidade;
	}
	public void setValorUnitario (String valorunitario) {
		this.valorunitario = valorunitario;
	}
	/*A utilização da cláusula THIS faz referência ao atributo
	da classe dentro da qual se está trabalhando*/
}