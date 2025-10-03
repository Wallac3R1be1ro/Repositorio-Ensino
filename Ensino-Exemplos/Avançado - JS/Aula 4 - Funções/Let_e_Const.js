
		//let é um recurso que possibilita seu uso de escopo global em blocos;
		let x; // essa função é a mesma coisa que var x = 0;
		const y = 50;
		
		x = 12;
		
		console.log(x);
		
		console.log(x + y);
		
		/*const pode ser considerada como uma variável, porém necessita que seu valor já seja atribuído no momento de sua declaração,
		e não pode ser alterada posteriormente, ou seja, é uma constante.
		*/
		
		const nome = 'Luiz Otávio';
		const sobrenome = 'Miranda';
		const idade = 30;
		const peso = 84;
		const alturaEmCm = 1.80;

		console.log(nome, sobrenome, 'tem', idade, 'anos, pesa', peso, 'kg');
		console.log('tem', alturaEmCm, 'de altura e seu IMC é de', (peso / (alturaEmCm * alturaEmCm)));
		console.log(nome, 'nasceu em', 2024 - idade);

		// Utilizando o template strings (crase ``)
		// Maneira mais moderna de escrever strings, sem a necessidade de usar vírgulas ou o operador +
		// Utiliza-se ${} para inserir variáveis ou expressões dentro da string
		// Exemplo:
		console.log(`${nome} ${sobrenome} tem ${idade} anos, pesa ${peso} kg`);
		console.log(`tem ${alturaEmCm} de altura e seu IMC é de ${peso / (alturaEmCm * alturaEmCm)}`);
		console.log(`${nome} nasceu em ${2024 - idade}`);
		