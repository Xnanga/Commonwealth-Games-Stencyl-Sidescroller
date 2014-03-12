using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	public float speed;
	public float jumpForce;
    private bool isGrounded=true;
	//public UserBlockCreate blockCreation;
	public short hammerCount = 10;
	public short drillerCount = 10;

	// Use this for initialization
	void Start () {
	
    Physics2D.IgnoreLayerCollision(9,8);
	//blockCreation = GameObject.FindWithTag("Background").GetComponent<UserBlockCreate>();
    
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

		if (collision.gameObject.tag == "Block1" || collision.gameObject.tag == "Block2") {

			Debug.Log ("Player landed.");
			isGrounded = true;

		}

		if (collision.gameObject.tag == "die") {
			
			Debug.Log ("Player died.");

			Application.LoadLevel(Application.loadedLevel);
			
		}

		if (collision.gameObject.tag == "Next Level") {
			
			Debug.Log ("Player Successful.");
			
			Application.LoadLevel("JamieLevel1");
			
		}

		if (collision.gameObject.tag == "HammerPickup") {

			hammerCount++;
			Debug.Log (hammerCount);
			Destroy (collision.gameObject);


		}

		if (collision.gameObject.tag == "DiggerPickup") {

			drillerCount++;
			Debug.Log (drillerCount);
			Destroy (collision.gameObject);


		}

	}
}


