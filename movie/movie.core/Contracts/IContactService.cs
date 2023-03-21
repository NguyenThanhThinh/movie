using movie.core.ViewModels.Contacts;

namespace movie.core.Contracts
{
    public interface IContactService
    {
        Task GetUserSubmisionAsync(ContactInputViewModel model);

        Task<IEnumerable<ContactViewModel>> GetSubmisionsAsync();

        Task<ContactViewModel> GetSubmisionByIdAsync(int id);


        Task DeleteQuestionAsync(int id);
    }
}
