using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckStarter : MonoBehaviour
{
    private int count = 1;
    public GameObject truck; // 트럭 오브젝트

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) // 땅과 충돌한 경우
        {
            if (truck != null && count == 1)
            {
                // 트럭을 출발시키는 동작을 수행
                truck.GetComponent<TruckController>().StartMoving();
                count--;
            }
        }
    }

}
