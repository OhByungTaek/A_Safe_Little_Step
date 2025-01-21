using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceStarter : MonoBehaviour
{
    private int count = 1;
    public GameObject police;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) // 땅과 충돌한 경우
        {
            if (police != null && count == 1)
            {
                // 경찰차를 출발시키는 동작을 수행
                police.GetComponent<PoliceController>().StartMoving();
                count--;
            }
        }
    }

}
