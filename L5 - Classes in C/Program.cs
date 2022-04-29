using System;
namespace LessonL5
{
    public static class ProgramL5
    {
        public static void Main(string[] args)
        {
            Tiger mytiger = new Tiger() { Name = "Monia", weight = 5 };

        }
    }

    public class Animal
    {
        public string? Name { get; set; }

        protected string? nickName { set { Name = value+"chan"; } }
        private int moveSpeed { get; set; }
        public int weight { get; set; }

        public Animal(string Name, int weight) //constructor
        {
            Name = Name;
            weight = weight;
        }
        public Animal() //free constructor
        {

        }

        public virtual void Move()
        {

        }
    }

    public static class MoveHelper
    {

        public static void Move(int moveSpeed, string direction)  //overload
        {

        }
        public static void Move(int swimSpeed, string direction, string verticalDirection)
        {

        }
        public static void Move(int moveSpeed, string direction, string altitude, string verticalDirection)
        {

        }

    }

    public class Fish : Animal, Breed, LayEggs //Hierarcy
    {
        private void CanSwin()
        {

        }
    }

    public class Bird : Animal, Breed, LayEggs
    {
        private void CanFly()
        {

        }

    }

    public class Tiger : Animal, Breed
    {
        public override void Move() //override 
        {

        }
    }

    internal interface Breed //modifiers
    {
        public void Breed()
        {

        }
    }
    public interface LayEggs
    {
        public void LayEggs()
        {

        }
    }
}