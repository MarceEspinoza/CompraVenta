USE [bdCV2]
GO
/****** Object:  StoredProcedure [dbo].[paInsertarPersonal]    Script Date: 06/28/2014 00:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paInsertarPersonal]
@nombre nvarchar(50),
@apellidos nvarchar(50),
@f_nacimiento date,
@f_ingreso date,
@sexo nvarchar(10),
@foto image,
@c_elec nvarchar(50),
@direccion nvarchar(50), 
@telefono nvarchar(10), 
@ci nvarchar(10), 
@ci_l_exp nvarchar(30), 
@tipo_personal nvarchar(20),
@usuario nvarchar(50),
@clave nvarchar(50), 
@Mensaje nvarchar(50) output /* Devuelve un valor de tipo cadena*/

AS
Declare @ExisteCI int
Declare @ExisteUsr int
/*
Si existe un registro con el mismo número de Carnet de Identidad entonces
el personal ya esta registrado por lo tanto no se registrará y devolverá
un error, caso contrario si no existe entonces se le registrará 
al nuevo personal.
*/
Set @ExisteCI = (SELECT COUNT(*) AS Cantidad FROM t_personal WHERE (ci = @ci)) 
Set @ExisteUsr = (SELECT COUNT(*) AS Cant FROM t_usuario WHERE (usuario = @usuario)) 
if @ExisteCI = 0
Begin 
   if @ExisteUsr = 0
   Begin
	   /*generador de códigos en formato: PERS-0001, PERS-0002,...PERS-9999*/
	   Declare @cod_personal nvarchar(20)  /*Delcara la variable cod_personal*/
	   Declare @cr int  /*Declaa la variable Cantidad de Registros*/
	   Set @cr = (Select count(*) FROM t_Personal)  /*Cuenta la cantidad de registros que tiene la tabla t_personal*/
	   Set @cr=@cr+1  /*incrementa la cantidad de registros en 1*/
						   /*Genera el código con el formato PERS-0001...*/
	   SET @cod_personal = 'PERS-' + REPLICATE('0', 4 - LEN(CAST(@cr AS VARCHAR(20)))) + CAST(@cr AS VARCHAR(20));
	   /* fin del generador de códigos */
	   
	   INSERT INTO t_personal
		  (cod_personal, nombre, apellidos, f_nacimiento, f_ingreso, sexo, foto, c_elec, direccion, telefono, ci, ci_l_exp, tipo_personal, estado)
		  VALUES (@cod_personal,@nombre,@apellidos,@f_nacimiento,@f_ingreso,@sexo,@foto,@c_elec,@direccion,@telefono,@ci,@ci_l_exp,@tipo_personal, 'Activo')
	
	   IF @tipo_personal='Limpieza'
	    INSERT INTO t_limpieza (cod_personal) VALUES (@cod_personal)
	   ELSE
	   BEGIN
			INSERT INTO t_usuario (usuario, clave, cod_personal) VALUES (@usuario,@clave,@cod_personal)
			
			IF @tipo_personal='Administrador'
	          INSERT INTO t_administrador (cod_personal) VALUES (@cod_personal)
			
			IF @tipo_personal='Cajero de Ventas'
	          INSERT INTO t_cajero_ventas (cod_personal) VALUES (@cod_personal)

			IF @tipo_personal='Auxiliar de Ventas'
	          INSERT INTO t_auxiliar_v (cod_personal) VALUES (@cod_personal)
	   END
	   Set  @Mensaje ='Registrado'
   end
   Else
   Begin
       Set  @Mensaje ='Aún NO registrado. Nombre de usuario duplicado'
   End
End
Else
Begin
   Set  @Mensaje ='Aún NO registrado. Número de C.I. ya existe'
End