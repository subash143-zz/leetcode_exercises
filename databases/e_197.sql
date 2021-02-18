-- https://leetcode.com/problems/rising-temperature/
-- 197. Rising Temperature

SELECT W1.Id as Id FROM Weather W1, Weather W2
    WHERE DATEDIFF(W1.recordDate,W2.recordDate)=1 
            AND W1.Temperature > W2.Temperature;