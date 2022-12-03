using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class cshGoToClassText : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("안녕 한성아! 상상초등학교에 입학한 것을 축하해."));

        dialogTexts.Add(new DialogData("난 한성이의 학교 생활을 도와주러 온 상상부기라고 해."));

        // 밑에 두 줄 뺄까 고민중..길어질 것 같음. 좋은뎅? 역시 "N" 답다.. - "S" 찬주

        dialogTexts.Add(new DialogData("학교에 처음 와서 교실이 어디 있고, 자리가 어디인지 몰라 헤맬까봐 걱정된다구?"));

        dialogTexts.Add(new DialogData("걱정하지마! 상상부기와 함께라면 하나도 걱정할 필요 없다구~!"));

        var Text1 = new DialogData("이제부터 나와 같이 다니면서 미리 교실에도 가보고, 자리도 찾아볼거야. 준비됐어??");
        Text1.SelectList.Add("", "응!");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        dialogTexts.Add(new DialogData("좋아. 처음은 한성이의 교실을 먼저 찾아볼거야!"));

        dialogTexts.Add(new DialogData("한성이의 교실은... 1학년 2반!! 1학년 2반 문을 바라보고 기다리면 교실 찾기 성공!!"));

        var Text2 = new DialogData("자 그럼 이제부터 시작해볼까? 상상초등학교로 출발~!!");
        Text2.SelectList.Add("LetsGO", "출발하기");

        Text2.Callback = () => Check_Correct();

        dialogTexts.Add(Text2);

        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
        if(DialogManager.Result == "LetsGO")
        {
            SceneManager.LoadScene(1);
        }
    }
}
