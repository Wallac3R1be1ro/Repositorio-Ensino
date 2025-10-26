// indexOf
	var arr = [1,2,3,4,5];
	const alunos = ['William', 'Maria', 'Vinicius']
	console.log(arr.indexOf(5));
	
	// Join
	var arr2 = ["O", "Rato", "roeu", "a", "roupa"];
	console.log(arr2.join(" "));
	
	// reverse
	console.log(arr2.reverse());

	// Exibindo valor de maneira individual
	console.log(alunos.slice(2));


	// Const e Array
	/*Já quando usamos const com valores mutáveis (como arrays e objetos),
	 a variável continua sendo constante, porém os valores dentro do objeto
	  poderão ser alterados. */
	
	const array = [1, 2, 3, 4, 5];
	array.pop();
	array[0] = 1024;
	console.log(array); // [ 1024, 2, 3, 4 ]
