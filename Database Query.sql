DROP DATABASE ReservationChambre 
CREATE DATABASE ReservationChambre

GO

USE ReservationChambre

GO

CREATE TABLE tCategorisation
(
	id int primary key identity (1,1),
	designationCategorisation nvarchar (100)
)

GO

CREATE TABLE tClient
(
	id int primary key identity (1,1),
	noms nvarchar (100),
	adresse nvarchar (100),
	contact nvarchar (100),
	refCategorisation int foreign key references tCategorisation(id) 
)

GO

CREATE TABLE tClasse
(
	id int primary key identity (1,1),
	designationClasse nvarchar (100),
	prix decimal (30,2)
)

GO

CREATE TABLE tChambre
(
	id int primary key identity (1,1),
	numChambre int,
	contacts nvarchar (100),
	refClasse int foreign key references tClasse (id)
)

GO

CREATE TABLE tReservation
(
	id int primary key identity (1,1),
	refClient int foreign key references tClient(id),
	refChambre int foreign key references tChambre(id),
	DateEntree date,
	DateSortie date
)

GO

CREATE PROCEDURE SaveCategorisation
(
	@id int,
	@designationCategorisation nvarchar (100)
) 

AS

	BEGIN

	IF @id in (SELECT id FROM tCategorisation)
	BEGIN

	update tCategorisation set designationCategorisation = @designationCategorisation where id = @id

	END

	ELSE

	BEGIN

	INSERT INTO tCategorisation(designationCategorisation)
	VALUES (@designationCategorisation)

	END

	END

GO

CREATE PROCEDURE SaveClient
(
	@id int,
	@noms nvarchar (100),
	@adresse nvarchar (100),
	@contact nvarchar (100),
	@refCategorisation int 
)

AS

	BEGIN

	IF @id in (SELECT id FROM tClient)
	BEGIN

	update tClient set noms = @noms, adresse = @adresse, contact = @contact, 
	refCategorisation = @refCategorisation where id = @id

	END

	ELSE

	BEGIN

	INSERT INTO tClient (noms,adresse,contact,refCategorisation)
	VALUES (@noms,@adresse,@contact,@refCategorisation)

	END

	END

GO

CREATE PROCEDURE SaveClasse
(
	@id int,
	@designationClasse nvarchar (100),
	@prix decimal (30,2)
)

AS

	BEGIN

	IF @id in (SELECT id FROM tClasse)
	BEGIN

	update tClasse set designationClasse = @designationClasse, prix = @prix where id = @id

	END

	ELSE

	BEGIN

	INSERT INTO tClasse(designationClasse, prix)
	VALUES (@designationClasse, @prix)

	END

	END

GO

CREATE PROCEDURE SaveChambre
(
	@id int,
	@numChambre int,
	@contacts nvarchar (100),
	@refClasse int
)

AS

	BEGIN

	IF @id in (SELECT id FROM tChambre)
	BEGIN

	update tChambre set numChambre = @numChambre, contacts = @contacts, 
	refClasse = @refClasse where id = @id

	END

	ELSE

	BEGIN

	INSERT INTO tChambre(numChambre, contacts, refClasse)
	VALUES (@numChambre, @contacts, @refClasse)

	END

	END

GO

CREATE PROCEDURE SaveReservation
(
	@id int,
	@refClient int,
	@refChambre int,
	@DateEntree date,
	@DateSortie date
)

AS

	BEGIN

	IF @id in (SELECT id FROM tReservation)
	BEGIN

	update tReservation set refChambre = @refChambre, refClient = @refClient,
	DateEntree = @DateEntree, DateSortie = @DateEntree where id = @id

	END

	ELSE

	BEGIN

	INSERT INTO tReservation(refClient, refChambre, DateEntree, DateSortie)
	VALUES (@refClient, @refChambre, @DateEntree, @DateSortie)

	END

	END

GO


ALTER ROLE ReservationChambre ADD MEMBER Lesoutils;




