var http = require('http');

http.createServer(function(req, res){
	res.end("hello world");
}).listen(8801);

console.log("Servidor rodando...");

// este module http permite criar um local de servidor para executar páginas web back-end;
// Toda vez que for alterar o código e salvar é necessário reiniciar o servidor no cmd com a teclas Ctrl + C;