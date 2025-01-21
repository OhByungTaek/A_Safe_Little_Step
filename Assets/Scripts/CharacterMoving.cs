using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMoving : MonoBehaviour
{
    private TruckController truckController; // TruckController 클래스의 인스턴스
    //public float moveSpeed = 2.0f;
    public float forceMagnitude = 22f; // 힘의 크기를 조정할 수 있는 변수
    public Transform objectToMove;
    private Rigidbody rb;

    void Start()
    {
        rb = objectToMove.GetComponent<Rigidbody>();
        truckController = FindObjectOfType<TruckController>(); // Scene에서 TruckController 인스턴스를 찾아와서 할당
    }

    /* 마우스와 키보드로 이동 시 사용
    void Update()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir += Vector3.left;
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // 마우스 입력에 따라 카메라 회전
        transform.eulerAngles += new Vector3(-mouseY, mouseX, 0f);

        // 바라보는 방향으로 오브젝트 이동
        if (dir.magnitude > 0.5f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, Vector3.up);
            objectToMove.rotation = Quaternion.Lerp(objectToMove.rotation, targetRotation, 5f * Time.deltaTime);
            objectToMove.Translate(dir.normalized * moveSpeed * Time.deltaTime);
        }
    }
    */

    void OnCollisionEnter(Collision collision)
    {
        float currentSpeed = truckController.GetCurrentSpeed();
        if (collision.gameObject.tag == "Truck")
        {
            if (currentSpeed > 0f) // truckController의 currentSpeed가 0보다 큰 경우에만 실행
            {
                Transform collidedObject = collision.transform;
                transform.LookAt(collidedObject);
                // 충돌한 물체의 태그가 "TRUCK"인 경우에만 카메라가 바라보도록 설정
                Vector3 forceDirection = (transform.position - collision.transform.position).normalized;

                rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);

                //StartCoroutine(LoadSceneAfterDelay("level1", 4f)); //처음부터 다시 시작
            }
        }
    }
    /*
    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
    */
}
