public class executaMyAppCarros{
	public static void main(String[] args){
		
		MyAppCarros c1 = new MyAppCarros("Fusca");
		MyAppCarros c2 = new MyAppCarros("Fusca Branco");
		MyAppCarrosHeranca c3 = new MyAppCarrosHeranca("Fusca de Aço", 100);
		MyAppCarrosHeranca c4 = new MyAppCarrosHeranca("Fusca de Madeira",10);
		
		//c1.setligado(true);
		c1.info();
		c2.info();
		c3.info();
		c4.info();
	}
}