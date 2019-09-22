SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetName]
  @SKUNumber nvarchar(30)
AS 
  BEGIN 
       SELECT tbl_cloths.Name FROM tbl_cloths Where SKU =  @SKUNumber;
  END
GO
