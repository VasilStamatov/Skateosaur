/*
 * Base class for a bird to contain it's attributes
 */
public class Bird
{
		/*
		 * Construct a new bird using the contructor and passing the values
		 */
		public Bird(string name, int jumpPower, int health)
		{
				this.name = name;
				this.jumpPower = jumpPower;
				this.health = health;
		}

		/*
		 * Getter for the name (no setter as it is immutable)
		 */
		public string Name
		{
				get { return name; }
		}

		/*
		 * Getter for the jump power (no setter as it is immutable)
		 */
		public int JumpPower
		{
				get { return jumpPower; }
		}

		/*
		 * Getter and setter for the health
		 */
		public int Health
		{
				get { return health; }
				set { health = value; }
		}

		/*
		 * Bird attributes
		 */
		private string name;
		private int jumpPower;
		private int health;
}
