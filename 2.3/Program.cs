 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = new Title("Навколо свiту за вiсiмдесят днiв	");
            var author = new Author("Жуль Верн");
            var content = new Content("пригодницький роман 1873 року заснований на реальнiй подорожi американця Джорджа Френсиса Трейна");
            Book book = new Book(author, title, content);
            book.Show();
            Console.ReadKey();
        }
    }
    class Book
    {
        private readonly Author authorsName;
        private readonly Title title;
        private readonly Content content;

        public Book(Author author, Title title, Content content)
        {
            this.authorsName = author;
            this.title = title;
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Iнформацiя про книгу: ");
            Console.Write("\n");
            authorsName.Show();
            title.Show();
            content.Show();

        }

    }
    class Title
    {
        private readonly string name;

        public Title(string titleName)
        {
            this.name = titleName;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Назва книги - {name}");
        }

    }
    class Author
    {
        private readonly string bookAuthor;

        public Author(string author)
        {
            this.bookAuthor = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Iм'я автора: - {bookAuthor}");
        }

    } 
    class Content
    {
        private readonly string contents;

        public Content(string bookcontent)
        {
            this.contents = bookcontent;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Змiст книги: - {contents}");
        }
    }
}
