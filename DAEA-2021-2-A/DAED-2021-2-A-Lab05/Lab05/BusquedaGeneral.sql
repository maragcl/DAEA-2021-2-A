

/*
Para lograr lo requerido hay muchas opciones, 
como crear diversos procedimientos para cada tipo de búsqueda, 
pero también podemos apoyarnos en las cláusulas de SQL Server 
que nos permiten realizar búsquedas de varias columnas a la vez.

*/
create proc BuscarGeneral
 @Busqueda nvarchar(50)  
as   
select * from Person 
where	PersonID like '%'+ @Busqueda + '%' or
		FirstName like '%'+ @Busqueda + '%' or
		LastName like '%'+ @Busqueda + '%';

