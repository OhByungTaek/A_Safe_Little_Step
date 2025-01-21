using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerTxt;
    public GameObject failPanel;
    public GameObject clearPanel;
    public float time = 15.0f;
    private float countdown;
    bool clear = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "portal")
        {
            clearPanel.SetActive(true);
            clear = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       countdown = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!clear)
        {
            if (Mathf.Floor(countdown) >= 0)
            {
                countdown -= Time.deltaTime;
                timerTxt.text = Mathf.Floor(countdown).ToString() + " 초 안에 빛이 나는 문으로 가세요!";

            }
            else
            {
                failPanel.SetActive(true);
            }
        }

        else
        {
            failPanel.SetActive(false);
        }

    }


}
