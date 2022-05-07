namespace Inheritance_Test
{
    class Animal
    {
        public virtual void Ability()
        {
            Console.WriteLine("My ability");
        }

        public void Skills()
        {
            Ability();
        }
    }

    class Dog : Animal
    {
        public override void Ability()
        {
            Console.WriteLine("My ability is barking");
        }
    }

    class Program
    {
        public static void Main()
        {
            Animal animal = new();
            Dog dog = new();

            animal.Skills();
            dog.Skills();
        }
    }
}
