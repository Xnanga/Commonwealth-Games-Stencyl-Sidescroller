using UnityEngine;
using System.Collections;

public class Blk1BtnScr : MonoBehaviour {

	public Blk2BtnScr block2Button;
	public short block1Control = 0;
	public Sprite block1Spritex0;
	public Sprite block1Spritex1;
	public Sprite block1Spritex2;
	public Sprite block1Spritex3;
	public Sprite block1Spritex4;
	public Sprite block1Spritex5;
	public Sprite block1Spritex6;
	public Sprite block1Spritex7;
	public Sprite block1Spritex8;
	public Sprite block1Spritex9;
	public Sprite block1Spritexi10;
	public GameObject block1Highlight;

	public SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		block2Button = GameObject.FindWithTag ("Block2Button").GetComponent<Blk2BtnScr> ();
		block1Highlight = GameObject.Find("Block1ActiveHighlight");
		block1Highlight.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.tag == "Block1Button" ){

				block2Button.block2Highlight.SetActive(false);
				block1Highlight.SetActive (true);

				block2Button.block2Control = 0;
				Debug.Log ("Block 1 Selected");
				block1Control = 1;
					
			}

}
	}
}
