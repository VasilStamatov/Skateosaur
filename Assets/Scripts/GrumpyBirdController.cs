using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Behaviour to handle keyboard input and move the player accordingly
	* Also lets the player take damage and lose
 */
public class GrumpyBirdController : MonoBehaviour
{
		private Bird bird;
		private Rigidbody2D rb;

		public float smoothRotation;

		/*
			* Get the rigidbody component so it doesn't have to be gotten every frame
			* And create the bird with the contructor
			*/
		void Start()
		{
				rb = GetComponent<Rigidbody2D>();
				bird = new Bird("Grumpy", 400, 1);
		}

		/*
			* Handle keyboard input for the bird jumping
			* Needs to be in Update so that inputs aren't missed
			*/
		void Update()
		{
				if (Input.GetKeyDown(KeyCode.Space))
				{
						//reset the velocity for consistent jumping power
						rb.velocity = new Vector2(0.0f, 0.0f);
						rb.AddForce(Vector2.up * bird.JumpPower);
				}
				if (rb.velocity.y > 0)
				{
						//rotate the bird upwards if it's going up
						transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 45.0f), Time.deltaTime * smoothRotation);
				}
				else
				{
						//rotate the bird to the original orientation when it's not going up
						transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * smoothRotation);
				}
		}

		/*
			* Lets the player take damage from enemy scripts referencing this public function
			*/
		public void TakeDamage(int damage)
		{
				bird.Health -= damage;
				if (bird.Health < 1)
				{
						SceneManager.LoadScene("EndGame");
				}
		}

		void OnDisable()
		{
				SceneManager.LoadScene("EndGame");
		}
}
