using UnityEngine;
using System.Collections;

public class UserBlockDestroy : MonoBehaviour {

	public DrlBtnScr drillerButton;
	public UserBlockCreate blockCreation;
		
	// Use this for initialization
	void Start () {
	
	drillerButton = GameObject.FindWithTag("DrillerButton").GetComponent<DrlBtnScr>();
	blockCreation = GameObject.FindWithTag("Background").GetComponent<UserBlockCreate>();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (drillerButton.drillerControl == 1 && Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.transform == this.transform && hit.collider.tag == "Block1")
			{
				Destroy (this.gameObject);
				blockCreation.block1Counter++;
				Debug.Log("Block 1 Count:" + blockCreation.block1Counter);
			}

			if(hit.collider != null && hit.collider.transform == this.transform && hit.collider.tag == "Block2")
			{
				Destroy (this.gameObject);
				blockCreation.block2Counter++;
				Debug.Log("Block 2 Count:" + blockCreation.block2Counter);
			}

			if(hit.collider != null && hit.collider.transform == this.transform && hit.collider.tag == "DestroyableBuilding")
			{
				Destroy (this.gameObject);
				Debug.Log("Building Destroyed");
			}

			//if(hit.collider != null && hit.collider.transform == this.transform)
			//{
			//	Destroy (this.gameObject);
			//}
		}


	}
}
