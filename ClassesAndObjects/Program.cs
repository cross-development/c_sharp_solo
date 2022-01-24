﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
        }
    }

    class Post
    {
        private string text;

        public Post()
        {
            Console.WriteLine("New Post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}