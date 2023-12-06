using Service.Ricardo.Models;

namespace Service.Ricardo
{
    public interface IRicardoService
    {
        List<Recette> GetRecettes();
    }
}