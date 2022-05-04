namespace Controle_Frota.Models
{
    public class Marcas
    {
        public Guid MarcaId { get; set; }
        public ICollection<Veiculo> veiculos { get; set; }
    }


}
