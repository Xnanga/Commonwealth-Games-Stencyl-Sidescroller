using UnityEngine;
using System.Collections;

public class UserBlockCreate : MonoBehaviour {
	
	
	public HamrBtnScr hammerButton;
	public DrlBtnScr drillerButton;
	public Blk1BtnScr block1Button;
	public Blk2BtnScr block2Button;
	public GameObject block1;
	public GameObject block2;
	
	// Use this for initialization
	void Start () {
		
		hammerButton = GameObject.FindWithTag("HammerButton").GetComponent<HamrBtnScr>();
		drillerButton = GameObject.FindWithTag ("DrillerButton").GetComponent<DrlBtnScr> ();
		block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr>();
		block2Button = GameObject.FindWithTag ("Block2Button").GetComponent<Blk2BtnScr>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (hammerButton.hammerControl == 1 && Input.GetMouseButtonDown(0))
		{
			
			if(block1Button.block1Control == 1){

				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
			
					if(hit.collider != null && hit.collider.transform == this.transform)
					{
						Instantiate(block1,hit.point,Quaternion.identity);
					}

			}

			if(block2Button.block2Control == 1){

				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
				
					if(hit.collider != null && hit.collider.transform == this.transform)
					{
						Instantiate(block2,hit.point,Quaternion.identity);
					}

			}
		}

	}
	
}