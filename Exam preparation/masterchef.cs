
using System;
using System.Collections.Generic;
using System.Linq;

namespace masterchef
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dippingSauces = 0;
            int greenSalads = 0;
            int chocolateCakes = 0;
            int lobsters = 0;
          
            List<int> ingredients = 
                Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> freshnessLevels = 
                Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            Queue<int> ingredientsInBasket = new Queue<int>(ingredients);
            Stack<int> freshnessOfIngredients = new Stack<int>(freshnessLevels);

            Dictionary<string, int> dishes = new Dictionary<string, int>();
            dishes.Add("Dipping sauce", 150);
            dishes.Add("Green salad", 250);
            dishes.Add("Chocolate cake", 300);
            dishes.Add("Lobster", 400);

            Dictionary<string, int> madeDishes = new Dictionary<string, int>();

            while(ingredientsInBasket.Count > 0 && freshnessOfIngredients.Count > 0)
            {
                string dish = "";
                int ingredient = ingredientsInBasket.Peek();

                if(ingredient == 0)
                {
                    ingredientsInBasket.Dequeue();
                    continue;
                }

                int freshness = freshnessOfIngredients.Peek();
                int totalFreshnessLevel = ingredient * freshness;

                if(dishes.ContainsValue(totalFreshnessLevel))
                {
                    foreach(KeyValuePair<string, int> kvp in dishes)
                    {
                        if(kvp.Value == totalFreshnessLevel)
                        {
                            dish = kvp.Key;
                            break;
                        }
                    }

                    switch(dish)
                    {
                        case "Dipping sauce":
                            dippingSauces++;
                            break;

                        case "Green salad":
                            greenSalads++;
                            break;

                        case "Chocolate cake":
                            chocolateCakes++;
                            break;

                        case "Lobster":
                            lobsters++;
                            break;
                    }

                    if(!madeDishes.ContainsKey(dish))
                    {
                        madeDishes.Add(dish, 0);    
                    }
                  
                    madeDishes[dish]++;
               
                    ingredientsInBasket.Dequeue();
                    freshnessOfIngredients.Pop();
                }
        
                else 
                {
                    freshnessOfIngredients.Pop();
                    int newIngredientValue = ingredientsInBasket.Dequeue() + 5;
                    ingredientsInBasket.Enqueue(newIngredientValue);
                }
            }

            if(dippingSauces > 0 && greenSalads > 0 && chocolateCakes > 0 && lobsters > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if(ingredientsInBasket.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientsInBasket.Sum()}");
            }

           Dictionary<string, int> finalDishes = 
                madeDishes.Where(p => p.Value > 0)
                .OrderBy(n => n.Key)
                .ToDictionary(n => n.Key, n => n.Value);
            
            foreach(var dish in finalDishes)
            {
                Console.WriteLine($"# {dish.Key} --> {dish.Value}");
            }
        }
    }
}
