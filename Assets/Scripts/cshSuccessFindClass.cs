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

        dialogTexts.Add(new DialogData("좋아 교실을 잘 찾아왔어!! 생각보다 어렵지 않지?"));
        dialogTexts.Add(new DialogData("이번에는 한성이의 자리를 찾아가볼거야."));
        dialogTexts.Add(new DialogData("칠판에 붙어있는 좌석표를 보고 자리를 찾아보자!"));
        dialogTexts.Add(new DialogData("한성이의 자리를 찾아가서 바라보면 성공이야!"));

        var Text = new DialogData("이번에도 잘 할 수 있지?! 화이팅~!");
        Text.SelectList.Add("StartFindSeat", "시작하기");
        Text.Callback = () => Check_Correct();

        dialogTexts.Add(Text);
        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
        if(DialogManager.Result == "StartFindSeat")
        {
            SceneManager.LoadScene(2);
        }
    }
}
