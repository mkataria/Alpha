
If exists (select name from sys.databases where name = 'Alpha')
begin
	use master
	drop database Alpha
end

Create database Alpha
go