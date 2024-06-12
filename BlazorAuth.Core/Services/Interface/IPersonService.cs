using BlazorAuth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAuth.Core.Services.Interface
{
    public interface IPersonService
    {
        bool AddUpdate(Person person);
        bool Delete(int id);
        Person FindById(int id);
        List<Person> GetAll();
    }
}
