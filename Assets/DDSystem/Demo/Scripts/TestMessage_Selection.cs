using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class TestMessage_Selection : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("my name is Li."));

        dialogTexts.Add(new DialogData("my nweweame is Li."));

        dialogTexts.Add(new DialogData("my name is121212 Li."));

        var Text1 = new DialogData("한번 가볼까??");
        Text1.SelectList.Add("Correct", "좋아");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
        if(DialogManager.Result == "Correct")
        {
            //var dialogTexts = new List<DialogData>();

            //dialogTexts.Add(new DialogData("You are right."));

            //DialogManager.Show(dialogTexts);
            SceneManager.LoadScene(1);
        }
    }
}
