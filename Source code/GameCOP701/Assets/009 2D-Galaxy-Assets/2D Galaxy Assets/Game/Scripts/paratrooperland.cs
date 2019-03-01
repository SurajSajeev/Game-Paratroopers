/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paratrooperland : MonoBehaviour {
    private player pl;
    bool status;
     [SerializeField]
    private GameObject _rightrun;
    [SerializeField]
    private GameObject _leftrun;
    GameManager a;
    // Use this for initialization
    void Start () {
        pl = GameObject.Find("Player(Clone)").GetComponent<player>();
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        status = false;
    }
	
	// Update is called once per frame
	void Update () {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (a.gameOver == true)
            Destroy(this.gameObject);

        if (transform.position.x < 0.0f && status == false)
        {
            pl.incre();
            status = true;
        }
        else if (status == false)
        {
            pl.incle();
            status = true;

        }
        if (pl.findr() >= 4 && transform.position.x<=0.0f)
        {
            Instantiate(_rightrun,transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (pl.findl() >= 4 && transform.position.x >= 0.0f)
        {
            Instantiate(_leftrun, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
