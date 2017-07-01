using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models.Common
{
    public interface IModel
    {
        int Id { get; set; }
    }

    public interface IModelHasName : IModel
    {
        string Name { get; }
    }

    public interface IModelHasDateCreate : IModel
    {
        DateTime DateCreate { get; set; }
    }

}
