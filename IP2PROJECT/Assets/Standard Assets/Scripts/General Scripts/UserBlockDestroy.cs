using UnityEngine;
using System.Collections;

public class UserBlockDestroy : MonoBehaviour {

	public DrlBtnScr drillerButton;
		
	// Use this for initialization
	void Start () {
	
	drillerButton = GameObject.FindWithTag("DrillerButton").GetComponent<DrlBtnScr>();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (drillerButton.drillerControl == 1 && Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.transform == this.transform)
			{
				Destroy (this.gameObject);
			}
		}


	}
}
