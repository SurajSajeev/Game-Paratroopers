/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paratrooper : MonoBehaviour {
    [SerializeField]
    private UIManager _uiman;
    [SerializeField]
    private GameObject _paratrpland;
    [SerializeField]
    private GameObject _dead;
    GameManager a;
    // Use this for initialization
    void Start () {
        _uiman = GameObject.Find("Canvas").GetComponent<UIManager>();
        a = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (a.pause == false)
        {
            if (transform.position.y > -3.5f)

                transform.Translate(Vector3.down * Time.deltaTime * 2f);
            else
            {
                Instantiate(_paratrpland, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
            if (a.gameOver == true)
                Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "laser") {
            _uiman.updatescore(1);
            Instantiate(_dead,transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
 
