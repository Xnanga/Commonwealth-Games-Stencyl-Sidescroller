using UnityEngine;
using System.Collections;

public class HamrBtnScr : MonoBehaviour {

	public DrlBtnScr drillerButton;
	public short hammerControl = 0;
	public Sprite hammerSprite;
	public Sprite hammerHighlight;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
	
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		drillerButton = GameObject.FindWithTag ("DrillerButton").GetComponent<DrlBtnScr> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
		
			if (hit.collider != null && hit.collider.tag == "HammerButton") {

				this.spriteRenderer.sprite = hammerHighlight;
				drillerButton.GetComponent<SpriteRenderer>().sprite = drillerButton.drillerSprite;
				drillerButton.drillerControl = 0;

				Debug.Log ("Hammer Selected");
				hammerControl = 1;

			}
		}
	}
}
