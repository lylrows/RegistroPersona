using CEM.C001.BE.Model;
using System.Collections.Generic;


namespace CEM.C001.BE.Interface
{
    public interface I_H001_Ubigeo
    {
        List<H001_Ubigeo> ListarDepartamento(int option);
        List<H001_Ubigeo> ListarProvincia(int option, string psCodDepartamento);
        List<H001_Ubigeo> ListarDistrito(int option, string psCodDepartamento, string psCodProvincia);

    }
}
