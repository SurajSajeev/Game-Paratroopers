/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifescript : MonoBehaviour
{
    [SerializeField]
    private AudioClip _audioclip;
    GameManager a;
    GameObject[] g;
    player p;
    [SerializeField]
    private GameObject ar;
    [SerializeField]
    private AudioClip asa;
    // Use this for initialization
    void Start()
    {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        p = GameObject.Find("Player(Clone)").GetComponent<player>();
        }

    // Update is called once per frame
    void Update()
    {
        if (a.pause == false)
            transform.Translate(Vector3.down * 5.0f * Time.deltaTime);
        if (transform.position.y < -5.0f)
            Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D objother)
    {
        Debug.Log("Collided with" + objother.name);
        if (objother.name == "Player(Clone)")
        {
            g = GameObject.FindGameObjectsWithTag("landed");
            foreach (GameObject f in g)
            {
                Instantiate(ar, f.transform.position, Quaternion.identity);
                Destroy(f);
            }
            p.clearenemy();
            //AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            AudioSource.PlayClipAtPoint(asa,transform.position);
            Destroy(this.gameObject);
        }
        else if (objother.tag == "laser")
        {
            g = GameObject.FindGameObjectsWithTag("landed");
            foreach (GameObject f in g)
            {
                Instantiate(ar, f.transform.position, Quaternion.identity);
                Destroy(f);
            }
            p.clearenemy();
            //AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            AudioSource.PlayClipAtPoint(asa, transform.position);
            Destroy(this.gameObject);

        }
    }
}
