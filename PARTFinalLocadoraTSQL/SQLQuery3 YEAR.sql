select

C.Marca as 'modelo',
YEAR (L.Datainicio) as 'mes',
COUNT (*) as 'Locacoes'

from Carros C

 inner join Locacao L on L.Idcarros=C.Id
 group by C.Marca, YEAR(L.Datainicio)
