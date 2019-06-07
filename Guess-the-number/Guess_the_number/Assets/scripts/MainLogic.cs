using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLogic : MonoBehaviour
{
    public Text txt;
    int min = 1;
    int max = 1000+1;
    int res;
    void Start()
    {
   
        res = (min + max) / 2;
    }

    public void submit()
    {
        txt.text = res.ToString();
    }
    public void higher()
    {
        min = res;
        max = max;
        res = (min + max) / 2;
        txt.text = res.ToString();
    }
    public void lower()
    {
        min = min;
        max = res;
        res = (min+max)/ 2;
        txt.text = res.ToString();
    }
}
