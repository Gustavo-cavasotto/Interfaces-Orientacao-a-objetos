using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces_Impressoras
{
    public interface IImpressoraDeCodigoDeBarras
    {
        string ImprimirEtiqueta(Produto produto);
    }
}