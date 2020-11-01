# C# Review/OOP Practice - Entity Framework Code First Migration Updates
​
## Author: Krisztina Pap

## Date due: 11-02-2020

## Last Edited: 11-01-2020

## Instructions

### Introduction
- This practice is designed to continue to help you familiarize yourself with the fundamentals of using Entity Framework to generate and update a database. This scenario is for when you would like to build your server and database both using C#. For this practice we will be expanding upon the Entity Framework Practice - Code First Migration practice by adding more columns to our “Shelves” table and adding more tables as well.
​
### Requirements
- Use Entity Framework Practice - Code First Migration practice as a starting point for this practice.
- Modify the “Shelf” model:
    - A database table called “Shelf” with:
        - An int primary key called ID.
        - A varchar of length 50 called “Name”.
        - A foreign key to ShelfMaterial(ID) called “ShelfMaterialID”.
        - The requisite virtual properties and constructors for references.
- Create a “ShelfMaterial” model:
    - A database table called “Shelf_Material” with:
        - An int primary key called “ID”.
        - A varchar of length 25 called “MaterialName”.
        - The requisite virtual properties for references.
- Use Entity Framework to update the “codefirst_practice” database using your models.
    - This must be done in a migration. 
- Update your code in Program.cs to include:
    - An input a shelf material name (a parameter if you created a method).
        - Ensure the material exists in the “Shelf_Material” table.
            - If the material does not exist, let the user know and exit.
            - The material input should be case insensitive.
            - The material input should be trimmed.
        - When the user enters a valid material and you add the new shelf, ensure the foreign key for “ShelfMaterial” is populated correctly.

​
### Challenges
- Research  Data Seeding - EF and seed the table with 10 shelves consisting of at least 3 different materials when you push it to MySQL.
- If the shelf material the user enters doesn’t exist, ask if they would like to add it. Ensure that it is stored in “Title Case” (upper case first letter of each word).


## Trello Project Board
https://trello.com/b/FwwfGztD/entity-framework-code-first-migration-updates

## References/Citations
- [Microsoft Docs: EF6 - Create a model > Use code first > Workflows](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database)
- Big shout-out to Lindsey Graham for clarifying what exactly the instructions required in this program!