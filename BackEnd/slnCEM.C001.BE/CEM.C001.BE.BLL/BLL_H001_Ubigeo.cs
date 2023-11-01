using CEM.C001.BE.DAL;
using CEM.C001.BE.Interface;
using CEM.C001.BE.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace CEM.C001.BE.BLL
{
    public class BLL_H001_Ubigeo:IDisposable
    {
        readonly IConfiguration _configuration;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public BLL_H001_Ubigeo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<H001_Ubigeo> ListarDepartamento(int option)
        {
            I_H001_Ubigeo instancia = new DAL_H001_Ubigeo(_configuration);
            return instancia.ListarDepartamento(option);
        }
        public List<H001_Ubigeo> ListarProvincia(int option, string psCodDepartamento)
        {
            I_H001_Ubigeo instancia = new DAL_H001_Ubigeo(_configuration);
            return instancia.ListarProvincia(option, psCodDepartamento);
        }
        public List<H001_Ubigeo> ListarDistrito(int option, string psCodDepartamento, string psCodProvincia)
        {
            I_H001_Ubigeo instancia = new DAL_H001_Ubigeo(_configuration);
            return instancia.ListarDistrito(option, psCodDepartamento, psCodProvincia);
        }


    }
}
