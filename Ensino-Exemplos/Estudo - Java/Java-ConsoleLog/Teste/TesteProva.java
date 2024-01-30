import java.util.Scanner;
public class TesteProva{
	
	public static void main(String[] args){
		Scanner scan = new Scanner(System.in);
		
		//int p1=2,p2=2,p3=2,p4=2,p5=2,soma=0;
		String p1="c",p2="b",p3="a",p4="b",p5="c";
		
		System.out.println("---------------------------------");
		System.out.println("Prova de História");
		System.out.println("---------------------------------");
		
		System.out.println("(1)Qual foi o nome da primeira escrita feita pelo homem?");
		System.out.println("(A) Hebraico");
		System.out.println("(B) Latim");
		System.out.println("(C) Cuneiforme");
		System.out.println("Digite a resposta: ");
		p1=scan.nextLine();
		
		System.out.println("(2)Qual desses impérios conquistaram o Antigo Egito em seu fim?");
		System.out.println("(A) Grécia");
		System.out.println("(B) Roma");
		System.out.println("(C) Caldeus");
		System.out.println("Digite a resposta: ");
		p2=scan.nextLine();
		
		System.out.println("(3)Qual é o nome do rio situado na região da mesopotamia?");
		System.out.println("(A) Rio Tigres e Eufrates");
		System.out.println("(B) Rio Nilo");
		System.out.println("(C) Rio do Congo");
		System.out.println("Digite a resposta: ");
		p3=scan.nextLine();
		
		System.out.println("(4)Quais eram as caractéristica dos povos humanos no Neolitico?");
		System.out.println("(A) Viviam em aldeias e em castelos");
		System.out.println("(B) Eram nômades, caçavam e coletavam alimentos");
		System.out.println("(C) Eram nômades, e viviam e caçavam na região americana");
		System.out.println("Digite a resposta: ");
		p4=scan.nextLine();
		
		System.out.println("(5)Qual região se nomeava Novo Mundo aos colonizadores da época colonial?");
		System.out.println("(A) Região Australiana");
		System.out.println("(B) Região Antartida");
		System.out.println("(C) Região Brasilira");
		System.out.println("Digite a resposta: ");
		p5=scan.nextLine();
		
		//soma=p1+p2+p3+p4+p5;
		System.out.println("Resposta da Questão 1");
		switch(p1){
            case "a":
                System.out.println("(A) ERRADA");
                break;
            case "b":
                System.out.println("(B) ERRADA");
                break;
            case "c":
                System.out.println("(C) CERTA");
                break;
            default:
                System.out.println("este valor não é uma resposta!");
                break;
        }
		
		System.out.println("Resposta da Questão 2");
		switch(p2){
			case "a":
				System.out.println("(A) ERRADA");
				break;
			case "b":
				System.out.println("(B) CERTA");
				break;
			case "c":
				System.out.println("(C) ERRADA");
				break;
			default:
				System.out.println("este valor não é uma resposta!");
				break;		
		}
		
		System.out.println("Resposta da Questão 3");
		switch(p3){
			case "a":
				System.out.println("(A) CERTA");
				break;
			case "b":
				System.out.println("(B) ERRADA");
				break;
			case "c":
				System.out.println("(C) ERRADA");
				break;
			default:
				System.out.println("este valor não é uma resposta!");
				break;		
		}
		
		System.out.println("Resposta da Questão 4");
		switch(p4){
			case "a":
				System.out.println("(A) ERRADA");
				break;
			case "b":
				System.out.println("(B) CERTA");
				break;
			case "c":
				System.out.println("(C) ERRADA");
				break;
			default:
				System.out.println("este valor não é uma resposta!");
				break;		
		}
		
		System.out.println("Resposta da Questão 5");
		switch(p5){
			case "a":
				System.out.println("(A) ERRADA");
				break;
			case "b":
				System.out.println("(B) ERRADA");
				break;
			case "c":
				System.out.println("(C) CERTA");
				System.out.println("Parabéns você acertou todas as questões!");
				break;
			default:
				System.out.println("este valor não é uma resposta!");
				break;		
		}
	}
}