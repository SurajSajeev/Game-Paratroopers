/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mega : MonoBehaviour {
    [SerializeField]
    GameObject go,exp,bur;

    player p;
    GameObject[] g;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0,-3.7f,0);
        p = GameObject.Find("Player(Clone)").GetComponent<player>();

    }

    // Update is called once per frame
    void Update () {
        if (transform.position.y < 2.5f)
            transform.Translate(1.0f * Vector3.up * Time.deltaTime);
        else {
            Instantiate(go,transform.position,Quaternion.identity);
            g = GameObject.FindGameObjectsWithTag("landed");
            if (g != null)
                foreach (GameObject f in g)
            {
                Instantiate(exp, f.transform.position, Quaternion.identity);
                Destroy(f);
            }

            g = GameObject.FindGameObjectsWithTag("enemy");
            if (g != null)
                foreach (GameObject f in g)
            {
                Instantiate(go, f.transform.position, Quaternion.identity);
                Destroy(f);
            }
            g = GameObject.FindGameObjectsWithTag("enemyliving");
            if (g != null)
                foreach (GameObject f in g)
            {
                Instantiate(bur, f.transform.position, Quaternion.identity);
                Destroy(f);
            }
            g = GameObject.FindGameObjectsWithTag("enemyliving2");
            if(g!=null)
            foreach (GameObject f in g)
            {
                Instantiate(exp, f.transform.position, Quaternion.identity);
                Destroy(f);
            }
            p.clearenemy();
            //AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            //AudioSource.PlayClipAtPoint(asa, transform.position);


            Destroy(this.gameObject);
            
        }
	}
    
}
