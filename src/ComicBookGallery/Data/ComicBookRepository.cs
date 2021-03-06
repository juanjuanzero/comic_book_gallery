﻿using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook() //comic book model instantiation code
            {
            Id = 1,
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 700,
            DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            Artists = new Artist[] //start with instanciating the array
                {
                    new Artist() {Name = "Dan Slott", Role = "Script" }, //then add an Artist model property that would be inside the array for a total of 5 elements
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() {Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() {Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters" }
                }
            },

            new ComicBook()
            {
                Id = 2,
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 657,
            DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
            Artists = new Artist[]
            {
                new Artist() { Name = "Dan Slott", Role = "Script" },
                new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                new Artist() { Name = "Marcos Martin", Role = "Inks" },
                new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                new Artist() { Name = "Joe Caramagna", Role = "Letters" }
            },
            Favorite = false
            },

            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }

        };
        public ComicBook[] GetComicBooks() //created a method of that returns ComicBook objs and  returns the _comicBooks private field
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}