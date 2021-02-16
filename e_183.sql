-- https://leetcode.com/problems/customers-who-never-order/
-- 183. Customers Who Never Order

SELECT Name as Customers FROM
    Customers WHERE Id NOT IN 
        (SELECT CustomerId FROM Orders);