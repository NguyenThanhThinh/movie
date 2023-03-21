using movie.core.Contracts;
using movie.core.ViewModels.Contacts;
using movie.data.Entities;
using movie.data.Repositories;
using Microsoft.EntityFrameworkCore;
using movie.core.Messaging;

namespace movie.core.Services;

public class ContactService : IContactService
{
    private readonly IRepository<Contact> contactsRepository;

    public ContactService(
        IRepository<Contact> contactsRepository)
    {
        this.contactsRepository = contactsRepository;
    }

    public async Task GetUserSubmisionAsync(ContactInputViewModel model)
    {
        var submision = new Contact()
        {
            Name = model.Name,
            Email = model.Email,
            Subject = model.Subject,
            Message = model.Message
        };

        await contactsRepository.AddAsync(submision);
        await contactsRepository.SaveChangesAsync();
    }

    public async Task<IEnumerable<ContactViewModel>> GetSubmisionsAsync()
    {
        var submisions = await contactsRepository.AllAsNoTracking()
            .Select(x => new ContactViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Subject = x.Subject,
                Message = x.Message
            })
            .ToListAsync();

        return submisions;
    }

    public async Task<ContactViewModel> GetSubmisionByIdAsync(int id)
    {
        var submision = await contactsRepository
            .AllAsNoTracking()
            .Where(x => x.Id == id)
            .Select(x => new ContactViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Subject = x.Subject,
                Message = x.Message
            })
            .FirstOrDefaultAsync();

        if (submision == null) throw new NullReferenceException("The submision can not be null!");

        return submision;
    }

    public async Task DeleteQuestionAsync(int id)
    {
        var contact = await contactsRepository.AllAsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        if (contact == null) throw new NullReferenceException("The contact can not be null");

        contactsRepository.Delete(contact);

        await contactsRepository.SaveChangesAsync();
    }
}