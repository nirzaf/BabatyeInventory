SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCloths]

    @SKUNumber nvarchar(30),
    @Name nvarchar (150),
    @Size nvarchar (25),
    @Color nvarchar (50)
AS
BEGIN
    IF EXISTS 
    (SELECT * FROM tbl_cloths
    WHERE tbl_cloths.SKU = @SKUNumber)
       UPDATE tbl_cloths SET Count = Count + 1 WHERE tbl_cloths.SKU = @SKUNumber
    ELSE 
    INSERT INTO tbl_cloths
        (SKU,Name,Size,Color)
    VALUES
        (@SKUNumber, @Name, @Size, @Color)
END
GO
