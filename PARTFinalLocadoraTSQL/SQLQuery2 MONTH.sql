select

C.Marca as 'modelo',
MONTH (L.Datainicio) as 'mes',
COUNT (*) as 'Locacoes'

from Carros C

 inner join Locacao L on L.Idcarros=C.Id
 group by C.Marca, MONTH(L.Datainicio)

