using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public GameObject nowTime;
    private TimeDB td = new TimeDB();
    public RectTransform transform_hour;
    public RectTransform transform_mhour;
    public RectTransform transform_lhour;
    public RectTransform transform_dhour;
    //public RectTransform transform_min;
    //public RectTransform transform_sec;
    //public Text text_date;
    public Text text_get;
    //public Button button_get;


    private float hour;

    private float getMhour;
    private float getMmin;
    private float mhour;

    private float getLhour;
    private float getLmin;
    private float lhour;

    private float getDhour;
    private float getDmin;
    private float dhour;

    private void Start()
    {
        Init_UI();
        Init_Time();

        
            //if (TimerDB != null)
            //{
            //getMhour = td.tmHour;
            getMmin = td.mm;
            getLhour = td.lh;
            getLmin = td.lm;
            getDhour = td.dh;
            getDmin = td.dm;
        //}
    }

    private void Init_Time()
    {
        if (IsInvoking("Update_Time"))
            CancelInvoke("Update_Time");
        InvokeRepeating("Update_Time", 0, 0.2f);
    }

    private void Init_UI()
    {
        transform_hour.pivot = new Vector2(0.5f, 0.1f);
        transform_mhour.pivot = new Vector2(0.5f, 0.1f);
        transform_lhour.pivot = new Vector2(0.5f, 0.1f);
        transform_dhour.pivot = new Vector2(0.5f, 0.1f);
        //transform_min.pivot = new Vector2(0.5f, 0.1f);
        //transform_sec.pivot = new Vector2(0.5f, 0.1f);

        //button_get.onClick.RemoveAllListeners();
        //button_get.onClick.AddListener(Get_Time);
    }

    private void Update_Time()
    {

        DateTime now = DateTime.Now;
        hour = (now.Hour / 12f) * 360f + (now.Minute / 60f) * 30f;
        mhour = (8 / 12f) * 360f + (10 / 60f) * 30f;
        lhour = (13 / 12f) * 360f + (20 / 60f) * 30f;
        dhour = (18 / 12f) * 360f + (30 / 60f) * 30f;
        nowTime.GetComponent<Text>().text = now.Hour+" : "+now.Minute;
        //min = (now.Minute / 60f) * 360f;

        transform_hour.localRotation = Quaternion.Euler(0f, 0f, -hour);
        transform_mhour.localRotation = Quaternion.Euler(0f, 0f, -mhour);
        transform_lhour.localRotation = Quaternion.Euler(0f, 0f, -lhour);
        transform_dhour.localRotation = Quaternion.Euler(0f, 0f, -dhour);
        //transform_min.localRotation = Quaternion.Euler(0f, 0f, -min);
        //transform_sec.localRotation = Quaternion.Euler(0f, 0f, -sec);

        //text_date.text = string.Format("{0}\n{1} {2}/{3}", now.ToString("tt"), now.DayOfWeek.ToString().ToUpper().Substring(0, 3), now.Month, now.Day);

    }
    private void Get_Time()
    {
        DateTime now = DateTime.Now;
        text_get.text = string.Format("{0}\n{1}/{2} {3}", now.ToString("tt hh:mm:ss"), now.Month, now.Day, now.DayOfWeek.ToString().ToUpper().Substring(0, 3));
        Debug.LogError(text_get.text);
    }
}
