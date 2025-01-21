using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    public float initialSpeed = 13f;  // �ʱ� �ӵ�
    public float brakePower = 6f;     // �극��ũ �Ŀ� (�������� ����)

    public float currentSpeed1;       // ���� �ӵ�

    private void Start()
    {
        currentSpeed1 = 0f;
    }

    private void Update()
    {
        // �ð��� ���� �ӵ��� ���ҽ�Ŵ
        currentSpeed1 -= brakePower * Time.deltaTime;

        // �ӵ��� 0 ���Ϸ� �������� ����
        if (currentSpeed1 <= 0f)
        {
            currentSpeed1 = 0f;
        }

        // �������� ���� �ӵ��� �̵�
        transform.Translate(Vector3.forward * currentSpeed1 * Time.deltaTime);
    }

    public void StartMoving()
    {
        currentSpeed1 = initialSpeed;  // �ʱ� �ӵ��� �����Ͽ� �����̱� ����
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed1;
    }


}
