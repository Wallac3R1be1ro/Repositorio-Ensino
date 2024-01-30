const express = require('express');
const app = express();
const handlebars = require('express-handlebars')
const Sequelize = require('sequelize')

//configurable
	//Template Engine
		app.engine('handlebars', handlebars.engine({defaultLayout: 'main'}))
		app.set('view engine', 'handlebars')
	//Conexão com banco de dados
	const sequelize = new Sequelize('teste', 'root', 'Mago!2003',{
	host: "localhost",
	dialect: 'mysql'
	/* Sequência: NomedaTabela, NomedeUsuario, NomedaSenha, 
	   NomedoLocal, TipodePrograma*/
})
//Rotas

	app.get('/cad', function(req, res){
		res.render('forms')
	})

app.listen(8081, function(){
	console.log("Servidor Rodando na URL http://localhost:8081");
});