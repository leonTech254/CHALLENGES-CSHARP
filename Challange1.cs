using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Class Hierarch CHALLANGE 1
Create a class hierarchy representing different animals.
Include both common and unique properties/methods for each animal
type (e.g., Mammal, Bird, Fish).
*/
namespace AdvanceC_Sharp
{
	public class Animal
	{
		protected string Name;
		protected string Habitat;
		protected int Eyes;
		protected string Movement;


		public Animal(string name, string habitat, int eyes, string movement)
		{
			Name = name;
			Habitat = habitat;
			Eyes = eyes;
			Movement = movement;
		}
	}

	public class Mammal : Animal
	{
		protected bool isdies;

		public Mammal(string name, string habitat, int eyes, string movement,bool isdies) : base(name, habitat, eyes, movement)
		{

			

		}
		public void printMamal()
		{
			Console.WriteLine($"Name: {Name}\nhabitat: {Habitat}\n number of eyes: {Eyes}\nmovement: {Movement}\n Is dies{isdies}");

		}
	}

	public class Bird : Animal
	{

		public Bird(string name, string habitat, int eyes, string movement) : base(name, habitat, eyes, movement)
		{
		}
	}

	public class Fish : Animal
	{


		public Fish(string name, string habitat, int eyes, string movement) : base(name, habitat, eyes, movement)
		{
		}
	}
}
