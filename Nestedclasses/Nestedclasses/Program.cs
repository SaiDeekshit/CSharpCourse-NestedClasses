using System;

namespace Nestedclasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animals animal = new Animals();
            Animals.Dogs dog = new Animals.Dogs();
            dog.dogBreed = "Greman Shepard";

            Animals.Cats cat = new Animals.Cats();
            cat.catName = "Rex";

            Console.WriteLine("DogBreed " + dog.dogBreed);
            Console.WriteLine("Cat Name " + cat.catName);
        }
    }
    //Parent Class
    class Animals
    {
        public string animalName;
        public string animalCountry;

        //Child Classes
        public class Dogs
        {
            public string dogBreed;
            public string dogNickname;
        }

        public class Cats
        {
            public string catName;
        }

    }
}
