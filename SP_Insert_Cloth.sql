SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertClothes]

  @SKUNumber nvarchar(30)
AS 
  BEGIN 
       UPDATE tbl_cloths SET Count = Count + 1 WHERE tbl_cloths.SKU = @SKUNumber
  END
GO
