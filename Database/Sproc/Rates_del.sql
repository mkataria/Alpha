IF EXISTS (SELECT 1 FROM sys.objects WHERE name = 'Rates_del') BEGIN
	DROP PROC Rates_del
END
Go

CREATE PROC [dbo].[Rates_del]