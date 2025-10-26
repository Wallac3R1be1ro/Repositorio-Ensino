
/*Os dados number possuem as seguintes categorias: NaN, +infinity, -infinity*/
/*Um dado number pode ser definido no jS assim:*/

let numerocomum = 2;
let numerofloat = 2.55;
console.log(numerocomum + numerofloat);

console.log(numerocomum.toString() + numerofloat); // Realizando a mesma operação, porém definindo o number para ser exibido como string

/*Também pode ser definido como string um número, porém ele apenas será usado
como string, somar um number com uma string mesmo tendo um número não é
possível, ambos os valores são diferentes*/

const num1 = 10.1122344556;
console.log(num1.toFixed(2)) // Arredondando valor grande, exemplo: 10.1122344556, será: 10.11

// Como saber se um valor de uma variável é um numero inteiro ou ponto flutuante?

let numsecreto = 10;
console.log(Number.isInteger(numsecreto)); // Irá retornar verdadeiro ou falso

// Objeto Math

let numPrimeiro = 9.4567
let numSegundo = Math.floor(numPrimeiro);
console.log(numSegundo); // Valor será arredondado para baixo

let numterceiro = 9.4567
let numquarto = Math.ceil(numterceiro);
console.log(numquarto); // Valor será arredondado para cima

// Qual maior número? Para saber, use Math.max
console.log(Math.max(20, 26, 60, 80));
// Qual menor número? Para saber, use Math.min
console.log(Math.min(0, 12, 80, 1));

// Gerando números aleatórios
const aleatorio = Math.round(Math.random() * (10-5) + 5);
console.log(aleatorio);

// Saber a raiz quadrada de um número
let numraiz = 9;
console.log(numraiz ** (1/2));

let numraiz2 = 9;
console.log(numraiz2 ** (0.5));

// Dividir um número por 0

console.log(100 / 0); // O resultado retornára como verdadeiro, sendo Infinity
