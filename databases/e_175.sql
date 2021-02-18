-- https://leetcode.com/problems/combine-two-tables/
-- 175. Combine Two Tables

SELECT P.FirstName, P.LastName, A.City, A.State 
    FROM Person as P
    LEFT JOIN Address as A 
        ON P.PersonId = A.PersonId