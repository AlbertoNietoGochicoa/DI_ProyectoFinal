CREATE DATABASE sociedadGastronomica
GO
use sociedadGastronomica
GO
CREATE TABLE SOCIO (
	dni				varchar(9) not null,
	nom_soc			varchar(30) not null,
	email			varchar(50),
	iban			varchar(34) not null,
	foto			image,
	observacions	varchar(200),
	CONSTRAINT dni_pk_PRODUCTO PRIMARY KEY (dni)
)
GO
CREATE TABLE PRODUCTO (
	cod_prod		int not null IDENTITY,
	nom_prod		varchar(50) not null,
	descripcion 	varchar(100),
	precio 			float not null,
	stock			int not null,
	stock_minimo	int not null,
	CONSTRAINT cod_prod_clave_primaria PRIMARY KEY (cod_prod),
	CONSTRAINT nom_prod_no_unico UNIQUE (nom_prod)
)
GO
CREATE TABLE PEDIDO (
	num_pedido		int not null IDENTITY,
	dni				varchar(9) not null,
	fecha_pedido	date not null,
	importe 		float not null,
	CONSTRAINT num_pedido_pk PRIMARY KEY (num_pedido),
	CONSTRAINT dni_fk FOREIGN KEY (dni) REFERENCES SOCIO (dni)
)
GO
CREATE TABLE LINEA_PEDIDO (
	num_ped		int not null,
	cod_prod	int not null,
	cantidad	int not null,
	CONSTRAINT 	num_ped_cod_prod_PK PRIMARY KEY (num_ped,cod_prod),
	CONSTRAINT num_ped_fk FOREIGN KEY (num_ped) REFERENCES PEDIDO (num_pedido),
	CONSTRAINT cod_prod_fk FOREIGN KEY (cod_prod) REFERENCES PRODUCTO (cod_prod)
)
GO
CREATE PROCEDURE ACTUALIZARSTOCK

	@nom_prod		varchar(50),
	@stock 			int
AS
BEGIN
	update PRODUCTO set stock = stock - @stock where nom_prod = @nom_prod
END
GO
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
GO
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
GO
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
GO
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
GO
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
GO
CREATE TRIGGER AUDITARSTOCK ON PRODUCTO FOR UPDATE
AS
BEGIN
	DECLARE @stock INT
	SELECT @stock = stock
	FROM PRODUCTO
	WHERE cod_prod = (select inserted.cod_prod
					  from inserted)
	if (@stock <= (select stock_minimo from inserted))
	BEGIN
		raiserror ('Producto bajo de stock',16,1)
	END
END