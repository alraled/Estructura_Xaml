﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estructura_Xaml.View;
using Xamarin.Forms;

namespace Estructura_Xaml
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new Inicio();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
