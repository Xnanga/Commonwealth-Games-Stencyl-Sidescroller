using UnityEngine;
using System.Collections;

public class UserBlockCreate : MonoBehaviour {
	
	
	public HamrBtnScr hammerButton;
	public DrlBtnScr drillerButton;
	public Blk1BtnScr block1Button;
	public Blk2BtnScr block2Button;
	public GameObject block1;
	public GameObject block2;
	public int block1Counter = 10;
	public int block2Counter = 10;

	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		hammerButton = GameObject.FindWithTag("HammerButton").GetComponent<HamrBtnScr>();
		drillerButton = GameObject.FindWithTag ("DrillerButton").GetComponent<DrlBtnScr> ();
		block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr>();
		block2Button = GameObject.FindWithTag ("Block2Button").GetComponent<Blk2BtnScr>();

		spriteRenderer = renderer as SpriteRenderer;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (hammerButton.hammerControl == 1 && Input.GetMouseButtonDown (0)) {
			
						if (block1Button.block1Control == 1 && block1Counter > 0) {

								Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
								RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
								if (hit.collider != null && hit.collider.transform == this.transform) {
						
										block1Counter--;
										Instantiate (block1, hit.point, Quaternion.identity);

										Debug.Log ("Block 1 Count:" + block1Counter);

										if (block1Counter == 10) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritexi10;
						
										} else if (block1Counter == 9) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex9;
						
										} else if (block1Counter == 8) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex8;
						
										} else if (block1Counter == 7) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex7;
						
										} else if (block1Counter == 6) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex6;
						
										} else if (block1Counter == 5) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex5;
						
										} else if (block1Counter == 4) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex4;
						
										} else if (block1Counter == 3) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex3;
						
										} else if (block1Counter == 2) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex2;
						
										} else if (block1Counter == 1) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex1;
						
										} else if (block1Counter == 0) {
						
												block1Button.spriteRenderer.sprite = block1Button.block1Spritex0;
						
										}

								}

						}



						if (block2Button.block2Control == 1 && block2Counter > 0) {

								Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
								RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
				
								if (hit.collider != null && hit.collider.transform == this.transform) {
										Instantiate (block2, hit.point, Quaternion.identity);
										block2Counter--;
										Debug.Log ("Block 2 Count:" + block2Counter);

										if (block2Counter == 10) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritexi10;
					
										} else if (block2Counter == 9) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex9;
					
										} else if (block2Counter == 8) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex8;
					
										} else if (block2Counter == 7) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex7;
					
										} else if (block2Counter == 6) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex6;
					
										} else if (block2Counter == 5) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex5;
					
										} else if (block2Counter == 4) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex4;
					
										} else if (block2Counter == 3) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex3;
					
										} else if (block1Counter == 2) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex2;
					
										} else if (block2Counter == 1) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex1;
					
										} else if (block2Counter == 0) {
					
												block2Button.spriteRenderer.sprite = block2Button.block2Spritex0;
					
										}
				
								}
			
						}
				}
		
		
		
		
	}
	
}

