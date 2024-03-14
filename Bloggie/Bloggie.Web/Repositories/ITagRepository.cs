using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface ITagRepository
    {
        Task<Tag> AddAsync(Tag tag);

        Task<Tag?> DeleteAsync(Guid id);

        Task<IEnumerable<Tag>> GetAllAsync();

        Task<Tag?> GetAsync(Guid id);

        Task<Tag?> UpdateAsync(Tag tag);
    }
}
