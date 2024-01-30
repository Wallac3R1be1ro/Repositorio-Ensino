
public class MyApp1{
// Está aplicação (MyApp1) está acessando uma variável publica de outra aplicação java (Jogador)
	public static void main(String[] args){
		
		int num=0;
		
		Jogador j1 = new Jogador(++num);
		Jogador j2 = new Jogador(++num);
		Jogador j3 = new Jogador(++num);
		
		//j1.vidas=100;
	}
}