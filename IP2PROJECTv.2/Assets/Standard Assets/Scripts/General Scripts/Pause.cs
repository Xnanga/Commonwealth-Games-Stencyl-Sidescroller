using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization

		
		private bool paused;
		
		void Update ()
		{
			if (Input.GetKeyDown("p") && paused == false)
			{
				paused = true;
				Time.timeScale = 0;
			Debug.Log ("Game is Paused");
				
			}
			else if (Input.GetKeyDown("p") && paused == true)
			{
				paused = false;
				Time.timeScale = 1;
				
			}
		}
	}


