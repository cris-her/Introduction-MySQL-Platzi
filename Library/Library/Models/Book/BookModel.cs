﻿using Library.Models.Author;

namespace Library.Models.Book;

public class BookModel
{
    private int book_id;
    private AuthorModel author;
    private string title;
    private int year;
    private string language;
    private string cover_url;
    private double price;
    private bool sellable;
    private int copies;
    private string description;
    private DateTime created_at;
    private DateTime updated_at;
    private bool active;

    public BookModel(
        int book_id,
        AuthorModel author,
        string title,
        int year,
        string language,
        string cover_url,
        double price,
        bool sellable,
        int copies,
        string description,
        DateTime created_at,
        DateTime updated_at,
        bool active)
    {
        this.book_id = book_id;
        this.author = author;
        this.title = title;
        this.year = year;
        this.language = language;
        this.cover_url = cover_url;
        this.price = price;
        this.sellable = sellable;
        this.copies = copies;
        this.description = description;
        this.created_at = created_at;
        this.updated_at = updated_at;
        this.active = active;
    }

    public BookModel()
    {
        book_id = 0;
        author = new();
        title = "";
        year = 0;
        language = "";
        cover_url = "";
        price = 0;
        sellable = false;
        copies = 0;
        description = "";
        created_at = DateTime.Now;
        updated_at = DateTime.Now;
        active = false;
    }

    public int Book_Id { get => book_id; set => book_id = value; }
    public AuthorModel Author { get => author; set => author = value; }
    public string Title { get => title; set => title = value; }
    public int Year { get => year; set => year = value; }
    public string Language { get => language; set => language = value; }
    public string Cover_url { get => cover_url; set => cover_url = value; }
    public double Price { get => price; set => price = value; }
    public bool Sellable { get => sellable; set => sellable = value; }
    public int Copies { get => copies; set => copies = value; }
    public string Description { get => description; set => description = value; }
    public DateTime Created_at { get => created_at; set => created_at = value; }
    public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    public bool Active { get => active; set => active = value; }
}
