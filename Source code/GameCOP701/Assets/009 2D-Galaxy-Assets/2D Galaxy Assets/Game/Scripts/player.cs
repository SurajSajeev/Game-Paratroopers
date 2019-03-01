/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float Speed = 5.0f;
    public float horizontalAxis;// Use this for initialization
    public float verticalAxis;
    public bool canTripleShot=false;
    public int life = 3;
    private UIManager _uiman;
    [SerializeField]
    float canfire = 0.0f;
    float rateoffire = 0.3f;
    float canfire2 = 0.0f;
    float rateoffire2 = 20.0f;
    private AudioSource _audio;
    private AudioSource _audio2;
    public GameObject Laserobject;
    public GameObject Triple;
    public GameObject Mega;
    private float rotationZ = 0f;
    private float sensitivityZ = 2f;
    public int leftenemy = 0;
    public int rightenemy = 0;
    public int leftpair=0;
    public int rightpair=0;
    public bool set = false;
    
    GameManager a;
    void Start () {
        AudioSource[] arr = GetComponents<AudioSource>();
        _audio = arr[0];
        _audio2 = arr[1];
        _uiman = GameObject.Find("Canvas").GetComponent<UIManager>();
        transform.position = new Vector3(0, -3.6f, 0);
        a = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if(a.pause==false){
            lockedRotation();
            shoot();
        }
    }
    public int incle() {
        leftenemy++;
        return leftenemy;
    }
    public void clearenemy() {
        leftenemy = 0;
        rightenemy = 0;
        leftpair = 0;
        rightpair = 0;

    }
    public int incre()
    {
        rightenemy++;
        return leftenemy;
    }
    public int findr() {
        return rightenemy;
    }
    public int findl()
    {
        return leftenemy;
    }
    public int rightr() {
      return  rightpair;
    }
    public int leftr()
    {
        return leftpair;
    }
    public void incR() {
        rightpair++;
    }
    public void incL()
    {
        leftpair++;
    }
    public void clearR() {
        rightpair = 0;
    }
    public void clearL()
    {
        leftpair = 0;
    }
    void shoot()
    {


        if (Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0))
        {

            if (Time.time > canfire)
            {

                if (canTripleShot == true)
                {
                    _audio2.Play();
                    Instantiate(Triple, transform.position, Quaternion.identity);
                }
                else
                {
                    _audio.Play();
                    Instantiate(Laserobject, new Vector3(0, -3.6f, 0), Quaternion.identity);
                    canfire = Time.time + rateoffire;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Time.time > canfire2&&_uiman.num>=2)
            {



                _audio2.Play();
                Instantiate(Mega, transform.position, Quaternion.identity);
                canfire2 = Time.time + rateoffire2;

            }

        }
    }
    public void lockedRotation()
    {
        rotationZ += Input.GetAxis("Horizontal") * sensitivityZ;
        rotationZ = Mathf.Clamp(rotationZ, -65, 65);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
    }
    public void enabletriple() {
        canTripleShot = true;
        StartCoroutine(diablepower());
    }
    public IEnumerator diablepower() {
        yield return new WaitForSeconds(5.0f);
        canTripleShot = false;
    }
}
