CREATE DATABASE Estoque
GO
USE Estoque
GO

CREATE TABLE Estoque
(
	id int identity(1,1) primary key,
	produto varchar(100) not null,
	tamanho varchar(50),
	quantidade int not null,
	valor float not null,
	quantMin int
)
GO
--SELECT * FROM Estoque

CREATE TABLE Funcionario
(
	id int identity(1,1) primary key,
	nome varchar(50) not null,
	senha varchar(20) not null,
	contato1 varchar(15) not null,
	contato2 varchar(15)
)
GO

CREATE TABLE Vendas
(
	id int identity(1,1),
	FK_FuncionarioID int,
	FK_EstoqueID int,
	quantVendida int not null,
	dia varchar(10) not null,
	constraint FK_Vendas1 foreign key (FK_FuncionarioID) references Funcionario(id),
	constraint FK_Vendas2 foreign key (FK_EstoqueID) references Estoque(id),
	constraint PK_Vendas primary key (id, FK_FuncionarioID, FK_EstoqueID)
)
GO
--SELECT * FROM Vendas

CREATE PROCEDURE AtualizaEstoque (@idUsuario INT, @idEstoque INT, @quantidade FLOAT, @descricao VARCHAR(100))
AS
BEGIN
	INSERT INTO Entrada_Estoque (idEstoque, quantidade, descricao, idUsuario) VALUES (@idEstoque, @quantidade, @descricao, @idUsuario)
END
GO

CREATE TRIGGER EntradaProduto_AI AFTER INSERT ON estoque
FOR EACH ROW
BEGIN
      CALL Atualiza_Estoque (new.idEstoque, new.quantidade, new.descricao, new.idUsuario);
END

/**
*Procedure 'VendasRealizadas' para consulta das vendas de variadas faixas de datas e diferentes funcionarios, 
*podendo ser ordenada por diferentes colunas em sentidos crescente ou decrescente.
*/
CREATE PROCEDURE VendasRealizadas @opt varchar(20), @funcionario varchar(50), @diaInicial varchar(10), @diaFinal varchar(10), @sentido varchar(15)
AS
BEGIN --Inínio do processo
	IF (@funcionario = 'Todos') BEGIN
		SET @funcionario = ''
	END
	
	--Seção de consultas em sentido crescente
	IF(@sentido = 'Crescente') BEGIN

		--@opt é a variável usada para verificar sobre qual coluna as consultas serão ordenadas
		IF (@opt = 'Código') BEGIN

		--Primeira forma de seleção
			SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
			FROM Vendas v, Estoque e, Funcionario f 
			WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
				AND f.nome LIKE ('%'+@funcionario+'%')
				AND v.dia >= @diaInicial AND v.dia <= @diaFinal
			ORDER BY v.id 			
		END
		ELSE BEGIN
			IF(@opt = 'Vendedor(a)') BEGIN
				SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
				FROM Vendas v, Estoque e, Funcionario f 
				WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
					AND f.nome LIKE ('%'+@funcionario+'%')
					AND v.dia >= @diaInicial AND v.dia <= @diaFinal
				ORDER BY f.nome, v.dia
			END
			ELSE BEGIN
				IF(@opt = 'Produto') BEGIN
					SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
					FROM Vendas v, Estoque e, Funcionario f 
					WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
						AND f.nome LIKE ('%'+@funcionario+'%')
						AND v.dia >= @diaInicial AND v.dia <= @diaFinal
					ORDER BY e.produto, v.dia
				END
				ELSE BEGIN
					IF(@opt = 'Quantidade') BEGIN
						SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
						FROM Vendas v, Estoque e, Funcionario f 
						WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
							AND f.nome LIKE ('%'+@funcionario+'%')
							AND v.dia >= @diaInicial AND v.dia <= @diaFinal
						ORDER BY v.quantVendida, v.dia
					END
					ELSE BEGIN
						IF(@opt = 'Valor') BEGIN
							SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
							FROM Vendas v, Estoque e, Funcionario f 
							WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
								AND f.nome LIKE ('%'+@funcionario+'%')
								AND v.dia >= @diaInicial AND v.dia <= @diaFinal
							ORDER BY Valor, v.dia
						END
						ELSE BEGIN
							IF(@opt = 'Data') BEGIN
								SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
								FROM Vendas v, Estoque e, Funcionario f 
								WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
									AND f.nome LIKE ('%'+@funcionario+'%')
									AND v.dia >= @diaInicial AND v.dia <= @diaFinal
								ORDER BY v.dia, v.id
							END
						END
					END
				END
			END
		END
	END
	--Seção de consultas em sentido decrescente
	ELSE BEGIN
		IF (@opt = 'Código') BEGIN
			SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
			FROM Vendas v, Estoque e, Funcionario f 
			WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
				AND f.nome LIKE ('%'+@funcionario+'%')
				AND v.dia >= @diaInicial AND v.dia <= @diaFinal
			ORDER BY v.id DESC 			
		END
		ELSE BEGIN
			IF(@opt = 'Vendedor(a)') BEGIN
				SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
				FROM Vendas v, Estoque e, Funcionario f 
				WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
					AND f.nome LIKE ('%'+@funcionario+'%')
					AND v.dia >= @diaInicial AND v.dia <= @diaFinal
				ORDER BY f.nome DESC, v.dia DESC
			END
			ELSE BEGIN
				IF(@opt = 'Produto') BEGIN
					SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
					FROM Vendas v, Estoque e, Funcionario f 
					WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
						AND f.nome LIKE ('%'+@funcionario+'%')
						AND v.dia >= @diaInicial AND v.dia <= @diaFinal
					ORDER BY e.produto DESC, v.dia DESC
				END
				ELSE BEGIN
					IF(@opt = 'Quantidade') BEGIN
						SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
						FROM Vendas v, Estoque e, Funcionario f 
						WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
							AND f.nome LIKE ('%'+@funcionario+'%')
							AND v.dia >= @diaInicial AND v.dia <= @diaFinal
						ORDER BY v.quantVendida DESC, v.dia DESC
					END
					ELSE BEGIN
						IF(@opt = 'Valor') BEGIN
							SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
							FROM Vendas v, Estoque e, Funcionario f 
							WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
								AND f.nome LIKE ('%'+@funcionario+'%')
								AND v.dia >= @diaInicial AND v.dia <= @diaFinal
							ORDER BY Valor DESC, v.dia DESC
						END
						ELSE BEGIN
							IF(@opt = 'Data') BEGIN
								SELECT v.id, f.nome, e.produto, v.quantVendida, (e.valor*v.quantVendida) AS [Valor], v.dia
								FROM Vendas v, Estoque e, Funcionario f 
								WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id 
									AND f.nome LIKE ('%'+@funcionario+'%')
									AND v.dia >= @diaInicial AND v.dia <= @diaFinal
								ORDER BY v.dia DESC, v.id DESC
							END
						END
					END
				END
			END
		END
	END
