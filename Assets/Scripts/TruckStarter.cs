using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckStarter : MonoBehaviour
{
    private int count = 1;
    public GameObject truck; // Ʈ�� ������Ʈ

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) // ���� �浹�� ���
        {
            if (truck != null && count == 1)
            {
                // Ʈ���� ��߽�Ű�� ������ ����
                truck.GetComponent<TruckController>().StartMoving();
                count--;
            }
        }
    }

}
