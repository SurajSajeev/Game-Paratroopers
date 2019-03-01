/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public bool gameOver = true;
    public bool pause = false;
    public GameObject player;
    private spawnmanager _spawn;
    private UIManager _uiManager;
    public GameObject cannon;
    public Button[] btn;
    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _uiManager.hideGoScreen();
        _spawn = GameObject.Find("SpawnManager").GetComponent<spawnmanager>();
        Button[] btn2 = new Button[11];
        for (int i = 0; i < 11; i++)
            btn2[i] = btn[i].GetComponent<Button>();
        btn2[0].onClick.AddListener(startgame);
        btn2[1].onClick.AddListener(pausegame);
        btn2[2].onClick.AddListener(quitgame);
        btn2[3].onClick.AddListener(showabout);
        btn2[4].onClick.AddListener(showmainsc);
        btn2[5].onClick.AddListener(hidemfc);
        btn2[6].onClick.AddListener(hidemfc);
        btn2[7].onClick.AddListener(hidemfc);
        btn2[8].onClick.AddListener(showam);
        btn2[9].onClick.AddListener(showaf);
        btn2[10].onClick.AddListener(showac);
    }
    public void showGoScreen1() {
        _uiManager.showGoScreen();
    }
    public void showam() {
        _uiManager.showm();
    }
    public void showaf() {
        _uiManager.showf();
    }
    public void showac() {
        _uiManager.showc();
    }
    void startgame() {
        Instantiate(player, new Vector3(0, -3.6f, 0), Quaternion.identity);
        Instantiate(cannon, new Vector3(0, -3.9f, 0), Quaternion.identity);
        gameOver = false;
        _uiManager.HideTitleScreen();
        _spawn.beginroutines();
        _uiManager.num = 1;
        _uiManager.sop = 0;

    }
    void hidemfc() {
        _uiManager.hidemfc();
    }
    
    void showmainsc() {
        _uiManager.hideabout();
    }
    void showabout(){
        _uiManager.ShowAbout();
    }
    void quitgame() {
        Application.Quit();
    }
    void pausegame() {
        if (pause == false)
        {
            pause = true;
            _uiManager.enablePause();
        }
        else
        {
            pause = false;
            _uiManager.DisablePause();

        }
    }
    void Update()
    {
        if (gameOver == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
               Instantiate(player, new Vector3(0, -3.6f, 0), Quaternion.identity);
                Instantiate(cannon, new Vector3(0, -3.9f, 0), Quaternion.identity);
                gameOver = false;
                _uiManager.HideTitleScreen();
                _spawn.beginroutines();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
        if (gameOver == false) {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pause == false)
                {
                    pause = true;
                    _uiManager.enablePause();
                }
                else {
                    pause = false;
                    _uiManager.DisablePause();

                }
            }
        }
    }
}
 