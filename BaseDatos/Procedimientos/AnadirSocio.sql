# Añadir nuevo Socio

CREATE PROCEDURE ANADIRSOCIO 
	@dni			varchar(9),
	@nom_soc		varchar(30),
	@email			varchar(50),
	@iban			varchar(34),
	@foto			image,
	@observacions	varchar(200)
AS
BEGIN
	DECLARE @existe int
	SET @existe = ( select count(*)
			  	from SOCIO
			  	where dni = @dni)
	if @existe > 0 
	BEGIN
		raiserror('El socio ya está en la BD.',16,1) 
	END
	else
	BEGIN
		INSERT INTO SOCIO values (@dni,@nom_soc,@email,@iban,@foto,@observacions)
	END
END