using DevSkill.Library.Framwork;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore.Areas.Admin.Models
{
    public class BookModel:AdminBaseModel
    {
        private readonly IBookService _bookService;
        public BookModel(IConfiguration configuration)
        {
            _bookService = new BookService(configuration.GetConnectionString("DefaultConnection"));
        }

        internal object GetBooks(DataTableAjaxRequestModel tableModel)
        {
            //int total = 0;
            //int totalFiltered = 0;
            var data = _bookService.GetBooks(tableModel.PageIndex, tableModel.PageSize, tableModel.SearchText);
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.recoards
                        select new string[]
                        {
                            record.Id.ToString(),
                            record.Title,
                            record.Author,
                            record.PublicationDate.ToString(),
                            record.Edition,
                            record.Id.ToString()
                        }
                    ).ToArray()
            };
        }
    }
}
