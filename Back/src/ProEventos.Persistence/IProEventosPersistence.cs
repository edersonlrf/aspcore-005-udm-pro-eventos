using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        #region Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entityArry) where T : class;
        Task<bool> SaveChangesAsync();
        #endregion

        #region  Eventos
        Task<Evento[]> GetAllEventosAsync(bool incluirPalestrantes);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool incluirPalestrantes);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool incluirPalestrantes);
        #endregion

        #region  Palestrantes
        Task<Palestrante[]> GetAllPalestrantesAsync(bool incluirEventos);
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool incluirEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool incluirEventos);
        #endregion
    }
}