public class MyApp {
    //Array - Exemplo
    /*E um comando que armazena inumeras variaveis de um mesmo 
     *tipo por posicao, para o usuario executar os valores de
     *sua preferencia. Em java os arrays sao objetos, todos os metodos
     *da classe Object podem ser invocados em um array.*/

    //Utilizando for para resultar na sequencia dos valores
    public static void main(String[] args) {
    		
     final int tam=5;
     char[] gabarito={'a','a','d','b','c'};
     char[] respostas=new char[tam];
     int nota=0;
     
     respostas[0]='a';respostas[1]='a';respostas[2]='c';
     respostas[3]='b';respostas[4]='c';
     
     for(int i=0;i<tam;i++){
     	if(respostas[i]==gabarito[i]){
     			nota++;
     		}
     	}
     	System.out.printf("Nota do aluno:%d",nota);
    }
}
