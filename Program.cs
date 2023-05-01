using Interfaces_Impressoras;

List <IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras>();
impressoras.Add(new Elgin());
impressoras.Add(new Zebra());

Console.WriteLine("Informe o código de barras do produto:");
        string codigoBarras = Console.ReadLine();

        Produto produto = new Produto(1, codigoBarras, 10);
        

        foreach (var impressora in impressoras)
        {
            Console.WriteLine(impressora.ImprimirEtiqueta(produto)); 
        }

        
