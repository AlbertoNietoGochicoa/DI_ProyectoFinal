# Procedimiento para actualizar el Stock

CREATE PROCEDURE ACTUALIZARSTOCK

	@nom_prod		varchar(50),
	@stock 			int
AS
BEGIN
	update PRODUCTO set stock = stock - @stock where nom_prod = @nom_prod
END