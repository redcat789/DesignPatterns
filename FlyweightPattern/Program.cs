namespace FlyweightPattern
{
    static class Program
    {
        /*
         * The Flyweight Pattern is a structural design pattern used to optimize memory 
         * usage by sharing common parts of an object between multiple instances. 
         * It avoids creating multiple similar objects by storing shared data externally 
         * and reusing objects.
         */

        /*
         Imagine a forest simulation where:

        Each tree has common properties like species, color, texture, etc. (intrinsic state).
        Each tree also has unique properties like its position in the forest (extrinsic state).
        Instead of creating individual objects for every tree, we use the Flyweight Pattern 
        to optimize memory by sharing common properties.*/

        static void Main()
        {
            Forest forest = new Forest();

            // Plant many trees
            forest.PlantTree("Oak", "Green", "Rough", 10, 20);
            forest.PlantTree("Pine", "Dark Green", "Smooth", 15, 25);
            forest.PlantTree("Oak", "Green", "Rough", 20, 30); // Reuses the existing Oak tree

            // Display all trees
            forest.DisplayTrees();
        }
    }
}