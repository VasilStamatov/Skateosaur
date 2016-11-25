using System.Collections;
using UnityEngine;

/*
 * Enemy spawner to handle the spawning waves of enemies from a set pool of enemy objects
 */
public class EnemySpawner : MonoBehaviour
{
		private ObjectPooler objPooler;

		public Vector2 yRange;

		public int enemyCount;
		public float spawnWait;
		public float startWait;
		public float waveWait;

		/*
			* Get the object pooler component to be able to get free objects
			* and start the spawner coroutine
			*/
		void Start()
		{
				objPooler = GetComponent<ObjectPooler>();
				StartCoroutine(SpawnEnemies());
		}

		/*
		 * Spawner coroutine which spawns 1 enemy per spawnWait seconds (enemy count = 1 whole wave)
			* and a new wave per waveWait seconds
			* (and starts after startWait seconds after the game starts)
		 */
		IEnumerator SpawnEnemies()
		{
				yield return new WaitForSeconds(startWait);
				while (true)
				{
						for (int i = 0; i < enemyCount; i++)
						{
								GameObject enemy = objPooler.GetNextFreeObject();

								if (enemy == null)
								{
										yield return null;
								}

								Vector3 spawnPos = new Vector3(transform.position.x, Random.Range(yRange.x, yRange.y), transform.position.z);

								enemy.transform.position = spawnPos;

								enemy.SetActive(true);

								yield return new WaitForSeconds(spawnWait);
						}
						yield return new WaitForSeconds(waveWait);
				}
		}
}
