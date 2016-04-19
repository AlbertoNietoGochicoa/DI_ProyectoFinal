# Procedimento para añadir un producto

CREATE PROCEDURE ADDPRODUCTO
	@nom_prod 	 	varchar(50),
	@descripcion 	varchar(100),
	@precio		 	float,
	@stock		 	int,
	@stock_minimo 	int
AS
BEGIN
	DECLARE @existe int
	SET @existe = ( select count(*)
			  	from producto
			  	where nom_prod = @nom_prod)
	if @existe > 0 
	BEGIN
		raiserror('Ese nombre de producto ya está en la BD',16,1) 
	END
	else
	BEGIN
		INSERT INTO PRODUCTO (nom_prod,descripcion,precio,stock,stock_minimo) values (@nom_prod,@descripcion,@precio,@stock,@stock_minimo)
	END
END
