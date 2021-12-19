using referenceCaseWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenceCaseWebApp.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
