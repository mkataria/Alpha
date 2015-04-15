IF EXISTS (SELECT 1 FROM sys.objects WHERE name = 'Rates_del') BEGIN
	DROP PROC Rates_del
END
Go

CREATE PROC [dbo].[Rates_del]	@Id intASSET NOCOUNT ONUPDATE RatesSET IsActive = 0 WHERE [Id] = @IdSET NOCOUNT OFFGO