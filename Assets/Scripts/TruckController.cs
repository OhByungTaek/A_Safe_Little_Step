using UnityEngine;

public class TruckController : MonoBehaviour
{
    public float initialSpeed = 10f;  // 초기 속도
    public float brakePower = 3.5f;     // 브레이크 파워 (느려지는 정도)

    public float currentSpeed;       // 현재 속도

    private void Start()
    {
        currentSpeed = 0f;
    }

    private void Update()
    {
        // 시간에 따라 속도를 감소시킴
        currentSpeed -= brakePower * Time.deltaTime;

        // 속도가 0 이하로 떨어지면 정지
        if (currentSpeed <= 0f)
        {
            currentSpeed = 0f;
        }

        // 트럭을 현재 속도로 이동
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    public void StartMoving()
    {
        currentSpeed = initialSpeed;  // 초기 속도로 설정하여 움직이기 시작
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }


}