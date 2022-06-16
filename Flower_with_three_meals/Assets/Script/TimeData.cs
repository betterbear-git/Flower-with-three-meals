using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeData : MonoBehaviour
{
    [SerializeField] private GameObject inputHour;//시간
    [SerializeField] private GameObject inputMin;//분
    [SerializeField] private GameObject meal;
    //[SerializeField] private GameObject TimeDB;
    TimeDB td = new TimeDB();


    [SerializeField] private GameObject addTimePanel = null;

    private string ampm;
    private string mealStr="";

    public GameObject[] listItem = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        inputHour.GetComponent<Text>().text = "1";
        inputHour.GetComponent<Text>().text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //확인 버튼 눌렀을 때
    public void saveTime()
    {
        int hour, min;

        Debug.Log(inputHour.GetComponent<Text>().text);

        if (inputHour.GetComponent<Text>().text != "")
            hour = int.Parse(inputHour.GetComponent<Text>().text);
        else
            hour = 0;

        if (inputMin.GetComponent<Text>().text != "")
            min = int.Parse(inputMin.GetComponent<Text>().text);
        else
            min = 0;
        //int min = int.Parse(inputMin.GetComponent<Text>().text);

        if(hour>=12)
        {
            ampm = "오후";
            
            if(hour>12)
                hour = hour-12;
        }
        else
        {
            ampm = "오전";
        }

        if(listItem!=null)
        {
            if(listItem[0]!=null&&!listItem[0].activeSelf)
            {
                    listItem[0].SetActive(true);
                    listItem[0].transform.Find("Item1Name").gameObject.GetComponent<Text>().text = meal.GetComponent<Text>().text;
                    listItem[0].transform.Find("Item1AmPm").gameObject.GetComponent<Text>().text = ampm;
                    listItem[0].transform.Find("Item1Time").gameObject.GetComponent<Text>().text = hour +" : "+min;
                td.mh = hour;
                td.mm = min;
            }
            else if (listItem[1] != null&& !listItem[1].activeSelf)
            {
                    listItem[1].SetActive(true);
                    listItem[1].transform.Find("Item1Name").gameObject.GetComponent<Text>().text = meal.GetComponent<Text>().text;
                    listItem[1].transform.Find("Item1AmPm").gameObject.GetComponent<Text>().text = ampm;
                    listItem[1].transform.Find("Item1Time").gameObject.GetComponent<Text>().text = hour + " : " + min;
                td.lh = hour;
                td.lm = min;
            }
            else if (listItem[2] != null&& !listItem[2].activeSelf)
            {
                    listItem[2].SetActive(true);
                    listItem[2].transform.Find("Item1Name").gameObject.GetComponent<Text>().text = meal.GetComponent<Text>().text;
                    listItem[2].transform.Find("Item1AmPm").gameObject.GetComponent<Text>().text = ampm;
                    listItem[2].transform.Find("Item1Time").gameObject.GetComponent<Text>().text = hour + " : " + min;
                td.dh = hour;
                td.dm = min;
            }
        }

        if (addTimePanel.activeSelf == true)
        {
            addTimePanel.SetActive(false);
        }

    }
    
    //아침,점심,저녁 구분
    public void setMeal()
    {
        meal.GetComponent<Text>().text = this.transform.Find("Text").gameObject.GetComponent<Text>().text;
        mealStr = meal.GetComponent<Text>().text;
        Debug.Log(mealStr);
    }
}
