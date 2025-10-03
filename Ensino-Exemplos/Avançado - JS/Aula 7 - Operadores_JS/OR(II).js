
		/*O Operador lógico || é conhecido também como OR-->
		<!--Ele retorna true caso uma das operações retorne verdadeiro-->
		<!--O OR retorna false apenas se as duas expressões são falsas*/
		
		var idade = 14;
		var nome = "João";
		
		if(nome == "João" || idade > 14 ) {
			console.log("Pode entrar na aula");
		} else {
			console.log("Não pode entrar");
		}
		
		if(nome == "João" && (30 > 20 || 10 == 10)) {
			console.log("Entrando");
		} else {
			console.log("Não entrou");
		}
