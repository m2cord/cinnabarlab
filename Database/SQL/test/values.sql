 /*
  test.values:
  procedure that does a simple calculation to test the infrstructure

 */
if(exists (
  select *
    from sys.tables
   where name = 'values'
     and schema_id = (select schema_id from sys.schemas where name = 'test')
))
begin
  drop table test.[values]
end

go

create table test.[values]
(
  [count]     int           not null,
  [value]     nvarchar(max) not null
)

insert into test.[values] ([count], [value])
  select 5,'Mewtwo is cooler than Falco.'
  union
  select 20,'also cooler than Fox.'
