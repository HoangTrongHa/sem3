

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace xBindingDataExample.Models

{

    public class Book

    {

        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string CoverImage { get; set; }

    }



    public class BookManager

    {

        public static List<Book> GetBooks()

        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "CO Chac Yeu La Day", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 3, Title = "Chac Ai Do Se Ve", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 4, Title = "Lac Troi", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 5, Title = "Em Cua Ngay Hom Qua", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 6, Title = "Hay Trao Cho Anh", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 7, Title = "Con Mua Ngang Qua", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 8, Title = "Thai Binh Mo Hoi Roi", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 9, Title = "Nang Am Xa Dan", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 10, Title = "Khuan Mat Dang Thuong", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 11, Title = "Gio Cuon Em Di", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 12, Title = "Khong Phai Dang Vua Dau", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 13, Title = "Mot Cong Mot Lon Hon Hai", Author = "Hoang Ha", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 14, Title = "Tien Len Viet Nam Oi", Author = "Hoang Ha", CoverImage= "Assets/1.jpg" });
            books.Add(new Book { BookId = 15, Title = "Vulpate", Author = "Hoang Ha", CoverImage= "Assets/1.jpg" });
            return books;

        }

    }

}