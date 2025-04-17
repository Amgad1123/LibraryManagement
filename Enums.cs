using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Enums
    {
        internal enum MenuAction
        {
            ViewItems,
            AddItem,
            DeleteItem
        }

        internal enum ItemType
        {
            Book, 
            Magazine, 
            Newspaper
        }
    }
}
