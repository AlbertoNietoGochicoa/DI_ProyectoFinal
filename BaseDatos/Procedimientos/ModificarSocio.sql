# Modificar socio

CREATE PROCEDURE MODIFICARSOCIO
	@dni			varchar(9),
	@nom_soc		varchar(30),
	@email			varchar(50),
	@iban			varchar(34),

	@observacions	varchar(200)
AS
BEGIN
	update SOCIO set nom_soc = @nom_soc,
							  email = @email, 
							  iban = @iban, 
							   
							  observacions = @observacions
							where dni = @dni
END
