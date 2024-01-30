import java.util.Scanner;
public class MyAppCalc{
	public static void main(String[] args){
		Scanner scan = new Scanner(System.in);
		int n1=0,n2=0,soma=0,divi=0,mult=0,subt=0,resto=0;
		
		System.out.println("Calculadora");
		System.out.println("-----------");
		System.out.print("Informe o valor 1: ");
		n1=scan.nextInt();
		System.out.print("Informe o valor 2: ");
		n2=scan.nextInt();
		soma=n1+n2;
		divi=n1/n2;
		mult=n1*n2;
		subt=n1-n2;
		resto=n1%n2;
		System.out.println("-----------");
		System.out.println("Resultado da conta");
		System.out.printf("Soma:%d",soma);
		System.out.println();
		System.out.printf("Divisao:%d",divi);
		System.out.println();
		System.out.printf("Multiplicação:%d",mult);
		System.out.println();
		System.out.printf("Subtração:%d",subt);
		System.out.println();
		System.out.printf("Resto:%d",resto);
	}
}