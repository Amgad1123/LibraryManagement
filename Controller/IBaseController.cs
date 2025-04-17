using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal interface IBaseController
    {
        void ViewItems();
        void AddItem();
        void DeleteItem();
    }
}
