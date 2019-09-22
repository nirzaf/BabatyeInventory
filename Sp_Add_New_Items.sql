SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewItem]

  @SKUNumber nvarchar(30),
  @Name nvarchar (150),
  @Size nvarchar (25),
  @Color nvarchar (50)
AS 
  BEGIN 
       INSERT INTO tbl_cloths (SKU,Name,Size,Color) VALUES (@SKUNumber,@Name,@Size,@Color) 
  END
GO
