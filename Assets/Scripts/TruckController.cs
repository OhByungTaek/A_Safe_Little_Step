using UnityEngine;

public class TruckController : MonoBehaviour
{
    public float initialSpeed = 10f;  // �ʱ� �ӵ�
    public float brakePower = 3.5f;     // �극��ũ �Ŀ� (�������� ����)

    public float currentSpeed;       // ���� �ӵ�

    private void Start()
    {
        currentSpeed = 0f;
    }

    private void Update()
    {
        // �ð��� ���� �ӵ��� ���ҽ�Ŵ
        currentSpeed -= brakePower * Time.deltaTime;

        // �ӵ��� 0 ���Ϸ� �������� ����
        if (currentSpeed <= 0f)
        {
            currentSpeed = 0f;
        }

        // Ʈ���� ���� �ӵ��� �̵�
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    public void StartMoving()
    {
        currentSpeed = initialSpeed;  // �ʱ� �ӵ��� �����Ͽ� �����̱� ����
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }


}