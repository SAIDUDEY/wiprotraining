CREATE PROCEDURE CHECKPRODUCTEXISTS
@PRODUCTID INT
AS
BEGIN
IF EXISTS (SELECT * FROM PRODUCTS WHERE PRODUCTID = @PRODUCTID)
PRINT 'PRODUCT EXISTS';
ELSE
PRINT 'PRODUCT NOT EXISTS';
END;

EXEC CHECKPRODUCTEXISTS @PRODUCTID = 8;