using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDisable : MonoBehaviour
{
    public float DelayTime = 5;



    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DisableIt),DelayTime);
        
    }

    // Update is called once per frame
    void DisableIt()
    {

        gameObject.SetActive(false);

    }
}
