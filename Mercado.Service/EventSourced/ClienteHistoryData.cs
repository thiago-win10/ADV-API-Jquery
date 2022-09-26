namespace Mercado.Application.EventSourced
{
    public class ClienteHistoryData
    {
        public string Action { get; set; }
        public string ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public bool CartaoFidelidade { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int When { get; set; }
        public int Who { get; set; }

    }
}
