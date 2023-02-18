namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string? nome;
        public string? descricao;
        public double preco;

        public void MostrarAtributos()
        {

            System.Console.WriteLine("codigo: " + codigo);
            System.Console.WriteLine("nome: " + nome);
            System.Console.WriteLine("Descrição: " + descricao);
            System.Console.WriteLine("preço: " + preco);

        }
    }


}