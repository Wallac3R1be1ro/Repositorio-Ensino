/* 	Tipos de dados: Objetos

-Funcionam como um array associativo de outras linguagens;
-Podemos criar propriedades com chave e valor;
- A ideia é guardar um conjunto de valores para utilizar 
posteriormente;

*/

var obj = {
	nome: "Wallace",
	idade: 19,
	profissao: "Programador",
	estaTrabalhando: false,
};

	console.log(obj);
	console.log(typeof obj);

	console.log(obj.nome);
	console.log(obj.idade);
	console.log(obj.profissao);

	console.log("O meu nome é " + obj.nome);
	
	
// Criando Objetos com métodos

let pessoa = {
	nome: "Matheus",
	idade: 29,
	falar: function() {
		console.log("Olá Mundo!");
	},
	soma: function(a, b) {
		return a + b;
	}
};

console.log(pessoa.nome);

pessoa.falar();

var soma = pessoa.soma(2, 2);
console.log(soma);

