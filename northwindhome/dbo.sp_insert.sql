CREATE PROCEDURE [dbo].[sp_insert]
	
	@name varchar(50),
	@mail varchar(50),
	@Telefoon int,
	@Organisatie varchar(50)
	
AS
	insert into tbl_data values (@name,@mail,@Telefoon,@Organisatie)
RETURN
	
