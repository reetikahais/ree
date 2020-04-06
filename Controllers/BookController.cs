using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapp.Models;
//using firstapp.Repositary;

namespace firstapp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepositary = null;
        public BookController( IBookRepository bookRepository){

           _bookRepositary = bookRepository;
        }
        public string Index(){
            return _bookRepositary.GetEmployee(1).Title;
        //    var data =  _bookRepositary.GetAllBooks();
        //    //return _bookRepositary.GetAllBooks();
        //    ViewData["Books"] = data;
        //    ViewData["Title"] = "Get All Books";
        //    return View();
        }

        public ViewResult GetAllBooks(){
            
           BookModel data =  _bookRepositary.GetEmployee(1);
           var getall =  _bookRepositary.GetAllEmployee();
           //return _bookRepositary.GetAllBooks();
           ViewData["Books"] = data;
           ViewData["Title"] = "My Book Store .....";
           ViewData["AllBooks"] = getall;
           return View();
        }

        // public BookModel GetBook(int id){
        //    return _bookRepositary.GetBook(id);
        // }

        // public List<BookModel> SearchBooks(string title, string author){
        //    return _bookRepositary.SearchBook(title, author);
        // }
    }
}
