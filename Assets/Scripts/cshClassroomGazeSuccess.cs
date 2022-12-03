using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshClassroomGazeSuccess : MonoBehaviour
{
    public GameObject g;
    public Image GazeImg;
    public float time = 2;
    bool status;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        status = false;
        timer = 0;
        GazeImg.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (status)
        {
            timer += Time.deltaTime;
            GazeImg.fillAmount = timer / time;
            if (GazeImg.fillAmount == 1)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
    public void gazeOnSuccess()
    {
        status = true;
    }

    public void gazeOffSuccess()
    {
        status = false;
        timer = 0;
        GazeImg.fillAmount = 0;
    }
}
