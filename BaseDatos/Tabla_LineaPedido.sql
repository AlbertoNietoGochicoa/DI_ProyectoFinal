CREATE TABLE LINEA_PEDIDO (
	num_ped		int not null,
	cod_prod	int not null,
	cantidad	int not null,
	CONSTRAINT 	num_ped_cod_prod_PK PRIMARY KEY (num_ped,cod_prod),
	CONSTRAINT num_ped_fk FOREIGN KEY (num_ped) REFERENCES PEDIDO (num_pedido),
	CONSTRAINT cod_prod_fk FOREIGN KEY (cod_prod) REFERENCES PRODUCTO (cod_prod)
)