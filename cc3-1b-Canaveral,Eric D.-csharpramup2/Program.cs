using System;

namespace CSharpRampUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine("Weight: {pounds} lbs, Converted to Kilograms: {kilograms} kg");
            Console.Write("distance in miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine("Distance: {miles} mi, Converted to Kilometers: {kilometers} km");
            Console.Write("temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature: {fahrenheit} °F, Converted to Celsius: {celsius} °C");
            int Ages = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("age of student {i + 1}: ");
                Ages += Convert.ToInt32(Console.ReadLine());
            }
            double average = Ages / 10.0;
            Console.WriteLine("Ages of all students: (List of ages), Average Age: {average}");
            string person1 = "Jojo";
            string person2 = "Luna";
            string person3 = "Axel";
            string person4 = "Seraphina";
            string person5 = "Uncle Roger";
            string item1 = "Super Awesome Chef Knife";
            string item2 = "Pot of Destiny";
            string item3 = "Secret Spice Salt";
            string Story = $@"
In the mystical realm of Food warzz, {person1} and his extraordinary team of chefs embarked on a culinary odyssey to defend their world from
the encroaching plague of blandness that threatened to engulf their beloved cuisine. Along their flavourful journey, they stumbled upon the {item1},
a pulsating culinary blade radiating immense gastronomical potential. This serendipitous discovery introduced them to the enigmatic knife, a culinary tool 
bestowed upon {person1} the remarkable ability to <manipulate the taste buds of others>. 

Their culinary confrontations against the malevolent chef {person5} pushed the limits of their newfound abilities and equipment.
{person2}, the mystical mage of the kitchen, harnessed the essence of paprika, channeling the raw energy of spice into enchanting flavours that could 
transform even the blandest dishes into mouthwatering masterpieces. {person3}, the fearless culinary warrior, wielded the legendary {item2},
a cauldron forged through culinary craftsmanship, enabling him to <cook any ingredient to perfection, regardless of its origin>. 
{person4}, the crafty rogue of the culinary world, unveiled her ability {item3}, a unique seasoning blend that not only elevated the flavors of her 
dishes but also granted her the ability to <replicate the culinary techniques and abilities of her adversaries>, assuming the culinary personas and
giving her the edge in the most intense kitchen battles.

Together, they demonstrated that the unbreakable bonds of friendship and the harmonious synergy of their extraordinary culinary powers and equipment were
the secret ingredient to triumph over the peculiar gastronomic challenge of Food Warzz. Their journey ensured that their world remained a realm of culinary wonder,
where enchanting flavours and extraordinary dishes perpetually graced their tables.";
            Console.WriteLine("Fantasy Story:");
            Console.WriteLine(Story);
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("Number Pattern:");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Sum of first {n} natural numbers: {n * (n + 1) / 2}");
                Console.WriteLine("Inverted Number Pattern:");
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
