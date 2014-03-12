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

	private bool isGrounded;
	
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
			
			if(block1Button.block1Control == 1 && block1Counter > 0){

				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
			
				if(hit.collider != null && hit.collider.transform == this.transform)
					{
						Instantiate(block1,hit.point,Quaternion.identity);
						block1Counter--;
						Debug.Log ("Block 1 Count:" + block1Counter);
					}

			}

			if(block2Button.block2Control == 1 && block2Counter > 0){

				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
				
					if(hit.collider != null && hit.collider.transform == this.transform)
					{
						Instantiate(block2,hit.point,Quaternion.identity);
						block2Counter--;
						Debug.Log ("Block 2 Count:" + block2Counter);
					}

			}
		}

	}
	
}