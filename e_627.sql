-- https://leetcode.com/problems/swap-salary/
-- 627. Swap Salary

-- Write your MySQL query statement below

UPDATE salary 
SET 
    sex = CASE sex
        WHEN 'm' THEN 'f'
        ELSE 'm'
    END;