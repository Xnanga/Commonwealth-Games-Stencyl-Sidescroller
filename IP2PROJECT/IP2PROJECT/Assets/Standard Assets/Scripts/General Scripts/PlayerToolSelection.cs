using UnityEngine;
using System.Collections;

public class PlayerToolSelection : MonoBehaviour {

    //public GuiScript theGUI;
    private string toolSelected;
    
    private SpriteRenderer spriteRenderer;
	public Sprite origSprite;
    public Sprite newSprite;

	// Use this for initialization
	void Start () {
	
    //theGUI = GameObject.FindWithTag("MainCamera").GetComponent<GuiScript>();
    spriteRenderer = renderer as SpriteRenderer;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
    
    
    
    /*if(theGUI.buttonControl == 1){
    
        toolSelected = "Hammer";
        this.spriteRenderer.sprite = origSprite;
        
        

    }
    if(theGUI.buttonControl == 2){
    
        toolSelected = "Driller";
        this.spriteRenderer.sprite = newSprite;
        
	
	}*/
}
}

