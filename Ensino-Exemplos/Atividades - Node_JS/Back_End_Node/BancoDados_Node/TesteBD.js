// Conectando Banco de dados com página node

const Sequelize = require("sequelize")
const sequelize = new Sequelize('teste', 'root', 'Mago!2003',{
	host: "localhost",
	dialect: 'mysql'
	/* Sequência: NomedaTabela, NomedeUsuario, NomedaSenha, 
	   NomedoLocal, TipodePrograma*/
})

// Models no Sequelize - Adicionando Dados ao Banco no Node

//Criando Tabelas
const Blog = sequelize.define('postagens',{
	curiosidades: {
		type: Sequelize.TEXT
	},
	noticias: {
		type: Sequelize.TEXT
	}
})
const Usuario = sequelize.define('usuarios',{
	nome: {
		type: Sequelize.STRING
	},
	sobrenome: {
		type: Sequelize.STRING
	},
	idade: {
		type: Sequelize.INTEGER
	},
	email: {
		type: Sequelize.STRING
	}
})

//Adicionando dados
Usuario.create({
	nome: "Wallace",
	sobrenome: "Ribeiro",
	idade: 20,
	email: "walkermago60@gmail.com"
})

/*sequelize.authenticate().then(function(){
	console.log("Conectado com sucesso!")
}).catch(function(erro){
	console.log("Falha ao se conectar: "+erro)
})*/