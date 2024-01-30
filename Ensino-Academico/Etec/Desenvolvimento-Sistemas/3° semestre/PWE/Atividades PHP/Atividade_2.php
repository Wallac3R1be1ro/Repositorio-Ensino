<?php 
    //João Pedro Thomaz S. Oliveira Nº17 e Joyce Maria de Souza Barbosa Nº21
    
    //Atividade 2

    echo "Atividade 2". '<br>'.'<br>';
    
    for ($k=1; $k<= 10; $k++) {         

        $Var = (120 / $k);
        
        (double) $Var = number_format($Var, 2, '.', '');
        
        echo 'A multiplicação dos números : '. $Var. ' e ' . $k . ' é 120' .'<br>'.'<br>';
    }
    
    echo "Desenvolvido por João Pedro Thomaz S. Oliveira Nº17 e Joyce Maria de Souza Barbosa Nº21 ©";
?>