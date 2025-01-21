using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    public float initialSpeed = 13f;  // 초기 속도
    public float brakePower = 6f;     // 브레이크 파워 (느려지는 정도)

    public float currentSpeed1;       // 현재 속도

    private void Start()
    {
        currentSpeed1 = 0f;
    }

    private void Update()
    {
        // 시간에 따라 속도를 감소시킴
        currentSpeed1 -= brakePower * Time.deltaTime;

        // 속도가 0 이하로 떨어지면 정지
        if (currentSpeed1 <= 0f)
        {
            currentSpeed1 = 0f;
        }

        // 경찰차를 현재 속도로 이동
        transform.Translate(Vector3.forward * currentSpeed1 * Time.deltaTime);
    }

    public void StartMoving()
    {
        currentSpeed1 = initialSpeed;  // 초기 속도로 설정하여 움직이기 시작
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed1;
    }


}
