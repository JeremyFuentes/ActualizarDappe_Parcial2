using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SuppliersRepository
    {
        public List<Suppliers> ObtenerTodos()
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String proveedores = "";
                proveedores = proveedores + "SELECT [SupplierID] " + "\n";
                proveedores = proveedores + "      ,[CompanyName] " + "\n";
                proveedores = proveedores + "      ,[ContactName] " + "\n";
                proveedores = proveedores + "      ,[ContactTitle] " + "\n";
                proveedores = proveedores + "      ,[Address] " + "\n";
                proveedores = proveedores + "      ,[City] " + "\n";
                proveedores = proveedores + "      ,[Region] " + "\n";
                proveedores = proveedores + "      ,[PostalCode] " + "\n";
                proveedores = proveedores + "      ,[Country] " + "\n";
                proveedores = proveedores + "      ,[Phone] " + "\n";
                proveedores = proveedores + "      ,[Fax] " + "\n";
                proveedores = proveedores + "      ,[HomePage] " + "\n";
                proveedores = proveedores + "  FROM [dbo].[Suppliers]";

                var proveedor = conexion.Query<Suppliers>(proveedores).ToList();
                return proveedor;
            }
        }

        public Suppliers obtenerPorId(string id)
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String selectPorId = "";
                selectPorId = selectPorId + "SELECT [SupplierID], " + "\n";
                selectPorId = selectPorId + "      [CompanyName], " + "\n";
                selectPorId = selectPorId + "      [ContactName], " + "\n";
                selectPorId = selectPorId + "      [ContactTitle], " + "\n";
                selectPorId = selectPorId + "      [Address], " + "\n";
                selectPorId = selectPorId + "      [City], " + "\n";
                selectPorId = selectPorId + "      [Region], " + "\n";
                selectPorId = selectPorId + "      [PostalCode], " + "\n";
                selectPorId = selectPorId + "      [Country], " + "\n";
                selectPorId = selectPorId + "      [Phone], " + "\n";
                selectPorId = selectPorId + "      [Fax], " + "\n";
                selectPorId = selectPorId + "      [HomePage] " + "\n";
                selectPorId = selectPorId + "  FROM [dbo].[Suppliers] " + "\n";
                selectPorId = selectPorId + "  WHERE SupplierID = @SupplierID";

                // Corregimos el nombre del parámetro en la consulta
                var proveedor = conexion.QueryFirstOrDefault<Suppliers>(selectPorId, new { SupplierID = id });
                return proveedor;
            }
        }

        public int actualizarProveedor(Suppliers suppliers)
        {
            using (var conecion = Database.GetSqlConnection())
            {
                String updateProve = "";
                updateProve = updateProve + "UPDATE [dbo].[Suppliers] " + "\n";
                updateProve = updateProve + "   SET [CompanyName] = @CompanyName " + "\n";
                updateProve = updateProve + "      ,[ContactName] = @ContactName " + "\n";
                updateProve = updateProve + "      ,[ContactTitle] = @ContactTitle " + "\n";
                updateProve = updateProve + "      ,[Address] = @Address " + "\n";
                updateProve = updateProve + "      ,[City] = @City " + "\n";
                updateProve = updateProve + " WHERE SupplierID = @SupplierID";

                var actualizadas = conecion.Execute(updateProve, new
                {
                    SupplierID = suppliers.SupplierID,
                    CompanyName = suppliers.CompanyName,
                    ContactName = suppliers.ContactName,
                    ContactTitle = suppliers.ContactTitle,
                    Address = suppliers.Address,
                    City = suppliers.City,
                });

                return actualizadas;
            }
        }
    }
}
