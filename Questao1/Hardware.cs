namespace Questao1
{
    class Hardware
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
        public string fabricante { get; set; }

        public string GetDetalhesHardware()
        {
            var produto = "";
            System.Console.WriteLine("ID: " + id);
            System.Console.WriteLine("Descrição: " + descricao);
            System.Console.WriteLine("Valor: " + valor);
            System.Console.WriteLine("Fabricante: " + fabricante);
            return produto;
        }

    }
}
