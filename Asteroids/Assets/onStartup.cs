using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onStartup : MonoBehaviour {

	public GameObject newAsteroid;

	// Use this for initialization
	void Start () {

        float x, y ;

        Debug.Log ("startup");
        
        for( int i=0 ; i < 3 ; i++){       

            x = Random.Range( -25f, +25f );
            y = 9f ; // Random.Range( -10f, +10f );


 

            Quaternion rot = Quaternion.Euler(0, 0, 0);
            //x: -25, 25 y: 10, -10
            Instantiate (newAsteroid, new Vector3(x, y, 0), rot);

        }

    }

	}
	
	// Update is called once per frame
