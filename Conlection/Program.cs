using System;

namespace Conlection
{
    class Program
    {
        public static Forum forumlist = new Forum();
        public static void Menu()
        {
            Console.WriteLine("1.Create Post");
            Console.WriteLine("2.Update Post");
            Console.WriteLine("3.Remove Post");
            Console.WriteLine("4.Show Posts");
            Console.WriteLine("5.Search");
            Console.WriteLine("6.Rating");
            Console.WriteLine("7.Exit");
        }
        static void CreatePost()
        {
            Console.WriteLine($"Enter Title:");
            string title = Console.ReadLine();

            Console.WriteLine($"Enter Author:");
            string author = Console.ReadLine();

            Console.WriteLine($"Enter Content:");
            string content = Console.ReadLine();

            Post post1 = new Post(title, author, content);
            forumlist.Add(post1);

        }
        static void UpdatePost()
        {
            Console.WriteLine("Enter id to update: ");
            int idupdate = Convert.ToInt32(Console.ReadLine());
            forumlist.UpDate(idupdate);
        }
        static void Ratting()
        {
            Console.WriteLine("Enter id to ratting : ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (forumlist.FindById(id))
            {
                Console.WriteLine("Enter count want to rating (1-10):");
                int count = Convert.ToInt32(Console.ReadLine());
                //so luong lan nhap danh gia cho post
                for (int i=0;i< count;i++)
                {
                    Console.WriteLine($"enter rate {i+1}");
                    int rateValue =Convert.ToInt32(Console.ReadLine());
                    forumlist.PostList[id].ratesList.Add(rateValue);
                }

                forumlist.PostList[id].CalculatorRate();
            }
            else
            {
                Console.WriteLine("Invalid Post ");
            }
        }
        static void Search()
        {
            Console.WriteLine("Enter author to search:");
            string searchbyauthor = Convert.ToString(Console.ReadLine());
            forumlist.FindByAuthor(searchbyauthor);
        }
        static void RemovePost()
        {
            Console.WriteLine("Enter id to remove : ");
            int idremove = Convert.ToInt32(Console.ReadLine());
            forumlist.Remove(idremove);
        }
        static void ShowPost()
        {
            forumlist.Show();
        }
        static void Main()
        {
            do
            {
                Menu();
                int check = int.Parse(Console.ReadLine());
                if (check == 7)
                {
                    break;
                }
                switch (check)
                {
                    case 1:
                        CreatePost();
                        break;
                    
                    case 2:
                        UpdatePost();
                        break;
                    
                    case 3:
                        RemovePost();
                        break;
                   
                    case 4:
                        ShowPost();
                        break;

                    case 5:
                        Search();
                        break;

                    case 6:
                        Ratting();
                        break;
                }
            } while (true);
        }     
               
    }
}
