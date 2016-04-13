CREATE PROCEDURE DELETEPRODUCTO
	@nom_prod varchar(50)
AS
BEGIN
	DECLARE @existe int
	SET @existe = ( select count(*)
			  	from producto
			  	where nom_prod = @nom_prod)
	if @existe = 0 
	BEGIN
		raiserror('El producto no está presente en la BD',16,1) 
	END
	else
	BEGIN
		DELETE
		FROM producto
		WHERE nom_prod = @nom_prod
	
	END
END