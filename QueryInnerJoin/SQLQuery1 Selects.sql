select
Nome
from marcas
where UsuInc = 1;


select
Nome
from Marcas
where UsuInc= 2;


select
COUNT(*) as 'Nome cadastrado por felipe'
from Marcas
where UsuInc = 1
order by COUNT(*) desc;

select
COUNT(*) as 'Nome cadastrado por Giomar'
from Marcas
where UsuInc = 2
order by COUNT(*) asc;

select
COUNT(*) 'marcas que Felipe e Giomar cadastraram'
from Marcas
order by COUNT(*);

select
Modelo
from Carros
where UsuInc = 1;

select
Modelo
from Carros
where UsuInc = 2;

select
COUNT(*) as 'Carros que Felipe cadastrou '
from Carros
where UsuInc = 1
order by COUNT(*) desc;

select
COUNT(*) as 'Carros que Giomar cadastrou '
from Carros
where UsuInc = 2
order by COUNT(*) asc;

select
COUNT(*) as 'Carros que Felipe e Giomar cadastraram'
from Carros
order by COUNT(*);
-----
select
C.Modelo as 'Carros das marcas que Felipe cadastrou'
from Carros C 
inner join Marcas M on M.Id = C.Marca
where M.UsuInc = 1;
------------
select
C.Modelo as 'Carros das marcas que Giomar cadastrou'
from Carros C 
inner join Marcas M on M.Id = C.Marca
where M.UsuInc = 2
------------
select
COUNT(*) as 'Carros das marcas que Felipe cadastrou'
from Carros C 
inner join Marcas M on M.Id = C.Marca
where M.UsuInc = 1
order by COUNT(*) asc;

------------
select
COUNT(*) as 'Carros das marcas que Giomar cadastrou'
from Carros C 
inner join Marcas M on M.Id = C.Marca

where M.UsuInc = 2
order by COUNT(*) desc;
----------------
select
   SUM(Quantidade * Valor) as 'valor total de vendas 2019 isolado'
from Vendas
where YEAR(DatInc) = 2019;
----------------
select
   SUM(Quantidade) as 'Quantidade total de vendas 2019'
from Vendas
where YEAR(DatInc) = 2019;
---------------------------
select

   SUM(Quantidade * Valor) as 'Valor total de vendas em cada ano 2019',
   YEAR(DatInc) as 'Ano'

from Vendas
group by YEAR(DatInc)
order by SUM(Quantidade * Valor) desc;
---------------------------
select

   SUM(Quantidade) as 'Quantidade total de vendas em cada ano 2019',
   YEAR(DatInc) as 'Ano'

from Vendas
group by YEAR(DatInc)
order by SUM(Quantidade) desc;
-----------------------------
select

   SUM(Quantidade) as 'Quantidade total de vendas 2019',
     MONTH(DatInc) as 'Mes',
	 YEAR(DatInc) as 'Ano' 

from Vendas
group by MONTH(DatInc),YEAR(DatInc)
order by SUM(Quantidade) desc;
------------------------
select

   SUM(Quantidade * Valor) as ' Maior valor de vendas',
     MONTH(DatInc) as 'Mes',
	 YEAR(DatInc) as 'Ano' 

from Vendas
group by MONTH(DatInc),YEAR(DatInc)
order by SUM(Quantidade * Valor) desc;
---------------------------------
select

   SUM(Quantidade * Valor) as 'Valor total de vendas Felipe Realizou'
from Vendas
where UsuInc = 1;
---------------------------------
select

   SUM(Quantidade * Valor) as 'Valor total de vendas Giomar Realizou'
from Vendas
where UsuInc = 2;
----------------------------
select

   SUM(Quantidade) as 'Quantidade total de vendas Felipe Realizou'
from Vendas
where UsuInc = 1;
----------------------------
select

   SUM(Quantidade) as 'Quantidade total de vendas Giomar Realizou'
from Vendas
where UsuInc = 2;
-------------------------------------
select

   SUM(Quantidade) as 'Quantidade total de vendas Giomar e Felipe Realizou'
from Vendas
order by SUM(Quantidade) desc;
--------------------------------------
select

   SUM(Quantidade * Valor) as 'Quantidade total de vendas Giomar e Felipe Realizou'
   
from Vendas
order by SUM(Quantidade * Valor) desc;
----------------------------------------
  select 
  M.Nome as 'Marca',


  SUM(V.Quantidade) as 'Quantidade de Vendas'

  from Marcas M
  inner join Carros C on C.Marca = M.Id
  inner join Vendas V on V.Carro = C.Id
  group by M.Nome 
  order by SUM(V.Quantidade) desc;
  ---------------------------------------
   Select 
	 M.Nome as 'Marca',
	SUM(V.Quantidade *V.Valor) as 'Valor de Vendas'
  from Marcas M
  inner join Carros C on C.Marca = M.Id
  inner join Vendas V on V.Carro = C.Id
  group by M.Nome 
  order by SUM(V.Quantidade *V.Valor) desc;
  -----------------------------------------------
  select
	C.Modelo as 'Carro',
   SUM(V.Quantidade) as 'Carros mais vendidos'
from Carros C
   inner join Vendas V on C.Id = V.Carro
group by C.Modelo
order by SUM(V.Quantidade) desc;

---------------------------------------------
select
	C.Modelo as 'Carro',
  SUM(V.Quantidade * V.Valor) as 'Valor do carro mais vendido'

  from Carros C
  inner join Vendas V on C.Id = V.Carro
  group by C.Modelo
  order by SUM(V.Quantidade * V.Valor) desc;
















 
