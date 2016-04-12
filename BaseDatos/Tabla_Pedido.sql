CREATE TABLE PEDIDO (
	num_pedido		int not null IDENTITY,
	dni				varchar(9) not null,
	fecha_pedido	date not null,
	importe 		float not null,
	CONSTRAINT num_pedido_pk PRIMARY KEY (num_pedido),
	CONSTRAINT dni_fk FOREIGN KEY (dni) REFERENCES SOCIO (dni)
)