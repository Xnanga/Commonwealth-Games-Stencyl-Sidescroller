/*using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {

    
    public short buttonControl = 0;
    public short buildingSelected = 0;

    
    
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnGUI () {    
    
		if (GUI.Button (new Rect (10,10,100,50), "HAMMER")) {
        
            buttonControl = 1;
            
		}
        
        if (GUI.Button (new Rect (10,80,100,50), "DRILLER")){
        
            buttonControl = 2;

        }
        
        if (GUI.Button (new Rect (20,380,80,40), "Building 1")){
        
            buildingSelected = 1;

            
        }

		if (GUI.Button (new Rect (120, 380, 100, 40), "Buidling 2")) {

			buildingSelected = 2;

		}


	}
}*/
