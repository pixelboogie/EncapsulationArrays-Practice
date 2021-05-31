using System;

namespace CSharp_Inheritance
{
    class Program
    {
        static void Main()
        {           
            try
            {
                MediaLibrary myLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Book("On The Road", "Jack Kerouac"),
                    new Movie("Titanic", "James Cameron")
                });

                // MediaType[] mediaItem = new MediaType[3];
                // mediaItem[0] = new Album("Yellow Submarine", "The Beatles");
                // mediaItem[1] = new Book("On The Road", "Jack Kerouac");
                // mediaItem[2] = new Movie("Titanic", "James Cameron");
                // mediaItem[3] = new Album(null, "Null Artist");
                // mediaItem[4] = new Album("", "Empty Artist");
                // mediaItem[5] = new Album("", "Empty Artist");


                // for(int i=0; i<mediaItem.Length; i++)
                //     DetectMediaType(mediaItem[i]);

                for(int i=0; i<=2; i++)
                    DetectMediaType(myLibrary.GetItemAt(i));


                // for(int i=0; i<mediaItem.Length; i++)
                //     Display(mediaItem[i]);

                for(int i=0; i<=2; i++)
                    Display(myLibrary.GetItemAt(i));
                

                //Console.WriteLine(mediaItem[0].GetDisplayText());
                //Console.WriteLine(book1.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());
                // Console.WriteLine(album2.GetDisplayText());
                // Console.WriteLine(album3.GetDisplayText());

                // mediaItem[0].Loan("Joe Smith");
                // mediaItem[1].Loan("Book Girl");
                // mediaItem[2].Loan("Movie Dude");

                // Console.WriteLine(". . . . . Display after loaned out");

                // Console.WriteLine(mediaItem[0].GetDisplayText());
                // Console.WriteLine(mediaItem[1].GetDisplayText());
                // Console.WriteLine(mediaItem[2].GetDisplayText());

                // mediaItem[0].Return();
                // mediaItem[1].Return();
                // mediaItem[2].Return();

                // Console.WriteLine(". . . . . Display after return");

                // string a = mediaItem[0].GetDisplayText()

                // Console.WriteLine();
                // Console.WriteLine(book1.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void Display(MediaType item)
        {
            if(item == null)
            {
                return;
            }

            if (item is Movie)
            {
                Console.WriteLine(((Movie)item).GetDisplayText());
            }
            else if (item is Album)
            {
                Console.WriteLine(((Album)item).GetDisplayText());
            }
            else if(item is Book){
                Console.WriteLine(((Book)item).GetDisplayText());
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }


       static void DetectMediaType(MediaType item)
        {
            if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
            else if (item is Album)
            {
                Console.WriteLine(item.Title + " is a Album");
            }

            else if(item is Book){
                Console.WriteLine(item.Title + " is a Book");
            }

            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }



    }
}
