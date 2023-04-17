using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class ToDoItem
    {
        public string FileName { set; get; }
        public bool IsSaved { set; get; }

        public ToDoItem()
        {
            FileName = null;
            IsSaved = true;
        }
    }
}
