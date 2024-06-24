USE DBPerfumeria_Cosmos
GO

CREATE PROCEDURE ObtenerPermisosPorEmpleado
    @IDEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.FKRol, p.NombreMenu
    FROM PERMISO p
    INNER JOIN Rol r ON r.IDRol = p.FKRol
    INNER JOIN EMPLEADO e ON e.FKRol = r.IDRol
    WHERE e.IDEmpleado = @IDEmpleado;
END
GO
