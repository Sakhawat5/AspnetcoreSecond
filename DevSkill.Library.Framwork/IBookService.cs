using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSkill.Library.Framwork
{
    public interface IBookService
    {
        (IList<Book> recoards, int total, int totalDisplay) GetBooks(int pageIndex,
                                                                        int pageSize, 
                                                                        string searchText);
    }
}
