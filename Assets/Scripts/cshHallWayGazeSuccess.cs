using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshHallWayGazeSuccess : MonoBehaviour
{
    public Image gazeImg;
    public float time = 2;
    string findObj = "";
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        gazeImg.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(findObj.Equals("CLASS"))
        {
            timer += Time.deltaTime;
            gazeImg.fillAmount = timer / time;
            if (gazeImg.fillAmount == 1 && FindObject.name.Equals("CLASS"))
                SceneManager.LoadScene(3);
        }

        if(findObj.Equals("TOILET"))
        {
            timer += Time.deltaTime;
            gazeImg.fillAmount = timer / time;
            if (gazeImg.fillAmount == 1 && FindObject.name.Equals("TOILET"))
                SceneManager.LoadScene(6);
        }
    }

    public void gazeOnClassSuccess() {
        findObj = "CLASS";
    }

    public void gazeOffClassSuccess()
    {
        findObj = "";
        timer = 0;
        gazeImg.fillAmount = 0;
    }
    public void gazeOnToiletSuccess()
    {
        findObj = "TOILET";
    }

    public void gazeOffToiletSuccess()
    {
        findObj = "";
        timer = 0;
        gazeImg.fillAmount = 0;
    }
}
