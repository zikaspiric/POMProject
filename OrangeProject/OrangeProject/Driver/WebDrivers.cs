﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Driver
{
    public class WebDrivers
    {
        public static IWebDriver? Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Instance.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }
        public static void CleanUp()
        {
            Instance?.Quit();
        }

    }
}
