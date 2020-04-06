using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapp.Models;

namespace firstapp.Models
{
    public class MockBookRepository : IBookRepository
    {   
        private List<BookModel> _bookList;        
         public MockBookRepository(){
           _bookList= new List<BookModel>(){
                new BookModel( 1, "Python", "Harish", "/images/download.jpg" ),
                new BookModel( 2, "MVC",  "Harish1" , "/images/photo-1507842217343-583bb7270b66.jpg"),
                new BookModel( 3, "Php",  "Harish2" , "/images/getty_883231284_200013331818843182490_335833.jpg"),
                new BookModel( 4, ".net",  "Harish3" , "/images/photo-1507842217343-583bb7270b66.jpg"),
                new BookModel( 5, ".net core",  "Harish4" , "/images/photo-1507842217343-583bb7270b66.jpg"),
                new BookModel( 6, "Angular",  "Harish5" , "/images/download (2).jpg"),
                new BookModel( 7, "React",  "Harish6" , "/images/literature-book-open-pages-1005324.jpg"),
           };
   
       }

       public BookModel GetEmployee(int id){
           return _bookList.FirstOrDefault(x => x.Id== id);
       }

       public IEnumerable<BookModel> GetAllEmployee(){
           return _bookList;
       }

    }
}