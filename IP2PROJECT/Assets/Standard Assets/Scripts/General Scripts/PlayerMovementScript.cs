using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	public float speed;
    public float jumpForce;
    private bool isGrounded=true;

	// Use this for initialization
	void Start () {
	
    Physics2D.IgnoreLayerCollision(9,8);
    
	}
	
	// Update is called once per frame
	void Update () {
    
    rigidbody2D.fixedAngle = true;
	
    if(Input.GetKey(KeyCode.A)){
    
        transform.position += transform.right * -speed * Time.deltaTime;
	
    }
    if(Input.GetKey(KeyCode.D)){
    
        transform.position -= transform.right * -speed * Time.deltaTime;

    }
    if(((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown (KeyCode.Space))) && (isGrounded == true)){
    
        
        rigidbody2D.AddForce (new Vector2(0,jumpForce));
        
        isGrounded = false;
    

    }
}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "platformFixed"){
        
        	Debug.Log("Player landed.");
			//rigidbody2D.isKinematic = true;
        	isGrounded = true;
        
    	}

		if (collision.gameObject.tag == "PlacedBlocks") {

			Debug.Log ("Player landed.");
			isGrounded = true;

		}
		else
		if (collision.gameObject.tag == "die") {
			
			Debug.Log ("Player died.");

			Application.LoadLevel("MovementTest");
			
		}
    }
}


