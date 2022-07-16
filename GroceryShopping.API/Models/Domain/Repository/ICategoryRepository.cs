namespace GroceryShopping.API.Models.Domain.Repositoty
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
