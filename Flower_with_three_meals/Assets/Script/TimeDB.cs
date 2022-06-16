using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDB : MonoBehaviour
{
    public static int tmHour;
    public static int mMin;
    public static int lHour;
    public static int lMin;
    public static int dHour;
    public static int dMin;

    public int mh;
    public int mm;
    public int lm;
    public int lh;
    public int dm;
    public int dh;
    // Start is called before the first frame update
    void Start()
    {
        mh = 0;
        mm = 0;
        lm = 0;
        lh = 0;
        dm = 0;
        dh = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tmHour = mh;
        mMin = mm;
        lHour = lh;
        lMin = lm;
        dHour = dh;
        dMin = dm;
    }
}
