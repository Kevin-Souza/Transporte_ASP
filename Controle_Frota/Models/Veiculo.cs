namespace Controle_Frota.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string MarcaId { get; set; }
        public Marcas Marca { get; set; }
        public string Oficina { get; set; }
        //public Setores Setor  { get; set; }
        public string Tipo { get; set; }
    }
}
