using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{


	private Rigidbody2D rb2d;

        public float fireRate = 2f;
        public float nextShotTime =0f ;

        public float speed;
        public float turnSpeed;

        public GameObject bolt;
        public Transform shotSpawn;
        //public float fireRate;

        //private float nextFire;

	void Start () {

    }

	//	rb2d = GetComponent<Rigidbody2D>();

    void Update()
    {

        if (Input.GetKey (KeyCode.UpArrow)) {
        	transform.Translate(0, Time.deltaTime * -speed, 0);
        }

        if (Input.GetKey (KeyCode.RightArrow)) {

        	//float turn = Input.GetAxis("Horizontal");
        	//GetComponent<Rigidbody2D> ().AddTorque(transform.up * torque * turnSpeed);
        	transform.Rotate(0, 0, Time.deltaTime * -turnSpeed);
        }

        if (Input.GetKey (KeyCode.DownArrow)) {
        	transform.Translate(0, Time.deltaTime * speed, 0);
        }


        if (Input.GetKey (KeyCode.LeftArrow)) {

        	//float turn = Input.GetAxis("Horizontal");
        	//GetComponent<Rigidbody2D> ().AddTorque(transform.up * torque * turnSpeed);
        	transform.Rotate(0, 0, Time.deltaTime * turnSpeed);
        }

        if (Input.GetKey (KeyCode.Space ) && (Time.time > nextShotTime))
         {
            GameObject newBolt = Instantiate(bolt, shotSpawn.position, shotSpawn.rotation);
            Destroy( newBolt, 2.0f );
            nextShotTime = Time.time + fireRate ;
            Debug.Log("space pressed");
        }
     }

     // void OnCollisionEnter2D(Collision2D col)
     // {

     //    string t = col.gameObject.tag.Substring(0,5).ToLower() ;
     //    Debug.Log ("Ship Collided with:"+t );


     //    if(t == "aster"){
     //        Destroy (gameObject);    
     //    }

     // }
}

    // void OnTriggerExit(Collider other)

    //    void OnTriggerEnter2D(Collider2D col)
    // {
    //     Debug.Log ("ShipDead");

    //     Destroy(gameObject);
    // }

    