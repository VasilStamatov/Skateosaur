using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
		private Text timer;
		private float floatScore;
		private ushort roundedScore;
		// Use this for initialization
		void Start()
		{
				timer = GetComponent<Text>();
		}

		// Update is called once per frame
		void Update()
		{
				floatScore += Time.deltaTime;
				roundedScore = (ushort)floatScore;
				timer.text = "Time : " + roundedScore;
		}

		void OnDisable()
		{
				GlobalControl.Instance.timeSurvived = roundedScore;
		}
}
