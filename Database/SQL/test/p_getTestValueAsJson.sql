 /*
  p_getTestValueAsJson:
  procedure that does a simple calculation to test the infrstructure

 */
if(exists (
  select *
    from sys.procedures
   where name = 'p_getTestValueAsJson'
     and schema_id = (select schema_id from sys.schemas where name = 'test')
))
begin
  drop procedure test.p_GetTestValueAsJson
end

go

create procedure test.p_getTestValueAsJson
@int int,
@message nvarchar(max),
@json nvarchar(max) output
as
begin

  select @json = '{"int":"'+convert(nvarchar(max),@int)+'",'
                +'"message":"'+@message+'",'
                +'"value":"okay"}'


end
