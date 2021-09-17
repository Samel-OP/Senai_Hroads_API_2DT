USE SENAI_HROADS_TARDE;
GO

--DQL

--Inserir os registros conforme a descrição no texto;

INSERT INTO TIPOHABILIDADE (nomeTipoHabilidade)
VALUES ('Ataque'),('Defesa'),('Cura'),('Magia');


INSERT INTO HABILIDADE1 (idTipoHabilidade,nomeHabilidade1)
VALUES (1,'Lança Mortal'),(2,'Escudo Supremo'),(3,'Recuperar Vida');


INSERT INTO HABILIDADE2 (idTipoHabilidade,nomeHabilidade2)
VALUES (1,'Lança Mortal'),(2,'Escudo Supremo'),(3,'Recuperar Vida');


INSERT INTO CLASSE (idHabilidade,idHabilidade2,nomeClasse)
VALUES (1,2,'Bárbaro'),(2,null,'Cruzado'),(1,null,'Caçadora de Demônios'),(3,2,'Monge'),(null,null,'Necromante'),(3,null,'Feiticeiro'),(null,null,'Arcanista');


--Atualizar o nome da classe de Necromante para Necromancer
UPDATE CLASSE 
SET nomeClasse = 'Necromancer'
WHERE idClasse = 5;


INSERT INTO PERSONAGEM (idClasse,nomePersonagem,capacidadeVidaMax,CapacidadeManaMax,dataUtilizacao,dataCriacao)
VALUES (1,'DeuBug',100,80,'2021/08/09','2019/01/18'),(4,'BitBug',70,100,'2021/08/09','2016/03/17'),(7,'Fer8',75,60,'2021/08/09','2018/03/18');

--Atualizar o nome do personagem Fer8 para Fer7
UPDATE PERSONAGEM
SET nomePersonagem = 'Fer7'
WHERE idPersonagem = 3;