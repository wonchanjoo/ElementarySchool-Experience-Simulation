using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMoveCamera : MonoBehaviour
{
    public Camera camera;
    private float speed = 1f; // 이동속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * 2.0f * Time.deltaTime, Space.World);  
            MoveLookAt();
        }

    }
    void MoveLookAt()
    {

        Vector3 dir = camera.transform.localRotation * Vector3.forward; // 카메라가 바라보는 방향
        dir.y = 0.0f; // y축은 고정
        transform.Translate(dir * speed * Time.deltaTime); // 보는 방향으로 이동
    }
}
