use rendonracing;

--Se tiene que hacer uso de las keys que aparecen dentro de tabla>keys>
--Eliminacion de la relacion purchase-product
ALTER TABLE purchaseProducts
DROP CONSTRAINT [FK__purchaseP__produ__534D60F1];
--Eliminacion de la relacion booking-product
ALTER TABLE bookingProducts
DROP CONSTRAINT [FK__bookingPr__produ__5535A963];
--Eliminacion de la relacion categoria-product
ALTER TABLE productCategories
DROP CONSTRAINT [FK__productCa__produ__59FA5E80];
--Eliminacion de la key de producto
ALTER TABLE product
DROP CONSTRAINT [PK__product__3213E83FE8B7FACD];

--Cambiar el tipo de id en product
Alter table [product] ALTER COLUMN id varchar(30) not null; 
ALTER TABLE [product]
ADD PRIMARY KEY (id);

--purchaseProduct
Alter table [purchaseProducts] ALTER COLUMN productFK varchar(30) not null; 
--bookingProduct
Alter table [bookingProducts] ALTER COLUMN productFK varchar(30) not null; 
--productCategories
Alter table [productCategories] ALTER COLUMN productFK varchar(30) not null; 

--Agregar las foreign keys
ALTER TABLE [purchaseProducts] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO
ALTER TABLE [bookingProducts] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO
ALTER TABLE [productCategories] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO

