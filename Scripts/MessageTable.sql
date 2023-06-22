USE rendonracing;
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[messages]') AND type in (N'U'))

BEGIN
CREATE TABLE [dbo].[messages](
     [id] char(36) PRIMARY KEY NOT NULL DEFAULT NEWID(),
	 [key] char(50) NOT NULL,
	 [message] varchar(200) NOT NULL,
	 [isActive] bit NOT NULL DEFAULT 1
) 
END