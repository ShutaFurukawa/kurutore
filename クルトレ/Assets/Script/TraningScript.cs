using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraningScript : MonoBehaviour
{
    [SerializeField]
    GameObject Aveter;

    [SerializeField]
    GameObject OnPanel, OnUnPanel;

    private bool pauseGame = false;

    public void ButtonPush()
    {
        Debug.Log("Button Push");
    }

	// Use this for initialization
	void Start ()
    {
        OnUnPause();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame = !pauseGame;

            if(pauseGame==true)
            {
                OnPause();
            }
            else
            {
                OnUnPause();
            }
        }
	}

    public void OnPause()
    {
        //OnPlanelをオンにする
        OnPanel.SetActive(true);
        //OnUnPlanelをオフにする
        OnUnPanel.SetActive(false);
        Time.timeScale = 0;
        pauseGame = true;
    }

    public void OnUnPause()
    {
        OnPanel.SetActive(false);
        OnUnPanel.SetActive(true);
        Time.timeScale = 1;
        pauseGame = false;
    }

    public void OnResume()
    {
        OnUnPause();
    }

}
