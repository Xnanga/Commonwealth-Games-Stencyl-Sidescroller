using UnityEngine;
using System.Collections;

public class CameraZoomInScr : MonoBehaviour {
	

	public short zoomInControl = 0;
	public Sprite zoomInSprite;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		
		Physics2D.IgnoreLayerCollision(12, 11);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(12, 9);
		Physics2D.IgnoreLayerCollision(12, 8);
		
		spriteRenderer = renderer as SpriteRenderer;

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
			
			
			if(hit.collider != null && hit.collider.tag == "ZoomIn"){
				
				Debug.Log ("Zoomed In.");
				zoomInControl = 1;
				
			}
			
			
			
		}
	}
}

