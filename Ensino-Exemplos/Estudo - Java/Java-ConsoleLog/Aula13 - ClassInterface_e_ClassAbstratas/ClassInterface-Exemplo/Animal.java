public class Animal implements SerVivo{
	
	private Boolean vivo;
	
	public Animal(){
		this.vivo=true;
	}
	public void mover(){}
	public void comer(int massa){}
	public void info(){
		System.out.printf("Vivo:%s%n",this.vivo ? "Sim" : "Nao");
	}
}