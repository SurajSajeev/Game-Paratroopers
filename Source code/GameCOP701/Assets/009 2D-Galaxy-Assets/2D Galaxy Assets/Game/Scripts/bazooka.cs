/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bazooka : MonoBehaviour {

    GameManager a;
    // Use this for initialization
    [SerializeField]
    private GameObject explode;
    private spawnmanager spawn;
    private UIManager ui;
    void Start () {
       
        StartCoroutine(blastoff());
     
        ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator blastoff() {
        yield return new WaitForSeconds(2.0f);
        Instantiate(explode, new Vector3(0.0f, -3.72f, 0), Quaternion.identity);
        if(GameObject.Find("Player(Clone)")!=null)
        Destroy(GameObject.Find("Player(Clone)").gameObject);
        if (GameObject.Find("cannon(Clone)") != null)
            Destroy(GameObject.Find("cannon(Clone)").gameObject);
        a.gameOver = true;
        a.showGoScreen1();
        ui.num = 1;
        ui.sop = 0;
        ui.var = false;
        Destroy(this.gameObject);
        
    }
    
}
