select

  TipoDog,
  TotalDeVendas,
    MONTH (DataVendas) as 'Mes'

	from FoodTruck
	group by TipoDog,TotalDeVendas,MONTH (DataVendas)
	order by MONTH (DataVendas) asc



