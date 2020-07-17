using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Conlection
{
    class Forum
    {
        public SortedList<int, Post> PostList = new SortedList<int,Post>();
        public static int findid=0;
        public void Add(Post post1)
        {
            PostList.Add(post1.id,post1);
        }
        public void UpDate(int id)
        {
            if (PostList.ContainsKey(id))
            {
                Console.WriteLine("enter content: ");
                PostList[id].content = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void Remove(int id)
        {
            if (PostList.ContainsKey(id))
            {
                PostList.Remove(id);
            }

            else
            {
                Console.WriteLine("not allow");
            }
        }
        public void Show()
        {
              foreach (var key in PostList.Keys)
                {
                PostList[key].DisPlay();
                }            
        }
        public void FindByAuthor(string author)
        {
            int pos = -1;
            foreach (var authorkey in PostList.Keys)
            {
                if(PostList[authorkey].author == author)
                {
                    pos = authorkey;
                    break;
                }
            }

            if (pos != -1)
            {
                PostList[pos].DisPlay();
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public bool FindById(int id)
        {
            foreach(var item in PostList.Keys)
            {
                if(id== item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}