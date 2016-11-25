using UnityEngine;
using System.Collections.Generic;

/*
 * Script to pool objects of type objectToSpawn and return free(inactive) objects
	* The pooled objects are stored as children to the object this script is attached to
 */
public class ObjectPooler : MonoBehaviour
{
		/*
		 * public settings for the pooler
		 */
		public GameObject objectToSpawn;
		public int pooledAmount = 10;
		public bool canExpand = false;
		public int maxSize = 20;

		//the pooled objects storage
		private List<GameObject> pooledObjects;

		/*
		 * Initialize the object pool by instantiating all the objects
			*  as children to this gameObject and setting them to inactive
		 */
		void Start()
		{
				pooledObjects = new List<GameObject>();
				for (int i = 0; i < pooledAmount; i++)
				{
						GameObject obj = Instantiate(objectToSpawn);
						obj.SetActive(false);
						obj.transform.SetParent(transform);
						pooledObjects.Add(obj);
				}
		}

		/*
		 * Returns the next free game object in the list
			* if all of them are active, then the storage can potentially expand if the setting allow it
			* otherwise returns null
		 */
		public GameObject GetNextFreeObject()
		{
				for (int i = 0; i < pooledObjects.Count; i++)
				{
						if (!pooledObjects[i].activeInHierarchy)
						{
								return pooledObjects[i];
						}
				}

				if (canExpand && pooledObjects.Count < maxSize)
				{
						GameObject newObj = Instantiate(objectToSpawn);
						newObj.SetActive(false);
						newObj.transform.SetParent(transform);
						pooledObjects.Add(newObj);
						return newObj;
				}

				return null;
		}
}
