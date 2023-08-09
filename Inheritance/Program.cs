using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var cardinal = new Bird();

            cardinal.Age = 2;
            cardinal.CanFly = true;
            cardinal.WingSpan = 10;
            cardinal.WillFlock = true;
            cardinal.EyeCount = 2;
            cardinal.IsNocturnal = false;
            cardinal.Species = "bird";
            cardinal.FeatherColor = "red";

            Console.WriteLine($"Age: {cardinal.Age}\nCan Fly: {cardinal.CanFly}\nWing Span: {cardinal.WingSpan}\nWill Flock: {cardinal.WillFlock}\nEye count: {cardinal.EyeCount}\nIs Nocturnal: {cardinal.IsNocturnal}\nSpecies: {cardinal.Species}\nFeather Color: {cardinal.FeatherColor}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var komodo = new Reptile();

            komodo.CanRegen = true;
            komodo.CanCamo = false;
            komodo.Length = 20;
            komodo.ScaleColor = "gray";
            komodo.Species = "reptile";
            komodo.IsNocturnal = false;
            komodo.EyeCount = 2;
            komodo.Age = 3;

            Console.WriteLine($"Can Regen: {komodo.CanRegen}\nCan Camo: {komodo.CanCamo}\nLength: {komodo.Length}\nScale Color: {komodo.ScaleColor}\nSpecies: {komodo.Species}\nIs Nocturnal: {komodo.IsNocturnal}\nEye Count: {komodo.EyeCount}\nAge: {komodo.Age}");
        }
    }
}
