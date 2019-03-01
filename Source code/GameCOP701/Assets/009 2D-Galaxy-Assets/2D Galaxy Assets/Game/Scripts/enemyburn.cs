/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyburn : MonoBehaviour {
    GameManager a;
    // Use this for initialization
    void Start () {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(this.gameObject, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if(a.pause==false)
        transform.Translate(Vector3.down * Time.deltaTime * 1.0f);
    }
}
