using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidDestroy : MonoBehaviour {


    public GameObject newAsteroid;

	// Use this for initialization
	void Start () {
	}
	
    private void resetPosition(){
        float oldX, oldY, newX, newY ;


        oldX = transform.position.x ;
        oldY = transform.position.y ;

        newX = Random.Range( -25f, +25f );
        newY = 9 ; // Random.Range( -10f, +10f );

        // Quaternion rot = Quaternion.Euler(0f, 0f, 0f);
        //x: -25, 25 y: 10, -10
        //Instantiate (newAsteroid, new Vector3(x, y, 0f), rot);

        transform.Translate( new Vector3( (newX - oldX), (newY - oldY), 0));       
    }


    void OnCollisionEnter2D( Collision2D col ){
        Debug.Log("Something hit asteroid:"+col.gameObject.tag);

        if( col.gameObject.tag.ToLower() != "asteroid"){
            Destroy( col.gameObject );    
        }
        
        resetPosition();
    }

    void Update(){
        if( transform.position.y < -9){
            resetPosition();
        }
    }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    // 	Debug.Log ("I got triggered");

    // 	Destroy(gameObject);
    //  }
}
