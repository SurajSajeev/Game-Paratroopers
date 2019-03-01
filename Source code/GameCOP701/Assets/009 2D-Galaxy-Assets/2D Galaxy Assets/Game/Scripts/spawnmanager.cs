/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour {
[SerializeField]
    private GameObject powerUp;// Use this for initialization
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject enemyright;
    [SerializeField]
    private GameObject airplane;
    [SerializeField]
    private GameObject coin;
    [SerializeField]
    private GameObject life;
    private GameManager _manager;
    private UIManager _man;
	void Start () {
        _manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _man = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    public void beginroutines() {
        StartCoroutine(enemyspawn());
        StartCoroutine(powerupsp());
        StartCoroutine(airplanesp());
        StartCoroutine(powerupc());
        StartCoroutine(powerupl());
    }

    IEnumerator enemyspawn()
    {
        while (_manager.gameOver==false)
        {
            if (_manager.pause == false)
            {
                Instantiate(enemy, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);

                Instantiate(enemyright, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);

                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator powerupsp() {
        
        while (_manager.gameOver == false ) {
            if (_manager.pause == false)
            {
                
                yield return new WaitForSeconds(7.0f);
                Instantiate(powerUp, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);
                yield return new WaitForSeconds(15.0f);
            }
            yield return new WaitForSeconds(15.0f);
        }

    }
    IEnumerator airplanesp()
    {
        while (_manager.gameOver == false)
        {
            if (_manager.pause == false&&_man.num>=2)
            {
                Instantiate(airplane, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);
                yield return new WaitForSeconds(5.0f);
            }
            yield return new WaitForSeconds(5.0f);
        }

    }
    IEnumerator powerupc()
    {
        while (_manager.gameOver == false)
        {
            yield return new WaitForSeconds(5.0f);
            if (_manager.pause == false)
            {
                Instantiate(coin, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);
                yield return new WaitForSeconds(7.0f);
            }
            yield return new WaitForSeconds(7.0f);
        }

    }
    IEnumerator powerupl() {
        while (_manager.gameOver == false)
        {
            if (_manager.pause == false)
            {
                yield return new WaitForSeconds(8.0f);
                Instantiate(life, new Vector3(Random.Range(-7.0f, 8.0f), 5.0f, 0), Quaternion.identity);
                yield return new WaitForSeconds(35.0f);
            }
            yield return new WaitForSeconds(7.0f);
        }
    }
}
    
