using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
    /*  if(collision.gameObject.tag == "portal1")
        {
            stage1Clear();
        }*/        
        
        //if(collision.gameObject.tag == "portal2")
        //{
        //    stage2Clear();
        //}

    }

    public void HomeMenu()
    {
        SceneManager.LoadScene("StartScene");
    }


    public void stage1Clear()
    {
        SceneManager.LoadScene("level2");
    }   
    //public void stage2Clear()
    //{
    //    SceneManager.LoadScene("level3");
    //}

    public void stage1Fail()
    {
        SceneManager.LoadScene("level1");
    }    

    public void stage2Fail()
    {
        SceneManager.LoadScene("level2");
    }


}
