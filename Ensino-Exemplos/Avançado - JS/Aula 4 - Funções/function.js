			/*
			Funções são blocos de código reutilizáveis;
			Ou seja, evitamos a repetição da lógica de um programa em diversas
			partes do código;
			*/
			
			function MinhaFuncao() {
				console.log("Hello World das funções");
			}
			
			// Chamando função existente
			MinhaFuncao();
			
			function dizerNome(nome){
				console.log("O nome é: " + nome);
			}
			
			dizerNome("Matheus");
			dizerNome("Pedro");
			dizerNome("Xavier");
			
			function soma(a, b) {
				var soma = a + b;
				return soma;
			}
			
			var somaUm = soma(2,5);
			console.log(somaUm);
			var somaDois = soma(5, 5);
			console.log(somaDois);
			console.log(soma(4, 5));

			// Outros exemplos de declaração de funções
			function novasoma(x, y) {
				const resultado = x + y;
				return resultado;
			}
			const resultado = novasoma(4, 4);
			console.log(resultado);
			// -------------------------------------------------
			function novadivisao(x = 5, y = 2) {
				const novoresultado = x / y;
				return novoresultado;
			}
			const novoresultado = novadivisao();
			console.log(novoresultado);
			// -------------------------------------------------
			// Utilizando ArrowFunction, com a lógic de determinar a raiz de um número
			const raiz = function(n) {
				return n ** 0.5;
			};

			console.log(raiz(9));
			console.log(raiz(10));
			console.log(raiz(30));

			// Inserindo dados na function
			function criaPessoa (nome, sobrenome, idade){
				return {nome, sobrenome, idade};
			}

			const pessoa = criaPessoa('Wallace', 'Ribeiro', 22);
			console.log(pessoa.nome);