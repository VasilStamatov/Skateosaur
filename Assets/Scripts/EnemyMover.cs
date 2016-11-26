using UnityEngine;

/*
 * Handles the movement of the enemies and enemy-player collision handing
 */
public class EnemyMover : MonoBehaviour
{
		public float speed;
		public int damage = 1;

		/*
			* Translate the flappy monster by speed per second to the left
			*/
		void Update()
		{
				transform.Translate(new Vector3(speed * Time.deltaTime, 0.0f, 0.0f));
		}

		/*
		 * Damage the player if the monster collides with him
		 */
		void OnTriggerEnter2D(Collider2D other)
		{
				if (other.gameObject.tag == "Player")
				{
						GrumpyBirdController player =
						other.gameObject.GetComponent<GrumpyBirdController>();

						if (player != null)
						{
								player.TakeDamage(damage);

								gameObject.SetActive(false);
						}
				}
		}
}
