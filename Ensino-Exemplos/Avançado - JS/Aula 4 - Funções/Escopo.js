/*No JavaScript podemos ter vários escopos:
O global, que é iniciado em toda a aplicação, e os locais,
que podem existir em várias instruções como as funções;*/
		
		//Variaveis livres de dependências são Globais
		var x = 1;
		var y = 3;
		
		console.log(x, y);
		
		//Variaveis dentro de função são Locais
		function teste() {
		
			var z = 0;
			console.log(z);
			console.log(x);
		}
		
		teste();
		
		function testando(){
			var z = 5;
			
			console.log(z);
		}
		
		testando();
		
		if(true) {
			var p = 1;
		}
		
		console.log(p);