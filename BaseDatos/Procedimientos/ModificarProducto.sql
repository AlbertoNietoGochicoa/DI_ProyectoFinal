# Modificar Producto

CREATE PROCEDURE MODIFICARPRODUCTO
	@cod_prod	int,
	@nom_prod		varchar(50),
	@descripcion	varchar(100),
	@precio			float,
	@stock			int,
	@stock_minimo	int
AS
BEGIN
	update PRODUCTO set nom_prod = @nom_prod,
							  descripcion = @descripcion, 
							  precio = @precio, 
							  stock = @stock, 
							  stock_minimo = @stock_minimo
							where cod_prod = @cod_prod
END
