using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _iApplicantService;

    public PttManager(IApplicantService iApplicantService)
    {
        _iApplicantService = iApplicantService;
    }

    public void GiveMask(Person person)
    {
        if (_iApplicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " için maske verildi.");
        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske verilemedi.");
        }
    }
}