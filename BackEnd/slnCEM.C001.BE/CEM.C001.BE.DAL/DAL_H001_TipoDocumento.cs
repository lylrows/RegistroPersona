using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static Dapper.SqlMapper;

namespace CEM.C001.BE.DAL
{
    public class DAL_H001_TipoDocumento: I_H001_TipoDocumento
    {
        private string database;
        public DAL_H001_TipoDocumento(IConfiguration config)
        {
            database = config["Database:CNX"];
        }
        public List<H001_TipoDocumento> ListarTipoDocumento(int option){
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@option", option);

                using (var connection = new SqlConnection(database))
                {
                    return connection.Query<H001_TipoDocumento>("[dbo].[sps_H001_TipoDocumento]", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}