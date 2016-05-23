namespace GenTree.BaseRepositories.Contracts
{
    public interface IEntity<TId> where TId: class, new()
    {
        TId Id { get; set; }
    }
}
