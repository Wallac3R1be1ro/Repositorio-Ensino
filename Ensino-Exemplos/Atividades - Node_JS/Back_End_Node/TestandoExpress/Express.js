const express = require("express");
const app = express();

app.get("/", function(req, res){
	res.sendFile(__dirname + "/index.html"); //Atribuindo html
});

app.get("/sobre", function(req, res){
	res.send("Minha página sobre");
});

app.get("/blog", function(req, res){
	res.send("Bem vindo ao meu blog!");
});

app.listen(8081, function(){
	console.log("Servidor está ativo... na url http://localhost:8081");
});