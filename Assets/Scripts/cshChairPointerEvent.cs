using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshChairPointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float BarTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn)
        {
            if (BarTime <= 2.0f)
            {
                BarTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = BarTime / 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        BarTime = 0.0f;
        if (gazedAt)
        {
            Debug.Log("Chiair In");
        }
        else
        {
            Debug.Log("Chair Out");
            LoadingBar.fillAmount = 0;
        }
    }

}
