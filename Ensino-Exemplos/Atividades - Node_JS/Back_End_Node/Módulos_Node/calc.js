var somaFunc = require("./somar");
var subFunc = require("./sub");
var multiFunc = require("./multi");
var divFunc = require("./dividir");

console.log(somaFunc(5,2));
console.log(subFunc(5,2));
console.log(multiFunc(5,2));
console.log(divFunc(5,2));

//A função module.exports permite pegar dados de outros arquivos JavaScript e executa-los.