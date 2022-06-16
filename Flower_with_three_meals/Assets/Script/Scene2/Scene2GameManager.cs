using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Scene2GameManager : MonoBehaviour
{
    [SerializeField] private GameObject nowTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowTime.GetComponent<Text>().text = DateTime.Now.ToString(("HH:mm"));
    }
}
