using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Log : MonoBehaviour
{

    public Text text;



    public void UpdateLog(string message)
    {
        text.text = message;
    }

    
}
