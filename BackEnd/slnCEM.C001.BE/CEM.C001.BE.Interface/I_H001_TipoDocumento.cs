using CEM.C001.BE.Model;
using System.Collections.Generic;

namespace CEM.C001.BE.Interface
{
    public interface I_H001_TipoDocumento
    {
        List<H001_TipoDocumento> ListarTipoDocumento(int option);
    }
}
