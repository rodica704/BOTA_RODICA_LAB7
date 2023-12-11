using System;
using BOTA_RODICA_LAB7;
using System.IO;
using BOTA_RODICA_LAB7.Data;

namespace BOTA_RODICA_LAB7
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        { 
            get 
            { 
                if (database == null) 
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3"));
                } 
                return database; 
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
