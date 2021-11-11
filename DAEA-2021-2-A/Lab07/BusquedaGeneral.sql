

/*
Para lograr lo requerido hay muchas opciones, 
como crear diversos procedimientos para cada tipo de b�squeda, 
pero tambi�n podemos apoyarnos en las cl�usulas de SQL Server 
que nos permiten realizar b�squedas de varias columnas a la vez.

*/
create proc BuscarGeneral
 @Busqueda nvarchar(50)  
as   
select * from Person 
where	PersonID like '%'+ @Busqueda + '%' or
		FirstName like '%'+ @Busqueda + '%' or
		LastName like '%'+ @Busqueda + '%';

