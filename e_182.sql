-- https://leetcode.com/problems/duplicate-emails/
-- 182. Duplicate Emails

-- Write your MySQL query statement below

SELECT Email from(
    SELECT Email, COUNT(Email) as NUM
    FROM person
    group by Email
    ) AS STATISTIC -- STATISTIC is just an alias for a derived table
    WHERE NUM > 1;