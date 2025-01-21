using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceStarter : MonoBehaviour
{
    private int count = 1;
    public GameObject police;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) // ���� �浹�� ���
        {
            if (police != null && count == 1)
            {
                // �������� ��߽�Ű�� ������ ����
                police.GetComponent<PoliceController>().StartMoving();
                count--;
            }
        }
    }

}
