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

namespace CEM.C001.BE.DAL{
    public class DAL_H001_Persona : I_H001_Persona
    {
        private string database;

        public DAL_H001_Persona(IConfiguration config)
        {
            database = config["Database:CNX"];
        }
    
        public ResultEntity InsertarPersona(H001_Persona poH001_Persona){
            try
            {
                ResultEntity result = new ResultEntity();
                var parameters = new DynamicParameters();
                parameters.Add("@cod_persona", poH001_Persona.CodPersona);
                parameters.Add("@id_tipo_documento", poH001_Persona.IdTipoDocumento);
                parameters.Add("@num_doc_identidad", poH001_Persona.NumDocIdentidad);
                parameters.Add("@nombre", poH001_Persona.Nombre);
                parameters.Add("@apellido_paterno", poH001_Persona.ApellidoPaterno);
                parameters.Add("@apellido_materno", poH001_Persona.ApellidoMaterno);
                parameters.Add("@fecha_nacimiento", poH001_Persona.FechaNacimiento);
                parameters.Add("@sexo", poH001_Persona.Sexo);
                parameters.Add("@correo", poH001_Persona.Correo);
                parameters.Add("@telefono_movil", poH001_Persona.TelefonoMovil);
                parameters.Add("@cod_ubigeo_nacimiento", poH001_Persona.CodUbigeoNacimiento);

                using (var connection = new SqlConnection(database))
                {
                    var resulta = connection.QueryFirstOrDefault<ResultEntity>("[dbo].[spi_H001_Persona]", parameters, commandType: System.Data.CommandType.StoredProcedure);
                    return resulta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}