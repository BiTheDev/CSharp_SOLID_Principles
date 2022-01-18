using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class ReferenceBook : IBook
    {
        public string Author { get; set; }
        public string LibraryId { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
    }
}
