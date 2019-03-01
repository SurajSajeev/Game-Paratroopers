/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
    Vector3 playerdim;
    GameManager a;
    // Use this for initialization
    void Start () {
        
        playerdim = GameObject.Find("Player(Clone)").transform.eulerAngles;
      a  = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(a.pause==false){
            if (playerdim.z > 270)
            {

                transform.Translate((new Vector3((360 - playerdim.z) / 45.0f, 1.0f, 0)) * Time.deltaTime * 10.0f);
            }
            else if (playerdim.z >= 0)
            {

                transform.Translate((new Vector3(-playerdim.z / 45.0f, 1.0f, 0)) * Time.deltaTime * 10.0f);
            }

            if (transform.position.y > 8.08f)

            {
                if (this.transform.parent != null)
                {
                    Destroy(this.transform.parent.gameObject);
                }
                Destroy(this.gameObject);
            }
        }
    }
}
