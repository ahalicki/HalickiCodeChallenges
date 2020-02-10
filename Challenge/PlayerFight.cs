using System;

namespace HalickiCodeChallenges.Challenge.Sorting
{
    /// <summary>
    /// A silly RPG-style player fight in the console window. Extensible
    /// to allow more attackable objects demonstrating basic use of interfaces.
    /// </summary>
    public class PlayerFight : IRunnable
    {
        public void Run()
        {
            Console.WriteLine($"Player Fight:");
            Console.WriteLine($"================");

            var p1 = new Player("Anthony");
            var p2 = new Player("David");

            while (p1.Health > 0 &&
                    p2.Health > 0)
            {
                System.Threading.Thread.Sleep(1000);

                // 1st player attacks.
                p1.Attack(p2);
                if (p2.Health < 1)
                {
                    Console.WriteLine($"{Environment.NewLine}{p1.Name} wins!");
                    return;
                }

                System.Threading.Thread.Sleep(1000);

                // 2nd player attacks.
                p2.Attack(p1);
                if (p1.Health < 1)
                {
                    Console.WriteLine($"{Environment.NewLine}{p2.Name} wins!");
                    return;
                }
            }
        }
    }

    public abstract class GameCharacter : IAttackable
    {
        /// <summary>
        /// The name of the game character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The health of the game character.
        /// </summary>
        public int Health { get; set; }

        public void Attack(IAttackable p2)
        {
            var dmg = new Random().Next(0, 20);
            p2.Health -= dmg;

            Console.WriteLine($"{this.Name} attacks {p2.Name} for {dmg}. Health: {p2.Health}");
        }
    }

    public class Player : GameCharacter
    {
        public Player(string name)
        {
            Name = name;
            Health = 100;
        }
    }

    /// <summary>
    /// Represents an attackable object.
    /// </summary>
    public interface IAttackable : INamed
    {
        /// <summary>
        /// the health of the object.
        /// </summary>
        int Health { get; set; }
    }

    /// <summary>
    /// Represents a named object.
    /// </summary>
    public interface INamed
    {
        string Name { get; }
    }
}
