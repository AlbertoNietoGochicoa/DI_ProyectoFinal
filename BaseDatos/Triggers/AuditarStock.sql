# Trigger que auditará el número mínimo de exitencias tras hacer un update.

CREATE TRIGGER AUDITARSTOCK ON PRODUCTO FOR UPDATE
AS
BEGIN
	DECLARE @stock INT
	SELECT @stock = stock
	FROM PRODUCTO
	WHERE cod_prod = (select inserted.cod_prod
					  from inserted)
	if (@stock <= (select stock_min from inserted))
	BEGIN
		raiserror ("Producto bajo de stock",16,1)
	END
END