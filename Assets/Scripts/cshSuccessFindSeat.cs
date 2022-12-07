using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class cshSuccessFindSeat : MonoBehaviour
{
    public DialogManager DialogManager;

    public void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("자리 찾기까지 성공~!"));

        var Text1 = new DialogData("한성아 만약 수업 시간에 화장실이 가고 싶으면 어떡해야될까?");
        Text1.SelectList.Add("", "알려줘!");
        Text1.Callback = () => Check_Correct();
        dialogTexts.Add(Text1);

        dialogTexts.Add(new DialogData("수업 시간에 화장실이 가고 싶을 때는 손을 들고, 선생님께 화장실 가고싶다고 말하면 돼~ 쉽지?"));
        dialogTexts.Add(new DialogData("자 그럼 이번에는 화장실을 찾아볼까?"));

        var Text2 = new DialogData("화장실은 복도에 있으니 복도로 나가보자!");
        Text2.SelectList.Add("findToilet", "나가기");
        Text2.Callback = () => Check_Correct();
        dialogTexts.Add(Text2);

        DialogManager.Show(dialogTexts);
    }   

    public void Check_Correct()
    {
        if (DialogManager.Result == "findToilet")
        {
            // 씬 이동하는거 추가해야함.
        }
    }
}
