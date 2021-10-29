use PTTK;

-- 1.1 sp_auth_login
DROP PROCEDURE IF EXISTS [dbo].[sp_auth_login];
GO
CREATE PROCEDURE [dbo].[sp_auth_login]
	@username nchar(20),
	@password nchar(100)
AS
	select * from tblUser where username = @username and password = @password
GO

--1.2 Get List Nha Cung Cap