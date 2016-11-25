using UnityEngine;

/*
 * Handles the movement of the monster and monster-player collision handing
 */
public class FlappyMonsterBehavior : MonoBehaviour
{
		public float speed;
		private int damage = 1;
		private int health = 6;

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
