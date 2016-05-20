# Modificar socio

CREATE PROCEDURE MODIFICARSOCIO
	@dni			varchar(9),
	@nom_soc		varchar(30),
	@email			varchar(50),
	@iban			varchar(34),
	@foto			image,
	@observacions	varchar(200)
AS
BEGIN
	update PRODUCTO set nom_soc = @nom_soc,
							  email = @email, 
							  iban = @iban, 
							  foto = @foto, 
							  observacions = @observacions
							where dni = @dni
END
