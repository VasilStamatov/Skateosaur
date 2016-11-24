public class Bird
{
		public Bird(string name, int jumpPower, int health)
		{
				this.name = name;
				this.jumpPower = jumpPower;
				this.health = health;
		}

		public string Name
		{
				get { return name; }
		}

		public int JumpPower
		{
				get { return jumpPower; }
		}

		public int Health
		{
				get { return health; }
				set { health = value; }
		}

		private string name;
		private int jumpPower;
		private int health;
}
