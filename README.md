# Cookie Cookbook

## Overview

**Cookie Cookbook** is a recipe management system that allows users to store, retrieve, and manage various recipes. It focuses on the organization of ingredients for each recipe, providing functionality to persist the data in a structured JSON format.

This project is ideal for users who want to create and save recipes and then easily access them later with their respective ingredients. The system provides mechanisms for:
- Saving recipes to a JSON file.
- Restoring recipes from JSON.
- Displaying and printing recipe details.

## Features

- **Store Recipes**: Add recipes and their corresponding ingredients to a file.
- **Retrieve Recipes**: Load recipes from a JSON file and associate ingredients with them.
- **Display Recipes**: Print recipes and their associated ingredients in a human-readable format.

## Class Breakdown

### 1. RecipeRepository
The `RecipeRepository` class is responsible for managing the storage and retrieval of recipe data.

- **FilePath**: The path to the file where the recipes are stored.
- **SaveRecipeToJson(Recipe)**: Serializes a recipe object, saving its ingredients in a JSON file.
- **ResorteALLRecipesFromJson(List<Ingredient>)**: Reads the JSON file, deserializes the data, and reconstructs recipe objects with their ingredients.
- **RestoreJsonFileContent()**: Reads and deserializes the JSON file to retrieve stored data.

### 2. Recipe
The `Recipe` class models a recipe, including its list of ingredients.

- **Ingredients**: A list of `Ingredient` objects that make up the recipe.
- **Display()**: A method to display the recipe and its ingredients.
- **AddIngredient(Ingredient)**: Adds an ingredient to the recipe.

### 3. Ingredient
The `Ingredient` class models an individual ingredient with a unique ID, name, and description.

- **ID**: Unique identifier for each ingredient.
- **Name**: The name of the ingredient.
- **InstructionsForPreparing**: Optional preparation instructions for the ingredient.
- **DisplayIngredientDetails()**: Prints details of the ingredient.

### 4. Printing
The `Printing` class provides functionality to display ingredients and recipe details.

- **DisplayIngredients(List<Ingredient>)**: Prints the details of the ingredients in the list.

## Example Ingredients
The system supports various ingredients such as:
- **Wheat Flour**
- **Coconut Flour**
- **Butter**
- **Sugar**
- **Chocolate**
- **Cinnamon**
- **Cardamom**
- **Cocoa Powder**

Each ingredient is stored with a unique ID, allowing it to be referenced across recipes.

## Installation and Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yousefsayedd1/Cookie-Cookbook.git
   
2. **Open the project in your IDE**: 
   Open the project in your favorite integrated development environment (IDE), such as Visual Studio.

3. **Ensure .NET is installed**:
   Make sure you have the .NET framework installed on your machine. You can download it from the official [Microsoft .NET website](https://dotnet.microsoft.com/download).

## How to Use

### 1. Saving a Recipe:
To save a recipe, create an instance of the `Recipe` class and populate it with `Ingredient` objects. Then, use `SaveRecipeToJson()` from the `RecipeRepository` to save the recipe to the JSON file.

```csharp
Recipe myRecipe = new Recipe();
myRecipe.AddIngredient(new Ingredient(1, "Butter", "Melted"));
myRecipe.AddIngredient(new Ingredient(2, "Sugar", "Granulated"));
recipeRepo.SaveRecipeToJson(myRecipe);
```
### 2. Retrieving Recipes:
To retrieve all the recipes, call `ResorteALLRecipesFromJson()`, passing a list of ingredients to match IDs from the JSON file.
```csharp
List<Ingredient> ingredients = new List<Ingredient> {
    new Ingredient(1, "Butter", ""),
    new Ingredient(2, "Sugar", "")
};
List<Recipe> recipes = recipeRepo.ResorteALLRecipesFromJson(ingredients);
```
### 3. Displaying a Recipe:
To display a recipe, call the Display() method on a Recipe object.
```csharp
recipe.Display();
```
## Future Enhancements
- **Add support for more advanced recipe categorization.**
- **Implement a user interface to make recipe management more interactive.**
- **Add support for scaling ingredient quantities based on servings.**
- **Implement searching and filtering by ingredient.**

- ## Contributing

We welcome contributions to this project! If you’d like to contribute, please follow these steps:

1. **Fork the repository**

2. **Create your feature branch**:
   ```bash
   git checkout -b feature/AmazingFeature
   ```
   
3. **Commit your changes:**:
   ```bash
   git commit -m 'Add some AmazingFeature'
   ```
   
4. **Push to the branch:**:
   ```bash
   git push origin feature/AmazingFeature
   ```
5. **Open a pull request:** Go to the "Pull Requests" tab of the original repository and click "New Pull Request". Select your branch and submit the pull request.
Thank you for contributing!
