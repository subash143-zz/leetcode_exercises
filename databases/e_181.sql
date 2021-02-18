-- https://leetcode.com/problems/employees-earning-more-than-their-managers/
-- 181. Employees Earning More Than Their Managers

SELECT E.Name as Employee 
    FROM Employee as E
    WHERE E.Salary > (SELECT Salary FROM Employee AS M WHERE M.Id = E.ManagerId);