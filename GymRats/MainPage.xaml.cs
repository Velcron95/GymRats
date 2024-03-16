using GymRats.Data.DataAccess;
using GymRats.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GymRats
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly TestDbContext _dbContext;

        public MainPage(TestDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _dbContext.Ingredients.Add(new Ingredients
            {
                Name = "Cucumber",
                Protein = 1,
                Calorie = 80, 
            });
            _dbContext.SaveChanges(); 

            Xingredients.ItemsSource = _dbContext.Ingredients.ToList();
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
