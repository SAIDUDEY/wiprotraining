select
NAME,
DEPARTMENT,
SALARY,
ROW_NUMBER() OVER(PARTITION BY DEPARTMENT ORDER BY SALARY DESC) AS ROWNUM
FROM EMPLOYEES;