using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string TasK;
    public string Answers;
    public Text Tesk;
    public Text a1;
    public Text a2;
    public Text a3;
    public Text a4;

    // Start is called before the first frame update
    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        TasK = s[0];
        Answers = s[1];
        Tesk.text = TasK;
        string[] A = Answers.Split(';');
        a1.text = A[0];
        a2.text = A[1];
        a3.text = A[2];
        a4.text = A[3]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
