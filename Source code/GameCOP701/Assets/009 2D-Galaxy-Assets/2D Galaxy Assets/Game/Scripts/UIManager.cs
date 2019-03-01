/**********************************************************************************************************

COP701 : Assignment 2

Authors: Suraj S,       Sriraam S V

         2018MCS2024    2018MCS 2092

************************************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {

    public GameObject[] titleScreen;
    public GameObject GoScreen;
    public GameObject[] about;
    public GameObject[] aboutscreen;

    public Text score;
    public Text level;
    public bool var = false;
    public int sop=0,num=1;
    
    public void updatescore(int n)
    {
        if(n==0)
        sop += 10;
        if (n == 1)
            sop += 5;
        if (n == 2)
            sop += 20;
        score.text = "Score :"+sop;
        if (sop > 200&&var!=true)
        {
            level.text = "Level:" + ++num ;
            
            var = true;
        }
    }

    public void ShowTitleScreen()
    {for(int i=0;i<4;i++)
        titleScreen[i].SetActive(true);
        for (int i = 0; i < 4; i++)
            about[i].SetActive(false);
        for (int i = 0; i < 3; i++)
            aboutscreen[i].SetActive(false);

    }
    public void showm() {
        aboutscreen[0].SetActive(true);
    }
    public void showf()
    {
        aboutscreen[1].SetActive(true);
    }
    public void showc() {
        aboutscreen[2].SetActive(true);
    }
    public void hidemfc() {
        aboutscreen[0].SetActive(false);
        aboutscreen[1].SetActive(false);
        aboutscreen[2].SetActive(false);
    }
    public void hideGoScreen() {
        GoScreen.SetActive(false);
        for (int i = 0; i < 4; i++)
            about[i].SetActive(false);
        for (int i = 0; i < 3; i++)
            aboutscreen[i].SetActive(false);
    }
    public void showGoScreen() {
        GoScreen.SetActive(true);
        titleScreen[1].SetActive(true);
        titleScreen[3].SetActive(true);

    }
    public void enablePause() {
        titleScreen[2].SetActive(true);
        titleScreen[3].SetActive(true);
    }
    public void DisablePause() {
        titleScreen[2].SetActive(false);
        titleScreen[3].SetActive(false);

    }
    public void HideTitleScreen()
    {
        for (int i = 0; i < 5; i++)
            titleScreen[i].SetActive(false);
        GoScreen.SetActive(false);
        score.text = "Score:0";
        level.text = "Level:1";
    }
    public void ShowAbout() {
        for (int i = 0; i < 5; i++)
            titleScreen[i].SetActive(false);

        for (int i = 0; i < 4; i++)
            about[i].SetActive(true);
    }
    public void hideabout() {
        for (int i = 0; i < 4; i++)
            about[i].SetActive(false);
        for (int i = 0; i < 5; i++)
            titleScreen[i].SetActive(true);
        

    }
}
