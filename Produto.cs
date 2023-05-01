using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces_Impressoras
{
    public class Produto
    {
        public int id { get; protected set; }
        public string codBarras { get; protected set; }
        public float preco { get; protected set; }

        public Produto(int id, string codBarras, float preco)
        {
            this.id = id;
            this.codBarras = codBarras;
            this.preco = preco;
        }

        
    }


}