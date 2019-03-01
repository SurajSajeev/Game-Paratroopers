/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sold_dying : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 2.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
