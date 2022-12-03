using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class cshSuccessFindClass : MonoBehaviour
{
    public DialogManager DialogManager;

    public void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData(""));
    }
}
