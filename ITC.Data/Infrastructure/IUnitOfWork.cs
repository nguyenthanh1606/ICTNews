namespace ITC.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}