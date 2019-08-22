insert into AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DataAlt)
values
('David',24,1,26051995,21042007,GETDATE(),GETDATE()),
('heithor',10,1,26051995,22052211,GETDATE(),GETDATE()),
('Andrei',24,1,26051995,23062212,GETDATE(),GETDATE()),
('Daniela',35,1,22031984,23062212,GETDATE(),GETDATE()),
('Joao',25,1,26051995,22051997,GETDATE(),GETDATE());
go
select * from AulaCsharp