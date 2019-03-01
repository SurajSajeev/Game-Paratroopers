/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveright : MonoBehaviour
{
    private player _player;
    [SerializeField]
    private GameObject _go;
    GameManager a;
    // Use this for initialization
    void Start()
    {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        _player = GameObject.Find("Player(Clone)").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {if(a.pause==false)
        { 
        if (a.gameOver == true)
            Destroy(this.gameObject);
        if (transform.position.x < -1.9f)
            transform.Translate(Vector3.right * 0.4f * Time.deltaTime);
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
                } Destroy(this.gameObject);
            }
        } }
    }
}
