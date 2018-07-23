using System;
using System.Collections.Generic;
using Proquire.ViewModel;
using Xamarin.Forms;

namespace Proquire.View
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            this.BindingContext = new ChatPageViewModel();
        }
    }
}
