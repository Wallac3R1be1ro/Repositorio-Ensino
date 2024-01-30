class Soma{
	
	public static int resultado(int num1, int num2){
		return (num1 + num2);
	}
}

public class TesteSomaEstatica {
	
	public static void main(String[] args) {
		System.out.println(Soma.resultado(10,50));
	}
}