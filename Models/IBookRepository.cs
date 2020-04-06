using System;
using System.Collections.Generic;

namespace firstapp.Models
{
    public interface IBookRepository
    {
       BookModel GetEmployee(int Id);   
       IEnumerable<BookModel> GetAllEmployee();
    }
}