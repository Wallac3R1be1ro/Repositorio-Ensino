public class Jogador {
	/*Uma variavel public pode ser acessada e alterada por diferentes aplicações java,
	diferente da private que é restrita somente a sua aplicação java de origem. Também
	existe a variavel protect, que apenas funciona dentro do mesmo pacote que esteja
	sua aplicação java origem.*/
	private int num=0;
	//public int vidas=0;
	
	public Jogador(int num){
		this.num=num;
		//this.vidas=3;
		System.out.printf("\n Jogador numero %d criado",num);
	}
}
