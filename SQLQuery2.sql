CREATE TABLE Aluno (
Id INT IDENTITY(1,1) NOT NULL,
Matricula VARCHAR(50) NOT NULL,
Nome VARCHAR(50) NOT NULL,
Cpf VARCHAR(50) NULL
PRIMARY KEY(Id)
)

Insert into Aluno(Nome, Matricula, Cpf)
Values('Nome', 'Matricula', 'Cpf')

Select * FROM Aluno