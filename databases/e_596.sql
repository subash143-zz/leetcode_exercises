-- https://leetcode.com/problems/classes-more-than-5-students/
-- 596. Classes More Than 5 Students

SELECT class FROM courses
    GROUP BY class
    HAVING COUNT(DISTINCT(Student)) >= 5