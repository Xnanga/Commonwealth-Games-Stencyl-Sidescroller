using UnityEngine;
using System.Collections;

public class DrlBtnScr : MonoBehaviour {

	public HamrBtnScr hammerButton;
	public short drillerControl = 0;
	public Sprite drillerSprite;
	public Sprite drillerHighlight;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		hammerButton = GameObject.FindWithTag ("HammerButton").GetComponent<HamrBtnScr> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);

			
			if(hit.collider != null && hit.collider.tag == "DrillerButton"){

				this.spriteRenderer.sprite = drillerHighlight;
				hammerButton.GetComponent<SpriteRenderer>().sprite = hammerButton.hammerSprite;
				hammerButton.hammerControl = 0;

				Debug.Log ("DrillerSelected");
				drillerControl = 1;

			}



}
	}
}

