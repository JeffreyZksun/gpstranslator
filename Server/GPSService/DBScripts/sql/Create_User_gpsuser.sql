/****** 对象:  Login [gpsuser]    脚本日期: 02/18/2011 22:12:30 ******/
/* For security reasons the login is created disabled and with a random password. */
/****** 对象:  Login [gpsuser]    脚本日期: 02/18/2011 22:12:30 ******/
CREATE LOGIN [gpsuser] WITH PASSWORD=N'×¾ûò§s¾Ë:4 É¹ê M_°Ðü¾< â+', DEFAULT_DATABASE=[GPS], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'sysadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'securityadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'serveradmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'setupadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'processadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'diskadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'dbcreator'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'gpsuser', @rolename = N'bulkadmin'
GO
ALTER LOGIN [gpsuser] DISABLE