using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshHallWayGaze : MonoBehaviour
{
    public GameObject go;
    public Image gazeImg;
    public float time = 2;
    bool status;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        status = false;
        timer = 0;
        gazeImg.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (status) {
            timer += Time.deltaTime;
            gazeImg.fillAmount = timer / time;
        }
    }

    public void gazeOn() {
        status = true;
    }

    public void gazeOff()
    {
        status = false;
        timer = 0;
        gazeImg.fillAmount = 0;
    }
}
