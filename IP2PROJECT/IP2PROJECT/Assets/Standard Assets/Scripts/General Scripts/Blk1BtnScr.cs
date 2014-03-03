using UnityEngine;
using System.Collections;

public class Blk1BtnScr : MonoBehaviour {

	public Blk2BtnScr block2Button;
	public short block1Control = 0;
	public Sprite block1Sprite;
	public Sprite block1Highlight;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		block2Button = GameObject.FindWithTag ("Block2Button").GetComponent<Blk2BtnScr> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.tag == "Block1Button"){

				this.spriteRenderer.sprite = block1Highlight;
				block2Button.GetComponent<SpriteRenderer>().sprite = block2Button.block2Sprite;
				block2Button.block2Control = 0;


				Debug.Log ("Block 1 Selected");
				block1Control = 1;
				
			}
}
	}
}
