-- https://leetcode.com/problems/delete-duplicate-emails/
-- 196. Delete Duplicate Emails

DELETE P1 FROM Person P1, Person P2
    WHERE p1.Email = P2.Email AND
        p1.Id > p2.Id;