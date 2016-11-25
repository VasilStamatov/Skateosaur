using UnityEngine;

public class FlappyMonsterBehavior : MonoBehaviour
{
		public float speed;
		private int damage = 1;
		private int health = 6;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
				transform.Translate(new Vector3(speed * Time.deltaTime, 0.0f, 0.0f));
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
				if (other.gameObject.tag == "Player")
				{
						GrumpyBirdController player =
						other.gameObject.GetComponent<GrumpyBirdController>();

						player.TakeDamage(damage);

						Debug.Log("player took damage");

						Destroy(gameObject);
				}
		}
}
