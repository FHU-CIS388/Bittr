﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Bittr.ViewModels
{
    public class PostViewModel : ContentView
    {
        string PostText { get; set; }
        public PostViewModel()
        {
            MessagingCenter.Subscribe<Views.PostPage>(this, "Post", (sender) => {
                SendString();
            });
        }

        public void SendString()
        {
            MessagingCenter.Send<PostViewModel, string>(this, "PostString", PostText);
        }
    }
}