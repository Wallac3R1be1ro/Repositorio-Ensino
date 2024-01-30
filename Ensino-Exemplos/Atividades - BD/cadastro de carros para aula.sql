create database banco_11_03;
use banco_11_03;
create table veiculo(
       cod_vec int auto_increment not null, 
       modelo_vec varchar(35) not null, 
       marca_vec varchar(35) not null, 
       valor_vec decimal(7,0),
       ano_vec int default 2021, 
       placa_vec char(7) unique,
       primary key(cod_vec));
       
insert into veiculo(modelo_vec, marca_vec, valor_vec, ano_vec,placa_vec)
values 
      ("astra","chevrolet",10500,1999,"dkt3745"),
      ("astra","chevrolet",12000,2001,"duc4875"),
      ("clio","renault",10500,2008,"hft4875"),
      ("duster","renault",24790,2014,"qwe9273"),
      ("ecosport","ford",19890,2004,"nry2290"),
      ("cobalt","chevrolet",25900,2012,"nry2195"),
      ("captiva","chevrolet",32900,2010,"jdh7749"),
      ("civic","honda",12490,1998,"eur3827"),
      ("city","honda",28999,2011,"hry3845"),
      ("fluence","renault",29900,2011,"rlk3820"),
      ("aircross","cintroen",55085,2017,"vel3825"),
      ("xantia","cintroen",6000,1996,"tye3759"),
      ("edge","ford",47229,2009,"hsk2753"),
      ("argo","fiat",59900,2019,"roe2332"),
      ("uno drive","fiat",36918,2018,"ure4353"),
      ("montana","chevrolet",42990,2020,"tre2922"),
      ("cobalt","chevrolet",53500,2016,"uer3847");
 
