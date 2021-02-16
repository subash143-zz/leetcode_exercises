-- https://leetcode.com/problems/not-boring-movies/
-- 620. Not Boring Movies

-- Write your MySQL query statement below

SELECT * FROM cinema
    WHERE ID%2 != 0 AND  description != 'boring'
    ORDER BY rating DESC;