using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public GameObject MyInfoPanel;

    // Start is called before the first frame update
    void Start()
    {
        ShowHideInfo(true);
    }

    public void ShowHideInfo(bool status) 
    {

        if (status)
        {
            Time.timeScale = 0;
        }else
            Time.timeScale = 1;

        MyInfoPanel.SetActive(status);



    }

   
}
