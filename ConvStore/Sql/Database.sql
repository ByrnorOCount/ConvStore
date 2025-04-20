	IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ConvStore_DB')
	BEGIN
		CREATE DATABASE ConvStore_DB;
	END;
	GO

	USE ConvStore_DB;
	GO