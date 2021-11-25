using BL.Domain.Exeptions;

namespace BL.Domain.Services
{
    public interface IArticleCategoryValidator
    {
        void ThisalreadyExistTitle(string title);

        void CkechingNullTitle(string title);





    }
}
