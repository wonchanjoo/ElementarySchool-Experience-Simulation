using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class cshFinalScene : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("어때 한성아? 화장실 찾는 것도 하나도 안어렵지??"));

        dialogTexts.Add(new DialogData("이제 한성이는 상상초등학교 완벽 마스터!! 이제 혼자서도 척척 잘 해낼 수 있다구 ~!!"));

        dialogTexts.Add(new DialogData("한성이가 미션을 잘 성공해줘서 상상부기는 이제 마음 놓고 다른 친구를 도와주러 갈 수 있을 것 같아."));

        var Text1 = new DialogData("한성아, 앞으로 상상초등학교에서 학교생활 열심히 하는거야 알겠지 ??");
        Text1.SelectList.Add("ok1", "응!");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        var Text2 = new DialogData("좋아! 그럼 안녕 ~~~");
        Text2.SelectList.Add("ok2", "끝내기");

        Text2.Callback = () => Check_Correct();

        dialogTexts.Add(Text2);

        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
    }
}
