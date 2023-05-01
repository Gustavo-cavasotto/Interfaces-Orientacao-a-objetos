using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces_Impressoras
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {

        private int resolucao = 600;
        private string tamanhoEtiqueta = "15cm x 7cm";
        private string tipoEtiqueta = "Poliéster";

        public string ImprimirEtiqueta(Produto produto)
        {
            return $"Imprimindo etiqueta na Zebra\nProduto: Id: {produto.id} -  Código de barras: {produto.codBarras} - Preço: {produto.preco} \nResolução: {resolucao}.dpi, Tamanho etiqueta: {tamanhoEtiqueta}, Tipo da etiqueta: {tipoEtiqueta} \nImpresso com sucesso";
        }
    }
}