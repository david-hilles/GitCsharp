select AL.Nome,
       SUM(CONVERT(money,fr.Ativo)) /  CONVERT(money,count(fr.Ativo)) * 100 as 'Frequencia'
	   from Aluno al 
inner join Frequencia fr on al.Id = fr.Aluno
group by AL.Nome