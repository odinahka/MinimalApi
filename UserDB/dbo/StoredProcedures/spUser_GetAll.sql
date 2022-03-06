CREATE PROCEDURE [dbo].[spUser_GetAll]
	@param1 int = 0,
	@param2 int
AS
begin
	select Id, FirstName, LastName
	from dbo.[User];
end
