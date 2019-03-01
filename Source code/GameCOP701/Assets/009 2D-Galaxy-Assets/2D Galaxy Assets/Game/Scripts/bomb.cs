/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
    [SerializeField]
    private GameObject go;
    [SerializeField]
    private GameObject go2;
    private GameObject player;
    private GameObject cannon;
    private GameManager gm;
    private UIManager _uiman;
    // Use this for initialization
    void Start () {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Player(Clone)");
        cannon = GameObject.Find("cannon(Clone)");
        _uiman = GameObject.Find("Canvas").GetComponent<UIManager>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down*Time.deltaTime*5.0f);
        
	}
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "laser")
        {
            Destroy(obj.gameObject);
            if (obj.transform.parent != null)
                Destroy(obj.transform.parent.gameObject);
            if (_uiman != null)
                _uiman.updatescore(0);
            Instantiate(go, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (obj.tag == "Player" || obj.tag == "cannon") {
            Instantiate(go, transform.position, Quaternion.identity);
            Instantiate(go2, new Vector3(0, -3.7f, 0), Quaternion.identity);
            if (player != null)
                Destroy(player.gameObject);
            if (cannon != null)
                Destroy(cannon.gameObject);
            _uiman.sop = 0;
            _uiman.var = false;
            _uiman.num = 1;
            gm.gameOver = true;
            _uiman.showGoScreen();
            Destroy(this.gameObject);
        }

    }

}
