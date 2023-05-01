using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces_Impressoras
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        private int resolucao = 300;
        private string tamanhoEtiqueta = "10cm x 5cm";
        private string tipoEtiqueta = "Papel adesivo"; 
        public string ImprimirEtiqueta(Produto produto){
            return $"Imprimindo etiqueta na Elgin\nProduto: Id: {produto.id} -  Código de barras: {produto.codBarras} - Preço: {produto.preco} \nResolução: {resolucao}.dpi, Tamanho etiqueta: {tamanhoEtiqueta}, Tipo da etiqueta: {tipoEtiqueta} \nImpresso com sucesso";
        }
    }
}