SELECT
PRODUCTS.PRODUCTNAME,
SUM(ORDERS.QUANTITY) AS TOTALUNITSOLD
FROM ORDERS
INNER JOIN PRODUCTS ON ORDERS.PRODUCTID = PRODUCTS.PRODUCTID
GROUP BY PRODUCTS.PRODUCTNAME;