CREATE PROCEDURE ANADIRPEDIDO
	@dni			varchar(9),
	@fecha_pedido	date,
	@importe		float
AS
BEGIN

	INSERT INTO PEDIDO (dni,fecha_pedido,importe) values (@dni,@fecha_pedido,@importe)
END