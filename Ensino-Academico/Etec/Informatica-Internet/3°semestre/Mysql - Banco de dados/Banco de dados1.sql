insert into pedido (Data)
values ('2020-02-08 19:25:00');
  create table produtos (
     Id int not null auto_increment primary key,
     Nome varchar(100) not null
     );
	create table PedidosItens(
      Id int not null auto_increment primary key,
      IdPedido int not null,
      IdProduto int not null,
      Quantidade tinyint not null,
      foreign key fk_ IdProduto references Produtos(Id)
      );
      alter table PedidosItens add constraint foreign key
      Fk_ITEM_PRODUTO (IdProduto) references produtos (Id);
    