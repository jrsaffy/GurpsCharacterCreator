using System;

namespace gurpsProject
{
	public class Character
	{
		//defines fields, randomly sets initial variables to be used as default values in constructor
		//this sets the base character by rolling 3d6 for each primary attributes then varies the secondary attributes
		//by a random number between -3 and 5 
		public string Name { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Intelligence { get; set; }
		public int Health { get; set; }
		public int Hit { get; set; }
		public int Will { get; set; }
		public int Perception { get; set; }
		public int Fatigue { get; set; }
		public float BasicLift { get; set; }
		public float BasicSpeed { get; set; }
		public double BasicMove { get; set; }


		public Character()
		{
			Random random = new Random();
			//this sets the base character by rolling 3d6 for each primary attributes then varies the secondary attributes
			//by a random number between -3 and 5 
			this.Name = "name";
			this.Strength = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
			this.Dexterity = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
			this.Intelligence = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
			this.Health = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
			//
			this.Hit = this.Strength + random.Next(-3, 6);
			this.Will = this.Dexterity + random.Next(-3, 6);
			this.Perception = this.Intelligence + random.Next(-3, 6);
			this.Fatigue = this.Health + random.Next(-3, 6);
			this.BasicLift = Strength * Strength / 5;
			this.BasicSpeed = (this.Health + this.Dexterity) / 4;
			this.BasicMove = Math.Floor(this.BasicSpeed);

		}

		static void spendPoints(int points)
		{
			//randomly spends points
			//ratios for each attributes
			//Strength 10 per level
			//Dexterity 20 per level
			//Intelligence 20 per level
			//Health 10 per level
			//Hit 2 per level
			//Will 5 per level
			//Perception 5 per level
			//Fatigue 3 per level
		}

		public void displayCharacter()
		{
			Console.WriteLine("Name " + Name);
			Console.WriteLine("Strength " + Strength);
			Console.WriteLine("Dexterity " + Dexterity);
			Console.WriteLine("Perception " + Perception);
			Console.WriteLine("Health " + Health);
			Console.WriteLine("Hit " + Hit);
			Console.WriteLine("Will " + Will);
			Console.WriteLine("Fatigue " + Fatigue);
			Console.WriteLine("IQ " + Intelligence);
			Console.WriteLine("Basic Lift " + BasicLift);
			Console.WriteLine("Basic Speed " + BasicSpeed);
			Console.WriteLine("Basic Move " + BasicMove);
		}
	}
}
