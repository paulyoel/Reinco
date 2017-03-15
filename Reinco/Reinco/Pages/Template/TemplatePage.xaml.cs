﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reinco.Pages.Template
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplatePage : ContentPage
    {
        public TemplatePage()
        {
            InitializeComponent();
            addTemplate.Clicked += AddTemplate_Clicked;
        }

        private void AddTemplate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddTemplatePage());
        }
    }
}