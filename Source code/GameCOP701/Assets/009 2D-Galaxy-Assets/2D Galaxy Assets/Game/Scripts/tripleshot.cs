/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleshot : MonoBehaviour {
    [SerializeField]
    private AudioClip _audioclip;
    GameManager a;
    // Use this for initialization
    void Start () {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if(a.pause==false)
        transform.Translate(Vector3.down*5.0f*Time.deltaTime);
        if (transform.position.y < -5.0f)
            Destroy(this.gameObject);
	}
    private void OnTriggerEnter2D(Collider2D objother)
    {
        Debug.Log("Collided with" + objother.name);
        if (objother.name == "Player(Clone)" ) 
        { 
            player Player = objother.GetComponent<player>();
            Player.enabletriple();
            AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            Destroy(this.gameObject);
        }
        else if (objother.tag == "laser")
        {  
            player Player = GameObject.Find("Player(Clone)").GetComponent<player>();
            AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            Player.enabletriple();
            Destroy(this.gameObject);

        }
    }
}
