using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_tur_på_biblioteket
{
    internal class Books
    {
        private string[] book;
        Stack<string> ownedbooks = new Stack<string>();

        public string[] Book
        { 
            get { return book; }
            set { book = value; } 
        }
        public Stack<string> Ownedbooks
        {
            get { return ownedbooks; }
            set { ownedbooks = value; }
        }
        public void Generate()
        {
            string[] Book = { "Bambi", "Hunter's Guide", "Doomday", "Survival Guide", "The Sand", "Dear Diary" };
            this.Book = Book;
        }
        public void UI()
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("1: To Borrow\r\n\r\n2: To Retrieve\r\n\r\n");
                Console.WriteLine("\r\nBorrowed Books:\r\n" + String.Join(", ", this.Ownedbooks));
                if (this.Ownedbooks.Count > 0)
                Console.WriteLine("Next Book: "+this.Ownedbooks.Peek());
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Borrow();
                }
                else if (choice == "2")
                {
                    Retrieve();
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Choice Invalid"); Console.ResetColor();
                }
            } 
        }
        public void Borrow()
        {
            Console.Clear();
            Console.WriteLine("Select By ID Number");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("ID: '"+i+"' " + this.Book[i] +"\r\n");
            }
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int value))
            {
                int intchoice = Convert.ToInt32(choice);
                if (intchoice >= 0 && intchoice <= 5)
                {
                    this.Ownedbooks.Push(this.Book[intchoice]);
                    Console.Clear();
                    Console.WriteLine("You choose " + this.Book[intchoice]);
                }
                else
                {
                    Invalid();
                    Borrow();
                }
            }
            else
            {
                Invalid();
                Borrow();
            }
            UI();
        }
        public void Retrieve()
        {
            Console.Clear();
            this.Ownedbooks.Pop();
        }
        public void Invalid()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Choice Invalid"); Console.ResetColor();
        }
    }
}
