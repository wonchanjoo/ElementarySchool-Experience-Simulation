using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshHallWayGazeSuccess : MonoBehaviour
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
            if (gazeImg.fillAmount == 1) {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void gazeOnSuccess() {
        status = true;
    }

    public void gazeOffSuccess()
    {
        status = false;
        timer = 0;
        gazeImg.fillAmount = 0;
    }
}
