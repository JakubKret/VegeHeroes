using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipesArrays : MonoBehaviour
{
    [SerializeField] public bool firstTime = true;
    [SerializeField] public int publicRandomFilteredIndex;
    [SerializeField] public string nameOfDish;
    [SerializeField] public int currDay;
    public Sprite[] Images;
    public int preparationTime;
    public int servesOfDish;
    public string recipeText;
        bool cheeseCaprice;
        bool garlicCaprice;
        bool milkCaprice;
        bool flourCaprice;
        bool mushroomsCaprice;
        bool peasCaprice;
        bool eggCaprice;
        bool pastaCaprice;
        bool butterCaprice;
        int prepTimeCaprice;
        int servesCaprice;
    // Use this for initialization

    void Start()
    {
        firstTime = SaveSystem.LoadRecipes().firstTime;

        List<Recipes> recipes = new List<Recipes>();
        List<Recipes> recipesFiltered = new List<Recipes>();
        recipes.Add(new Recipes("Classic french omlette", false, false, true, false, true, true, true, false, true, 10, 2, "For the omelette: \n 2 or 3 eggs \n 1 tbsp milk \n 25g butter or margarine \n salt and pepper \n Optional filling ingredients: \n 50g vegetarian Cheddar cheese, grated \n 25g peas \n 1/2 pepper, chopped \n 3 mushrooms, sliced \n Method: \n In a large bowl, gently whisk the eggs and milk or water. Try not to over whisk though as this may spoil the texture of the omelette. If you are going to use the optional ingredients prepare them now!The peas and peppers can be gently steamed, the mushrooms lightly fried. Melt the butter or margarine until it is gently foaming in a frying pan or small saucepan, add the eggs and leave until starting to set. Using a palette knife, draw in the mixture from the side of the pan into the centre then tilt the pan to pour the liquid egg into the space made.Continue to do this around the omelette until all the egg has set. Using the palette knife, fold over the omelette and slide it off the pan onto a plate. (Before folding the omelette add your extra ingredients!) "));
        recipes.Add(new Recipes("Cheesy Pasta Bake", true, false, true, true, false, false, false, true, true, 40, 4, "Ingredients: \n 250g pasta \n 40g butter or margarine \n 40g plain flour \n 600ml milk \n 350g grated vegetarian Cheddar cheese \n Preheat the oven to 190°C/gas mark 5. In the medium saucepan, cook the pasta according to packet instructions, drain in a colander, flush with cold water, and set aside. Melt the butter over low heat in the large saucepan.Once the butter is melted, add the flour and stir with the wooden spoon to form a paste. Cook for another 1 - 2 minutes. Gradually stir in the milk, approximately 100ml at a time, stirring out any lumps from the mixture. Continue stirring until the sauce thickens, then add the next bit of milk. When the sauce is ready, in around 10 - 15 minutes, it will be fairly thick, smooth and steaming. Don’t allow it to boil! Remove the sauce from heat and stir in 250g of the cheese, mixing well until the cheese has melted. Transfer the pasta into the ovenproof dish, pour the cheese sauce over it and stir the mixture around, making sure that all of the pasta is covered in sauce. Sprinkle the mixture first with the remaining cheese, finally adding a dash of dried chives(optional). Bake for approximately 30 minutes until the cheese is browned and bubbling. "));
        recipes.Add(new Recipes("Mushrooms with cheese", true, true, false, false, true, false, false, false, false, 20, 4, "Ingredients: \n 4 mushrooms \n 80g cheese \n 2 cloves garlic, crushed \n Method: \n Remove the stalk from the mushrooms and fill with cheese, garlic. Place on the barbeque for 10 - 15 minutes."));

        if (firstTime == true)
        {
            cheeseCaprice = false;
            garlicCaprice = false;
            milkCaprice = false;
            flourCaprice = false;
            mushroomsCaprice = false;
            peasCaprice = false;
            eggCaprice = false;
            pastaCaprice = false;
            butterCaprice = false;
            prepTimeCaprice = 0;
            servesCaprice = 0;




            foreach (Recipes item in recipes)
            {

                if (item.cheese == false || item.cheese != cheeseCaprice)
                {
                    if (item.garlic == false || item.garlic != garlicCaprice)
                    {
                        if (item.milk == false || item.milk != milkCaprice)
                        {
                            if (item.flour == false || item.flour != flourCaprice)
                            {
                                if (item.mushrooms == false || item.mushrooms != mushroomsCaprice)
                                {
                                    if (item.peas == false || item.peas != peasCaprice)
                                    {
                                        if (item.egg == false || item.egg != eggCaprice)
                                        {
                                            if (item.pasta == false || item.pasta != pastaCaprice)
                                            {
                                                if (item.butter == false || item.butter != butterCaprice)
                                                {
                                                    if (prepTimeCaprice == 0 || item.preparationTime <= prepTimeCaprice)
                                                    {
                                                        if (servesCaprice == 0 || item.serves == servesCaprice)
                                                        {
                                                            recipesFiltered.Add(item);
                                                        }
                                                        else { continue; }
                                                    }
                                                    else { continue; }
                                                }
                                                else { continue; }
                                            }
                                            else { continue; }
                                        }
                                        else { continue; }
                                    }
                                    else { continue; }
                                }
                                else { continue; }
                            }
                            else { continue; }
                        }
                        else { continue; }
                    }
                    else { continue; }
                }
                else { continue; }
            }
            int randomFilteredRecipeIndex = Random.Range(0, recipesFiltered.Count - 1);
            publicRandomFilteredIndex = randomFilteredRecipeIndex;



            


        }
        else 
        {
            SaveSystem.LoadRecipes();
            currDay = SaveSystem.LoadRecipes().currDay;
            publicRandomFilteredIndex = SaveSystem.LoadRecipes().publicRandomFilteredIndex;
            Debug.Log(publicRandomFilteredIndex);

            cheeseCaprice = SaveSystem.LoadCaprices().cheeseCaprice;
            garlicCaprice = SaveSystem.LoadCaprices().garlicCaprice;
            milkCaprice = SaveSystem.LoadCaprices().milkCaprice;
            flourCaprice = SaveSystem.LoadCaprices().flourCaprice;
            mushroomsCaprice = SaveSystem.LoadCaprices().mushroomsCaprice;
            peasCaprice = SaveSystem.LoadCaprices().peasCaprice;
            eggCaprice = SaveSystem.LoadCaprices().eggCaprice;
            pastaCaprice = SaveSystem.LoadCaprices().pastaCaprice;
            butterCaprice = SaveSystem.LoadCaprices().butterCaprice;
            prepTimeCaprice = SaveSystem.LoadCaprices().prepTimeCaprice;
            servesCaprice = SaveSystem.LoadCaprices().servesCaprice;

            int roznicaDni = System.DateTime.Now.Day - currDay;
            Debug.Log(currDay);
            Debug.Log(roznicaDni);                                   
            if (roznicaDni == 0)
            {
                
                
                foreach (Recipes item in recipes)
                {

                    if (item.cheese == false || item.cheese != cheeseCaprice)
                    {
                        if (item.garlic == false || item.garlic != garlicCaprice)
                        {
                            if (item.milk == false || item.milk != milkCaprice)
                            {
                                if (item.flour == false || item.flour != flourCaprice)
                                {
                                    if (item.mushrooms == false || item.mushrooms != mushroomsCaprice)
                                    {
                                        if (item.peas == false || item.peas != peasCaprice)
                                        {
                                            if (item.egg == false || item.egg != eggCaprice)
                                            {
                                                if (item.pasta == false || item.pasta != pastaCaprice)
                                                {
                                                    if (item.butter == false || item.butter != butterCaprice)
                                                    {
                                                        if (prepTimeCaprice == 0 || item.preparationTime <= prepTimeCaprice)
                                                        {
                                                            if (servesCaprice == 0 || item.serves == servesCaprice)
                                                            {
                                                                recipesFiltered.Add(item);
                                                            }
                                                            else { continue; }
                                                        }
                                                        else { continue; }
                                                    }
                                                    else { continue; }
                                                }
                                                else { continue; }
                                            }
                                            else { continue; }
                                        }
                                        else { continue; }
                                    }
                                    else { continue; }
                                }
                                else { continue; }
                            }
                            else { continue; }
                        }
                        else { continue; }
                    }
                    else { continue; }
                }
                publicRandomFilteredIndex = SaveSystem.LoadRecipes().publicRandomFilteredIndex;
                Debug.Log(publicRandomFilteredIndex);
            }
         
            else
            {
                
                foreach (Recipes item in recipes)
                {

                    if (item.cheese == false || item.cheese != cheeseCaprice)
                    {
                        if (item.garlic == false || item.garlic != garlicCaprice)
                        {
                            if (item.milk == false || item.milk != milkCaprice)
                            {
                                if (item.flour == false || item.flour != flourCaprice)
                                {
                                    if (item.mushrooms == false || item.mushrooms != mushroomsCaprice)
                                    {
                                        if (item.peas == false || item.peas != peasCaprice)
                                        {
                                            if (item.egg == false || item.egg != eggCaprice)
                                            {
                                                if (item.pasta == false || item.pasta != pastaCaprice)
                                                {
                                                    if (item.butter == false || item.butter != butterCaprice)
                                                    {
                                                        if (prepTimeCaprice == 0 || item.preparationTime <= prepTimeCaprice)
                                                        {
                                                            if (servesCaprice == 0 || item.serves == servesCaprice)
                                                            {
                                                                recipesFiltered.Add(item);
                                                            }
                                                            else { continue; }
                                                        }
                                                        else { continue; }
                                                    }
                                                    else { continue; }
                                                }
                                                else { continue; }
                                            }
                                            else { continue; }
                                        }
                                        else { continue; }
                                    }
                                    else { continue; }
                                }
                                else { continue; }
                            }
                            else { continue; }
                        }
                        else { continue; }
                    }
                    else { continue; }
                }
                int randomFilteredRecipeIndex = Random.Range(0, recipesFiltered.Count - 1);
                publicRandomFilteredIndex = randomFilteredRecipeIndex;
                
            }
        }
        
        if (recipesFiltered.Count == 0)
        {
            nameOfDish = ("No such a recipe! :(");
        }
        else
        {
            nameOfDish = recipesFiltered[publicRandomFilteredIndex].name;
            preparationTime = recipesFiltered[publicRandomFilteredIndex].preparationTime;
            recipeText = recipesFiltered[publicRandomFilteredIndex].recipeText;
            servesOfDish = recipesFiltered[publicRandomFilteredIndex].serves;
            Debug.Log(publicRandomFilteredIndex);
            Debug.Log(firstTime);
            currDay = System.DateTime.Now.Day;
            firstTime = false;
            SaveSystem.SaveRecipes(this);
            Debug.Log(firstTime);
            
            GetComponent<Image>().sprite = Images[publicRandomFilteredIndex];
            Debug.Log(publicRandomFilteredIndex);
        }
        
        


        
    }
    void Update()
    {
        GetComponent<Image>().sprite = Images[publicRandomFilteredIndex];
        cheeseCaprice = SaveSystem.LoadCaprices().cheeseCaprice;
        garlicCaprice = SaveSystem.LoadCaprices().garlicCaprice;
        milkCaprice = SaveSystem.LoadCaprices().milkCaprice;
        flourCaprice = SaveSystem.LoadCaprices().flourCaprice;
        mushroomsCaprice = SaveSystem.LoadCaprices().mushroomsCaprice;
        peasCaprice = SaveSystem.LoadCaprices().peasCaprice;
        eggCaprice = SaveSystem.LoadCaprices().eggCaprice;
        pastaCaprice = SaveSystem.LoadCaprices().pastaCaprice;
        butterCaprice = SaveSystem.LoadCaprices().butterCaprice;
        prepTimeCaprice = SaveSystem.LoadCaprices().prepTimeCaprice;
        servesCaprice = SaveSystem.LoadCaprices().servesCaprice;

    }
    public string GetActualNameOfDish()
    {
        return nameOfDish;

    }
    
   
    public int GetActualPreparationTime()
    {
        return preparationTime;
    }
    public int GetActualServes()
    {
        return servesOfDish;
    }
    public void Next()
    {
        SaveSystem.LoadCaprices();

        cheeseCaprice = SaveSystem.LoadCaprices().cheeseCaprice;
        garlicCaprice = SaveSystem.LoadCaprices().garlicCaprice;
        milkCaprice = SaveSystem.LoadCaprices().milkCaprice;
        flourCaprice = SaveSystem.LoadCaprices().flourCaprice;
        mushroomsCaprice = SaveSystem.LoadCaprices().mushroomsCaprice;
        peasCaprice = SaveSystem.LoadCaprices().peasCaprice;
        eggCaprice = SaveSystem.LoadCaprices().eggCaprice;
        pastaCaprice = SaveSystem.LoadCaprices().pastaCaprice;
        butterCaprice = SaveSystem.LoadCaprices().butterCaprice;
        prepTimeCaprice = SaveSystem.LoadCaprices().prepTimeCaprice;
        servesCaprice = SaveSystem.LoadCaprices().servesCaprice;
        
        List<Recipes> recipes = new List<Recipes>();
        List<Recipes> recipesFiltered = new List<Recipes>();
        recipes.Add(new Recipes("Classic french omlette", false, false, true, false, true, true, true, false, true, 10, 2, "For the omelette: \n 2 or 3 eggs \n 1 tbsp milk \n 25g butter or margarine \n salt and pepper \n Optional filling ingredients: \n 50g vegetarian Cheddar cheese, grated \n 25g peas \n 1/2 pepper, chopped \n 3 mushrooms, sliced \n Method: \n In a large bowl, gently whisk the eggs and milk or water. Try not to over whisk though as this may spoil the texture of the omelette. If you are going to use the optional ingredients prepare them now!The peas and peppers can be gently steamed, the mushrooms lightly fried. Melt the butter or margarine until it is gently foaming in a frying pan or small saucepan, add the eggs and leave until starting to set. Using a palette knife, draw in the mixture from the side of the pan into the centre then tilt the pan to pour the liquid egg into the space made.Continue to do this around the omelette until all the egg has set. Using the palette knife, fold over the omelette and slide it off the pan onto a plate. (Before folding the omelette add your extra ingredients!) "));
        recipes.Add(new Recipes("Cheesy Pasta Bake", true, false, true, true, false, false, false, true, true, 40, 4, "Ingredients: \n 250g pasta \n 40g butter or margarine \n 40g plain flour \n 600ml milk \n 350g grated vegetarian Cheddar cheese \n Preheat the oven to 190°C/gas mark 5. In the medium saucepan, cook the pasta according to packet instructions, drain in a colander, flush with cold water, and set aside. Melt the butter over low heat in the large saucepan.Once the butter is melted, add the flour and stir with the wooden spoon to form a paste. Cook for another 1 - 2 minutes. Gradually stir in the milk, approximately 100ml at a time, stirring out any lumps from the mixture. Continue stirring until the sauce thickens, then add the next bit of milk. When the sauce is ready, in around 10 - 15 minutes, it will be fairly thick, smooth and steaming. Don’t allow it to boil! Remove the sauce from heat and stir in 250g of the cheese, mixing well until the cheese has melted. Transfer the pasta into the ovenproof dish, pour the cheese sauce over it and stir the mixture around, making sure that all of the pasta is covered in sauce. Sprinkle the mixture first with the remaining cheese, finally adding a dash of dried chives(optional). Bake for approximately 30 minutes until the cheese is browned and bubbling. "));
        recipes.Add(new Recipes("Mushrooms with cheese", true, true, false, false, true, false, false, false, false, 20, 4, "Ingredients: \n 4 mushrooms \n 80g cheese \n 2 cloves garlic, crushed \n Method: \n Remove the stalk from the mushrooms and fill with cheese, garlic. Place on the barbeque for 10 - 15 minutes."));

        foreach (Recipes item in recipes)
        {

            if (item.cheese == false || item.cheese != cheeseCaprice)
            {
                if (item.garlic == false || item.garlic != garlicCaprice)
                {
                    if (item.milk == false || item.milk != milkCaprice)
                    {
                        if (item.flour == false || item.flour != flourCaprice)
                        {
                            if (item.mushrooms == false || item.mushrooms != mushroomsCaprice)
                            {
                                if (item.peas == false || item.peas != peasCaprice)
                                {
                                    if (item.egg == false || item.egg != eggCaprice)
                                    {
                                        if (item.pasta == false || item.pasta != pastaCaprice)
                                        {
                                            if (item.butter == false || item.butter != butterCaprice)
                                            {
                                                if (prepTimeCaprice == 0 || item.preparationTime <= prepTimeCaprice)
                                                {
                                                    if (servesCaprice == 0 || item.serves == servesCaprice)
                                                    {
                                                        recipesFiltered.Add(item);
                                                    }
                                                    else { continue; }
                                                }
                                                else { continue; }
                                            }
                                            else { continue; }
                                        }
                                        else { continue; }
                                    }
                                    else { continue; }
                                }
                                else { continue; }
                            }
                            else { continue; }
                        }
                        else { continue; }
                    }
                    else { continue; }
                }
                else { continue; }
            }
            else { continue; }
        }
        
        int randomFilteredRecipeIndex = Random.Range(0, recipesFiltered.Count - 1);
        publicRandomFilteredIndex = randomFilteredRecipeIndex;
        
        if (recipesFiltered.Count == 0)
        {
            nameOfDish = ("No such a recipe! :(");
        }
        else
        {
            nameOfDish = recipesFiltered[publicRandomFilteredIndex].name;
            GetComponent<Image>().sprite = Images[publicRandomFilteredIndex];
            preparationTime = recipesFiltered[publicRandomFilteredIndex].preparationTime;
            servesOfDish = recipesFiltered[publicRandomFilteredIndex].serves;
            recipeText = recipesFiltered[publicRandomFilteredIndex].recipeText;
            SaveSystem.SaveRecipes(this);
            Debug.Log(publicRandomFilteredIndex);
        }
        

    }

    public string GetRecipeText()
    {
        return recipeText;
    }
    public int GetIndex()
    {
        return publicRandomFilteredIndex;
    }
}



       