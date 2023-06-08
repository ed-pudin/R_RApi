CREATE TABLE [user] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [name] varchar(50) NOT NULL,
  [lastname] varchar(50) NOT NULL,
  [email] varchar(50) NOT NULL,
  [password] varchar(20) NOT NULL,
  [rol] varchar(255) NOT NULL CHECK ([rol] IN ('admin', 'client'))
)
GO

CREATE TABLE [purchase] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [service] varchar(150) NULL,
  [subtotalService] float NULL,
  [subtotalProducts] float NULL,
  [payment] float NULL,
  [change] float NULL,
  [total] float NULL
)
GO

CREATE TABLE [category] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [name] varchar(30) NOT NULL
)
GO

CREATE TABLE [purchaseProducts] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [purchaseFK] char(36) NOT NULL,
  [productFK] int NOT NULL,
  [quantity] int NOT NULL
)
GO

CREATE TABLE [bookingProducts] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [bookingFK] char(36) NOT NULL,
  [productFK] int NOT NULL,
  [quantity] int NOT NULL
)
GO

CREATE TABLE [booking] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [subtotalProducts] float NULL
)
GO

CREATE TABLE [product] (
  [id] int PRIMARY KEY NOT NULL,
  [name] varchar(50) NOT NULL,
  [description] varchar(100) NULL,
  [quantity] int NOT NULL,
  [price] float NOT NULL,
  [isActive] bit NOT NULL DEFAULT 1
)
GO

CREATE TABLE [userPuchases] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [userFK] char(36) NOT NULL,
  [purchaseFK] char(36) NOT NULL,
  [datePurchase] datetime NOT NULL
)
GO

CREATE TABLE [userBookings] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [userFK] char(36) NOT NULL,
  [bookingFK] char(36) NOT NULL,
  [datePurchase] datetime NOT NULL
)
GO

CREATE TABLE [productCategories] (
  [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
  [productFK] int NOT NULL,
  [categoryFK] char(36) NOT NULL
)
GO

ALTER TABLE [purchaseProducts] ADD FOREIGN KEY ([purchaseFK]) REFERENCES [purchase] ([id])
GO

ALTER TABLE [purchaseProducts] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO

ALTER TABLE [bookingProducts] ADD FOREIGN KEY ([bookingFK]) REFERENCES [booking] ([id])
GO

ALTER TABLE [bookingProducts] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO

ALTER TABLE [userPuchases] ADD FOREIGN KEY ([userFK]) REFERENCES [user] ([id])
GO

ALTER TABLE [userPuchases] ADD FOREIGN KEY ([purchaseFK]) REFERENCES [purchase] ([id])
GO

ALTER TABLE [userBookings] ADD FOREIGN KEY ([userFK]) REFERENCES [user] ([id])
GO

ALTER TABLE [userBookings] ADD FOREIGN KEY ([bookingFK]) REFERENCES [purchase] ([id])
GO

ALTER TABLE [productCategories] ADD FOREIGN KEY ([productFK]) REFERENCES [product] ([id])
GO

ALTER TABLE [productCategories] ADD FOREIGN KEY ([categoryFK]) REFERENCES [category] ([id])
GO
