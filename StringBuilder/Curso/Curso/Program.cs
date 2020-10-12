using System;
using Curso.Entities;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice Trip!");
            Comment c2 = new Comment("Wow it´s awsome!");
            Post p1 = new Post(DateTime.Parse("21/06/2020 13:05:44"),
                               "Poste1 no app",
                               "Travelling  to newZealeand",
                                12);

            p1.AddComment(c1);
            p1.AddComment(c2);
            Comment c3 = new Comment("Ola!");
            Comment c4 = new Comment("Lgal");
            Post p2 = new Post(DateTime.Parse("22/06/2020 14:05:44"),
                               "Poste2",
                               "Travelling  to EUA",
                                2);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
