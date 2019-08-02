select                                           
         BL.Nome,
         COUNT(LV.Id) as 'QuantLivros',
         US.Nome as 'UserName'
 from biblioteca BL
 inner join Livro LV on BL.Id = LV.biblioteca
 inner join Usuario US on LV.UserInc = US.Id
 group by BL.Nome,US.Nome