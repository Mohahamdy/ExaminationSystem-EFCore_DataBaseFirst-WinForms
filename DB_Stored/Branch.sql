USE ITIDB;

------------------------------------branche table ---------------------------------------------------------
-- Select
CREATE PROCEDURE Select_Branche
AS
BEGIN
    SELECT * FROM branche
END;

-- Insert
CREATE PROCEDURE Insert_Branche
    @branch_ID int,
    @name nchar(50),
    @location nchar(50)
AS
BEGIN
    INSERT INTO branche ( name, location)
    VALUES ( @name, @location);
END;

-- Update
CREATE PROCEDURE Update_Branche
    @branch_ID int,
    @name nchar(50),
    @location nchar(50)
AS
BEGIN
    UPDATE branche
    SET name = @name, location = @location
    WHERE branch_ID = @branch_ID;
END;

-- Delete
CREATE PROCEDURE Delete_Branche
    @branch_ID int
AS
BEGIN
    DELETE FROM branche
    WHERE branch_ID = @branch_ID;
END;