END
--Fim da procedure
GO

/**
*Procedure 'MaisVendidos' para realizar a consulta dos produtos mais vendidos
*em uma determinada faixa de data.
*/
CREATE PROCEDURE MaisVendidos @diaInicial varchar(10), @diaFinal varchar(10)
AS
BEGIN
	SELECT v.FK_EstoqueID, e.produto, SUM(v.quantVendida)
	FROM Vendas v, Estoque e, Funcionario f
	WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id
		AND v.dia >= @diaInicial AND v.dia <= @diaFinal
	GROUP BY FK_EstoqueID, e.produto
	ORDER BY SUM(quantVendida) DESC
END
GO

CREATE VIEW vwValorDia
AS
	SELECT SUM(e.valor*v.quantVendida) AS [total dia], v.dia
	FROM Estoque e, Funcionario f, Vendas v
	WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id
	GROUP BY v.dia
GO

CREATE PROCEDURE VendasDia @dia varchar(10)
AS
BEGIN
	SELECT f.id, f.nome, SUM(e.valor*v.quantVendida)
	FROM Estoque e, Funcionario f, Vendas v
	WHERE v.FK_EstoqueID = e.id AND v.FK_FuncionarioID = f.id
		AND v.dia = @dia
	GROUP BY f.id, f.nome
	ORDER BY f.nome
END
GO



--Exemplo INSERT
insert into Estoque values('Malha Azul', 'M', 13, 29.99)
GO

--Exemplo UPDATE
UPDATE Estoque 
SET produto = 'Sobretudo', tamanho = 'Unico', quantidade = 8, valor = 109.99 
WHERE id = 3
GO

--Exemplo DELETE
delete from Estoque

--Exemplo pesquisa por nome
SELECT * FROM Estoque WHERE produto LIKE '%can%'
GO

--Exemplo Execução de Stored Procedure
EXECUTE VendasRealizadas 'Código', 'Todos', '2020/01/01', '2020/12/01', 'Crescente'

--Exemplo Execução de View
SELECT * FROM vwValorDia ORDER BY dia DESC
