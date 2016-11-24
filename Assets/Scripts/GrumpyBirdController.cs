using UnityEngine;
using UnityEngine.SceneManagement;

public class GrumpyBirdController : MonoBehaviour
{
		private Bird bird;
		private Rigidbody2D rb;
		// Use this for initialization
		void Start()
		{
				rb = GetComponent<Rigidbody2D>();
				bird = new Bird("Grumpy", 400, 6);
		}

		// Update is called once per frame
		void Update()
		{
				if (Input.GetKeyDown(KeyCode.Space))
				{
						rb.AddForce(new Vector2(0.0f, bird.JumpPower));
				}
		}

		public void TakeDamage(Vector2 hitPoint)
		{
				bird.Health -= 1;
				rb.AddForce(hitPoint * -1);
				if (bird.Health < 1)
				{
						SceneManager.LoadScene("EndGame");
				}
		}
}
