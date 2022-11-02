namespace CrowdSup.Domain.ValueObjects
{
    public class Endereco
    {
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }

        public Endereco(string cidade, string bairro, string rua, string numero)
        {
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }
    }
}