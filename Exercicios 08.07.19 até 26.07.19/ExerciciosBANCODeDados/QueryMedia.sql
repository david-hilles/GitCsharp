select 
	AL.Nome,
	SUM(NT.Nota1) / COUNT(*) as 'Media'
from Aluno AL
inner join Notas NT on AL.Id = NT.Aluno
group by AL.Nome