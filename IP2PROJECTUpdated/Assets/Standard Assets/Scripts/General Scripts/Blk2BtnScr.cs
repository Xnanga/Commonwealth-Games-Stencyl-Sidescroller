using UnityEngine;
using System.Collections;

public class Blk2BtnScr : MonoBehaviour {

	public Blk1BtnScr block1Button;
	public short block2Control = 0;
	public Sprite block2Sprite;
	public Sprite block2Highlight;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.tag == "Block2Button"){

				this.spriteRenderer.sprite = block2Highlight;
				block1Button.GetComponent<SpriteRenderer>().sprite = block1Button.block1Sprite;
				block1Button.block1Control = 0;


				Debug.Log ("Block 2 Selected");
				block2Control = 1;
				
			}
		}
	}
}
