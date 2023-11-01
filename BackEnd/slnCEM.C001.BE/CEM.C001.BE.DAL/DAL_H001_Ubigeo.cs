using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CEM.C001.BE.DAL
{
    public class DAL_H001_Ubigeo:I_H001_Ubigeo
    {
        private string database;
        public DAL_H001_Ubigeo(IConfiguration config)
        {
            database = config["Database:CNX"];
        }
   
        public List<H001_Ubigeo> ListarDepartamento(int option)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@option", option);

                using (var connection = new SqlConnection(database))
                {
                    return connection.Query<H001_Ubigeo>("[dbo].[sps_H001_Departamento]", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<H001_Ubigeo> ListarProvincia(int option, string psCodDepartamento){
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@option", option);
                parameters.Add("@cod_departamento", psCodDepartamento);

                using (var connection = new SqlConnection(database))
                {
                    return connection.Query<H001_Ubigeo>("[dbo].[sps_H001_Provincia]", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<H001_Ubigeo> ListarDistrito(int option, string psCodDepartamento, string psCodProvincia)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@option", option);
                parameters.Add("@cod_departamento", psCodDepartamento);
                parameters.Add("@cod_provincia", psCodProvincia);

                using (var connection = new SqlConnection(database))
                {
                    return connection.Query<H001_Ubigeo>("[dbo].[sps_H001_Ubigeo]", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}