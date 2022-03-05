// See https://aka.ms/new-console-template for more information
using LendingLibrary;
using System.Collections.Generic;


// can create type borrower too instead of string
var borrowers = new List<string>{"Joy", "Marta", "Yuko", "Anjen"};


// fixes type error
var novelOne = new LendingLibrary.Novel("A Christmas Carol", Convert.ToInt32(1843), "Charles Dickens", "Fantasy");

// create library first before adding novels
var Library = new Library("Test Library");

// add novel
Library.AddNovel(novelOne);


namespace LendingLibrary
{
    public class Book : Media
    {
        public string Author;
    }

    public class Media
    {
        public string Title;
        public int PublicationYear;
    }

    public class CD : Media
    {
        public int NumberOfTracks;
 
    }

    public class Album
    {
        public string Artist;
    }

    public class AudioBook : Book
    {
        public string Author;
    }

    public class TextBook : Book
    {
        public string Subject;
    }


    public class Novel : Book
    {
        public string Genre;

        public Novel(string title, int publicationyear, string author, string genre)
        {
            Title = title;
            PublicationYear = publicationyear;
            Author = author;
            Genre = genre;
            Console.WriteLine($"Title: {Title}\nPublication Year: {PublicationYear}\nAuthor: {Author}\nGenre: {Genre}");
        }
    }

    public class Library
    {
        public List<Novel> Novels;
        public List<TextBook> TextBooks;
        public List<Album> Albums;
        public List<AudioBook> AudioBooks;

        public string LibName;


        public Library(string libName)
        {
            LibName = libName;
            Novels = new List<Novel> {};
            TextBooks = new List<TextBook> {};
            Albums = new List<Album> {};
            AudioBooks = new List<AudioBook> {};
        }

        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        public void AddTextBook(TextBook textbook)
        {
            TextBooks.Add(textbook);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddAudioBook(AudioBook audiobook)
        {
            AudioBooks.Add(audiobook);
        }

    }
}