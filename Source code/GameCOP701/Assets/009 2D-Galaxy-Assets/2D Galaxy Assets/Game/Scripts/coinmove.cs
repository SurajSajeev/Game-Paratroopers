/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmove : MonoBehaviour
{
    [SerializeField]
    private AudioClip _audioclip;
    GameManager a;
    UIManager b;

    // Use this for initialization
    void Start()
    {
        a = GameObject.Find("GameManager").GetComponent<GameManager>();
        b = GameObject.Find("Canvas").GetComponent<UIManager>();

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
       
        if (objother.name == "Player(Clone)")
        {
            b.updatescore(2);
            AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            Destroy(this.gameObject);
        }
        else if (objother.tag == "laser")
        {
            b.updatescore(2);
            AudioSource.PlayClipAtPoint(_audioclip, Camera.main.transform.position, 1f);
            Destroy(this.gameObject);

        }
    }
}
