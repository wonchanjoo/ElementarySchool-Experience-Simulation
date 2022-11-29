using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshHallWayCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 임시 씬 이동 확인용 
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }

    void OnCollisionEnter(Collision coll) {

        // 로그 확인용. WallOverClass2, WallBeforeClass1, WallBeforeStair1, WallBeforeStair2, NoClassWall 에 해당
        // 굳이 안세워도 camera의 Collider때문에 뚫리지는 않지만 살짝 밖이 보이는 현상이 있어 세워둠.
        // 따로 경고를 주지는 않아도 좋을 것 같음
        if (coll.gameObject.tag == "WALL")
        {
            Debug.Log("WALL");
        }

        // WallClass1 에 해당
        else if(coll.gameObject.tag == "WARNINGWALL")
        {
            Debug.Log("WARNINGWALL");

            // 경고 이미지
            //

        }

        // WallClass2 에 해당
        else if(coll.gameObject.tag == "SUCCESSWALL")
        {
            Debug.Log("SUCCESSWALL");

            // 성공 이미지
            //

            // 스페이스 클릭 시 씬 이동
        }

        // BathRoomCollider 에 해당
        else if (coll.gameObject.tag == "BATHROOM")
        {
            Debug.Log("BATHROOM");
        }

        // 벽 안 세운 곳에 해당.
        else
        {
            Debug.Log("else");
        }
    }
}
