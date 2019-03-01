/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{

    
    [SerializeField]
    private GameObject PlayerExp;
    [SerializeField]
    private UIManager _uiman;
    [SerializeField]
    private float pos;
    [SerializeField]
    private GameObject _para;
    [SerializeField]
    private GameObject _parar;
    [SerializeField]
    private bool released;
    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private AudioSource _audio;


    // Use this for initialization
    void Start()
    {
        _audio=GetComponent<AudioSource>();
        _audio.Play();
        released = false;
        pos = 0.0f;
        //pos = Random.Range(-6.0f, 6.0f);
        transform.position = new Vector3(-9.0f, Random.Range(3.0f, 4.5f), 0.0f);
        _uiman = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_gameManager.pause == false)
            transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        if (transform.position.x > 9.6f)
        {
            transform.position = new Vector3(Random.Range(-8.0f, 7.0f), 6.0f, 0.0f);
            Destroy(this.gameObject);

        }
        float currTime2 = Time.time;
        float currTime = Time.time;
        if ((int)pos == (int)transform.position.x && released == false)
        {
            if (transform.position.x < 0.0f)
                Instantiate(_para, transform.position, Quaternion.identity);
            else
                Instantiate(_parar, transform.position, Quaternion.identity);

            released = true;
        }

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
            Instantiate(PlayerExp, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
        }

    }
}
