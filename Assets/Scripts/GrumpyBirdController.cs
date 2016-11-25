using UnityEngine;
using UnityEngine.SceneManagement;

public class GrumpyBirdController : MonoBehaviour
{
		private Bird bird;
		private Rigidbody2D rb;

		public float smoothRotation;

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
						rb.velocity = new Vector2(0.0f, 0.0f);
						rb.AddForce(Vector2.up * bird.JumpPower);
				}
				if (rb.velocity.y > 0)
				{
						transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 45.0f), Time.deltaTime * smoothRotation);
				}
				else
				{
						transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * smoothRotation);
				}
		}

		public void TakeDamage(int damage)
		{
				bird.Health -= damage;
				if (bird.Health < 1)
				{
						SceneManager.LoadScene("EndGame");
				}
		}
}
