select 

	AL.Nome,
	IIF(SUM(NT.Nota1) / COUNT(*) >= 7
	AND (SUM(CONVERT(money,FR.Ativo)) / CONVERT(money,count(FR.Ativo)) * 100) >= 75,'Aprovado','Reprovado') as 'Status'
	from Aluno AL
inner join Notas NT on AL.Id = NT.Aluno
inner join Frequencia FR on fr.Aluno = AL.Id
group by AL.Nome