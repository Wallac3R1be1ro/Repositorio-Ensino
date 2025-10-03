
		// Estruturas de repetição servem para repetir varias vezes uma operação;
		// As estruturas mais comuns são: while e for;
		// Neste tipo de estrtura é importante tomar cuidado com os loops infinitos.
		
		// A ideia do while é que se repita algo até atingir tal condição.
		
		var x = 0;
		
		while(x <= 5) {
		
			console.log("Testando Repetição " + x);
			
			// Incrementador
			x++; // Caso não adicionar este Incrementador o código irá repetir de maneira infinita.
		}
		
		var arr = ['teste', 'testando', 'a', 'b'];
		var y = 0;
		
		while(y <= 3){
		
			console.log(arr[y]);
			
			y++;
		}
		
		var nome = "Matheus";
		var i = 0;
		
		while(i < 6) {
		
			console.log(nome[i]);
			
			i++; // ou i += 1
		}
