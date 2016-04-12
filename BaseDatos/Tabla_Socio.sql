CREATE TABLE SOCIO (
	dni				varchar(9) not null,
	nom_soc			varchar(30) not null,
	email			varchar(50),
	iban			varchar(34) not null,
	foto			image,
	observacions	varchar(200),
	CONSTRAINT dni_pk_PRODUCTO PRIMARY KEY (dni)
)