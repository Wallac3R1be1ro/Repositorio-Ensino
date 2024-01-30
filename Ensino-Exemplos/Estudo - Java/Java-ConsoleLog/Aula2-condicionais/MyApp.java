public class MyApp {

    public static void main(String[] args) {
        int nota=5;
        int media=10;
        int pos=3;
        String res;
        //Tabela verdade AND &&
        /*
            V V = V
            V F = F
            F V = F
            F F = F
        */
        //Tabela verdade OR ||
        /*
            V V = V
            V F = V
            F V = V
            F F = F
        */
        /*Operação de condicional ternária*/
        res = (nota >= media ? "Aprovado" : "Reprovado");
        System.out.println("Resultado: " + res);
        /*Operação de condicional Switch*/
        switch(pos){
            case 1:
                System.out.println("É o numero 1?");
                break;
            case 2:
                System.out.println("É o numero 2?");
                break;
            case 3:
                System.out.println("É o numero 3?");
                break;
            default:
                System.out.println("Não consegui saber qual é o numero!");
                break;
        }
        /*Operação de condicional if e else*/
        if(nota >= media){
            System.out.println("Aprovado");
            }else if (nota >=6){
                System.out.println("Recuperacao");
            }else{
                System.out.println("Reprovado");
            }
            System.out.println("Fim");
   }
    
}
