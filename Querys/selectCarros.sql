select 'Carros' as 'Carros',
        SUM(Temp.Media) as 'Vendas',
		Temp.AnoVenda

from (select
           Modelo,
           Ano,
          (SUM(NumeroDeVendas) /COUNT(*)) as 'media',
           MONTH(DatedeVendas) as 'AnoVenda'

  From TabelaDecarros
  GROUP BY Modelo,Ano,MONTH(DatedeVendas)) Temp
group by Temp.AnoVenda
  

