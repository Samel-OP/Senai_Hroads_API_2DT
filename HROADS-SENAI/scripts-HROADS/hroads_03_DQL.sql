USE SENAI_HROADS_TARDE;
GO

---DQL

--Selecionar todos os persongens
SELECT * FROM PERSONAGEM;

--Selecionar todas as classes;
SELECT * FROM CLASSE;

--Selecionar somente o nome das Classes;
SELECT nomeClasse FROM CLASSE;

--Selecionar todas as habilidades
SELECT * FROM HABILIDADE1;
SELECT * FROM HABILIDADE2;

--Realizar a contagem de quantas habilidades
SELECT COUNT (idHabilidade2) AS [Total habilidades]
FROM HABILIDADE2;
GO
SELECT COUNT (idHabilidade1) AS [Total habilidades]
FROM HABILIDADE1;
GO

--Selecionar somente os id's das habilidades classificando-os por ordem crescente;
SELECT * FROM HABILIDADE1
ORDER BY idHabilidade1 ASC;

SELECT * FROM HABILIDADE2
ORDER BY idHabilidade2 ASC;

--Selecionar todos os personagens e suas respectivas classes
SELECT * FROM TIPOHABILIDADE;

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte;
SELECT nomeHabilidade1, nomeTipoHabilidade FROM HABILIDADE1
INNER JOIN TIPOHABILIDADE
ON HABILIDADE1.idTipoHabilidade = TIPOHABILIDADE.idTipoHabilidade;
GO

SELECT nomeHabilidade2, nomeTipoHabilidade FROM HABILIDADE2
INNER JOIN TIPOHABILIDADE
ON HABILIDADE2.idTipoHabilidade = TIPOHABILIDADE.idTipoHabilidade;
GO

-- Selecionar todos os personagens e suas respectivas classes;
SELECT nomePersonagem, nomeClasse 
FROM PERSONAGEM
LEFT JOIN CLASSE
ON PERSONAGEM.idClasse = CLASSE.idClasse;
GO

-- Selecionar todos os personagens e as classes;
SELECT nomePersonagem, nomeClasse FROM PERSONAGEM
FULL OUTER JOIN CLASSE
ON PERSONAGEM.idClasse = CLASSE.idClasse;
GO

--Selecionar todas classes e suas respectivas habilidades
SELECT idClasse, nomeClasse, nomeHabilidade1, nomeHabilidade2 FROM CLASSE
LEFT JOIN HABILIDADE1
ON CLASSE.idHabilidade = HABILIDADE1.idHabilidade1
LEFT JOIN HABILIDADE2
ON CLASSE.idHabilidade2 = HABILIDADE2.idHabilidade2;
GO


--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
SELECT nomeHabilidade1,nomeHabilidade2, nomeClasse FROM HABILIDADE1
INNER JOIN CLASSE
ON HABILIDADE1.idHabilidade1 = CLASSE.idHabilidade
LEFT JOIN HABILIDADE2
ON CLASSE.idHabilidade2 = HABILIDADE2.idHabilidade2;
GO

--Selecionar todas as haabilidades e suas (mesmo que elas não tenham correspondência)
SELECT nomeHabilidade1,nomeHabilidade2, nomeClasse FROM HABILIDADE1
FULL OUTER JOIN CLASSE
ON HABILIDADE1.idHabilidade1 = CLASSE.idHabilidade
LEFT JOIN HABILIDADE2
ON HABILIDADE2.idHabilidade2 = CLASSE.idHabilidade2;
GO

/*
SELECT * FROM HABILIDADE1
FULL OUTER JOIN HABILIDADE2
ON HABILIDADE1.idTipoHabilidade = HABILIDADE2.idTipoHabilidade;
GO*/
