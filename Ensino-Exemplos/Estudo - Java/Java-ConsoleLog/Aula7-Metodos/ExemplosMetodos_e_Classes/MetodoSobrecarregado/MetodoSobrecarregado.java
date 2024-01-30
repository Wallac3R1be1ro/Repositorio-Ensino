class MetodoSobrecarregado{

	public void testaMetodosSobrecarregados()
	{
		System.out.printf("Salário em número inteiro = %d\n", salario(700));
		System.out.printf("Salário em número double = %f\n", salario(7.500));
	}

	public int salario(int valorInt)
	{
		System.out.printf("\n Salário com argumento de inteiro = %d\n", valorInt);
		return valorInt * valorInt;
	}

	public double salario( double valorDouble)
	{
		System.out.printf("\n Salário chamado com argumento de double = %f\n", valorDouble);
		return valorDouble * valorDouble;
	}
}

public class Test_Metodos_Sobrecarregados {

	public static void main(String[] args) {

		MetodoSobrecarregado testaM = new MetodoSobrecarregado();
		testaM.testaMetodosSobrecarregados();
	}
}
