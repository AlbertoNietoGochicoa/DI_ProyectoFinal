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