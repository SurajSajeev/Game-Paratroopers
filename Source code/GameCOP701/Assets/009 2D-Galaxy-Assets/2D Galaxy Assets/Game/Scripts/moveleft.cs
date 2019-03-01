/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour {
    private player _player;
    [SerializeField]
    private GameObject _go;
    GameManager a;
    // Use this for initialization
    void Start () {
        _player = GameObject.Find("Player(Clone)").GetComponent<player>();
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 1.9f)
        {
            if (a.pause == false)
                transform.Translate(Vector3.left * 0.4f * Time.deltaTime);
        }
        else
        {
            _player.incL();
            if (_player.leftr() == 4)
            {
                _player.clearL();
                if (_player.set == false)
                {
                    _player.set = true;
                    Instantiate(_go, transform.position, Quaternion.identity);
                }
                Destroy(this.gameObject);

            }
        }
        if (a.gameOver == true)
            Destroy(this.gameObject);
    }
}
