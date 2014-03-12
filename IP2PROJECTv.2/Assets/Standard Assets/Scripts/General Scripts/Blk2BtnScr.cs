using UnityEngine;
using System.Collections;

public class Blk2BtnScr : MonoBehaviour {

	public Blk1BtnScr block1Button;
	public short block2Control = 0;
	public Sprite block2Spritex0;
	public Sprite block2Spritex1;
	public Sprite block2Spritex2;
	public Sprite block2Spritex3;
	public Sprite block2Spritex4;
	public Sprite block2Spritex5;
	public Sprite block2Spritex6;
	public Sprite block2Spritex7;
	public Sprite block2Spritex8;
	public Sprite block2Spritex9;
	public Sprite block2Spritexi10;
	public GameObject block2Highlight;

	public SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);

		spriteRenderer = renderer as SpriteRenderer;

		block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr> ();
		block2Highlight = GameObject.Find("Block2ActiveHighlight");
		block2Highlight.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
			if(hit.collider != null && hit.collider.tag == "Block2Button"){

				block1Button.block1Highlight.SetActive(false);
				block2Highlight.SetActive (true);

				block1Button.block1Control = 0;
				Debug.Log ("Block 2 Selected");
				block2Control = 1;
				
			}
		}
	}
}
