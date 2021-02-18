-- https://leetcode.com/problems/big-countries/
-- 595. Big Countries

-- Write your MySQL query statement below

SELECT name, population, area From World WHERE population > 25000000 OR area > 3000000