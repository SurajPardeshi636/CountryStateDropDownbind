select * from CountryMaster
select * from StateMaster
select * from CityMaster


select * from tbl_country

create proc DropCountry
As
Begin
Select * From CountryMaster 
End

exec DropCountry

alter proc DropState
@Country_id int
As
Begin
Select State_id,State_Name from StateMaster where Country_id=@Country_id
End

exec  DropState 2

alter proc DropCity
@State_id int
As
Begin
Select City_ID,City_Name from CityMaster where State_id=@State_id
End

select*from CityMaster where State_id=

exec  DropCity 1
