/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expcleanup : MonoBehaviour {
    private AudioSource _audio;
	// Use this for initialization
	void Start () {
        _audio = GetComponent<AudioSource>();
        _audio.Play();
        Destroy(this.gameObject,4f);	
	}
	
	// Update is called once per frame
	
}
