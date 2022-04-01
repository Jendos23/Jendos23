using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTN_TXT : MonoBehaviour
{
    public GameObject VPR;
    public Color gr;
    public Color red;
    public Image th;
    public Text t;
    public Task task;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Check()
    {
        if(t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
        }
        else
        {
            th.color = red;
            StartCoroutine(Wait());
        }
    
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        VPR.active = false;
    }
}
