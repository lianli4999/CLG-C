// See https://aka.ms/new-console-template for more information

namespace BookClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library?");

            
            var recommendedBooks = StateRecommendations();
            var members = CreateMembers(recommendedBooks);


            // print list of recommended books to the console.

            foreach(var member in members)
            {
                Console.WriteLine($"{member.firstName}'s favourite book is: {member.favouriteBook}");

                Console.WriteLine($"Books on {member.firstName}'s reading list:");
                foreach (var book in member.readingList)
                {
                    // Write book title and author to the console
                    Console.WriteLine($"Book title: {book.title}\n Author: {book.author}");
                }
            }
        }

        static List<Member> CreateMembers(List<Book> recommendedBooks)
        {
            var person1 = new Member
            {
                firstName = "Jane",
                lastName = "Doe",
                favouriteBook = "a christmas carol",
                readingList = new List<Book> {recommendedBooks[0]}
            };
           // person1.readingList.Add

            var person2 = new Member
            {
                firstName = "Matt",
                lastName = "Smith",
                favouriteBook = "the bible",
                readingList = new List<Book> {recommendedBooks[1]}
            };

            var person3 = new Member
            {
                firstName = "Tae",
                lastName = "Yeon",
                favouriteBook = "twilight",
                readingList = new List<Book> {recommendedBooks[2]}
            };


            var members = new List<Member> { 
                person1, person2, person3
            };

            return members;
        }


        static List<Book> StateRecommendations()   
        {
            var book1 = new Book

            {
                title = "title of book1",
                author = "author of book1"
            };

            var book2 = new Book

            {
                title = "title of book2",
                author = "author of book2"
            };


            var book3 = new Book

            {
                title = "title of book3",
                author = "author of book3"
            };

            var recommendedBooks = new List<Book> {book1, book2, book3};

            return recommendedBooks;

        } 
    }

    public class Member
    {
        public string firstName;
        public string lastName;

        // add a field to hold the member's favourite book
        public string favouriteBook;
        public List<Book> readingList;

        public void displayFavourites()
        {
            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Favourite Book: {favouriteBook}");
        }
    }

    public class Book
    {
        public string title;
        public string author;
    }
}
        //Display in the console a list of all the members along with their favourite book.
