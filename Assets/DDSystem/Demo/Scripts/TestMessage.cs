using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TestMessage : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("my name is Li."));

        dialogTexts.Add(new DialogData("my nweweame is Li."));

        dialogTexts.Add(new DialogData("my name is121212 Li."));

        dialogTexts.Add(new DialogData("my name is 23435454Li."));

        dialogTexts.Add(new DialogData("my name i67676s Li."));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
