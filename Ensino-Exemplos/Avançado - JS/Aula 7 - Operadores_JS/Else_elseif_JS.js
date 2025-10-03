
		/*Caso a instrução de if seja negativa, podemos adicionar else,
		que será a outra condição a ser executada;
		
		Já o else if tem a possibilidade de fazer outra vericação e
		adicionar mais um bloco de código.
		*/
		
		var nome = "Wallace";
		
		if(nome == "Pedro"){
			console.log("O nome dele é Pedro");
		} else if(nome == "Wallace"){
			console.log("O nome dele é Wallace");
		} else {
			console.log("Ele possui outro nome!");
		}
		
		/*--------------------------------------------------------------*/
		
		var idade = 19;
		
		if(idade > 20){
			console.log("Ele pode entrar na festa!");
		}else if(idade >= 18) {
			console.log("Ele não é autorizado");
		}
