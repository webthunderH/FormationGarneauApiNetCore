namespace BaseDeDonneeSql
{
    public interface IUnitOfWork
    {
        void SaveChange();
        void SaveChangesAsync();
    }
}