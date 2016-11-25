using UnityEngine;

/*
 * The boundary to set anything to inactive if it leaves the level (set it in a reusable state for object pooling)
 */
public class Boundary : MonoBehaviour
{
		/*
			* whenever a game object leaves the level boundary collider, set it to inactive
			*/
		void OnTriggerExit2D(Collider2D other)
		{
				other.gameObject.SetActive(false);
		}
}
