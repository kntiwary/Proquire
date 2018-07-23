﻿using System;
using System.Collections.Generic;
using Proquire.ViewModel;
using Xamarin.Forms;

namespace Proquire.View.Partials
{
    public partial class ChatInputBarView : ContentView
    {
        public ChatInputBarView()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                this.SetBinding(HeightRequestProperty, new Binding("Height", BindingMode.OneWay, null, null, null, chatTextInput));
            }
        }
        public void Handle_Completed(object sender, EventArgs e)
        {
            (this.Parent.Parent.BindingContext as ChatPageViewModel).OnSendCommand.Execute(null);
            chatTextInput.Focus();

            // (this.Parent.Parent as ChatPage).ScrollListCommand.Execute(null);
        }
    }
}
