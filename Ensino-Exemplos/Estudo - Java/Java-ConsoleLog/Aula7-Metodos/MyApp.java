
import java.nio.charset.StandardCharsets; 
public class MyApp {
	/*Um metodo e um bloco de codigo ou colecao de instrucoes
	 *ou um conjunto de codigos agrupados para executar uma
	 *determinada tarefa ou operacao.*/
    //Isto e um metodo abaixo
    public static void main(String[] args) {
    	//Caso a string m nao seja ativada no metodo principal ela nao ira aparecer
    	msg("Chamando a string m para ativa-la no metodo principal");
    	//variavel soma sendo ativada no metodo principal
    	System.out.println(soma(5,10,3));
    }
    //Isto e um metodo abaixo
    public static void msg(String m){
    	System.out.println(m);
    }
    //Isto e um metodo abaixo
    public static int soma(int... numeros){
    	int res=0;
    	for(int n:numeros){
    		res+=n;
    	}
    	return res;
    }
}
