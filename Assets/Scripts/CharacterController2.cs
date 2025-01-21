using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController2 : MonoBehaviour
{
    private PoliceController policeController; // policeController Ŭ������ �ν��Ͻ�
    public float moveSpeed = 1.5f;
    public float forceMagnitude = 22f; // ���� ũ�⸦ ������ �� �ִ� ����
    public Transform objectToMove;
    private Rigidbody rb;

    void Start()
    {
        rb = objectToMove.GetComponent<Rigidbody>();
        policeController = FindObjectOfType<PoliceController>(); 
    }

    void Update()
    {
        /* vr ���� ���콺�� ������ �� ���
        
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

        // ���콺 �Է¿� ���� ī�޶� ȸ��
        transform.eulerAngles += new Vector3(-mouseY, mouseX, 0f);

        // �ٶ󺸴� �������� ������Ʈ �̵�
        if (dir.magnitude > 0.5f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, Vector3.up);
            objectToMove.rotation = Quaternion.Lerp(objectToMove.rotation, targetRotation, 5f * Time.deltaTime);
            objectToMove.Translate(dir.normalized * moveSpeed * Time.deltaTime);
        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
        float currentSpeed1 = policeController.GetCurrentSpeed();
        if (collision.gameObject.tag == "police")
        {
            if (currentSpeed1 > 0f) // policeController�� currentSpeed�� 0���� ū ��쿡�� ����
            {
                Transform collidedObject = collision.transform;
                transform.LookAt(collidedObject);

                Vector3 forceDirection1 = (transform.position - collision.transform.position).normalized;
                rb.AddForce(forceDirection1 * forceMagnitude, ForceMode.Impulse);

                StartCoroutine(LoadSceneAfterDelay("level2", 4f)); // 4�� �ڿ� "GameOverScene"�� �ε�
            }
        }
    }
    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
