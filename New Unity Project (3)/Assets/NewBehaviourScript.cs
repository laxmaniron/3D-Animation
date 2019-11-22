using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Range(10, 120)] float FrameRate;

    float Timer;
    int count =0;
    int NowFrame = 0;

    [SerializeField] int Data_Size;
    [SerializeField] string Data_Path;
    [SerializeField] string File_Name;


    [SerializeField] GameObject Cube;
    [SerializeField] GameObject Cube1;
    [SerializeField] GameObject Cube2;
    [SerializeField] GameObject Cube3;
    [SerializeField] GameObject Cube4;
    [SerializeField] GameObject Cube5;
    [SerializeField] GameObject Cube6;
    [SerializeField] GameObject Cube7;
    [SerializeField] GameObject Cube8;
    [SerializeField] GameObject Cube9;
    [SerializeField] GameObject Cube10;
    [SerializeField] GameObject Cube11;
    [SerializeField] GameObject Cube12;
    [SerializeField] GameObject Cube13;
    [SerializeField] GameObject Cube14;
    [SerializeField] GameObject Cube15;
    [SerializeField] GameObject Cube16;

    Vector3[] points = new Vector3[17];

    int ite =2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        
        if (Timer > (1 / FrameRate))
        {
            Timer = 0;
       
        
        StreamReader fi = null;
        if (NowFrame < Data_Size)
        {
            fi = new StreamReader(Application.dataPath + Data_Path + File_Name + NowFrame.ToString() + ".txt");
            //Debug.Log(Application.dataPath + Data_Path + File_Name + NowFrame);
            NowFrame++;

            string all = fi.ReadToEnd();
            // Debug.Log(all);
            string[] axis = all.Split(']');
            // Debug.Log(axis[2]);

            string[] yy= axis[2].Replace("[", " ").Replace(Environment.NewLine, " ").Split(' ').Where(s => s != "").ToArray();
            // Debug.Log(yy.Length+" have patience debugging");
            float[] x = axis[0].Replace("[", "").Replace(Environment.NewLine, " ").Split(' ').Where(s => s != "").Select(f => float.Parse(f)).ToArray();
            // Debug.Log(x.Length+" have patience debugging");
            //float[] y = axis[2].Replace("[", "").Replace(Environment.NewLine, " ").Split(' ').Where(s => s != "").Select(f => float.Parse(f)).ToArray();
            string[] z = axis[1].Replace("[", "").Replace(Environment.NewLine, " ").Split(' ').Where(s => s != "").ToArray();

            points[0] = new Vector3(x[0]/100, float.Parse(yy[0])/100, float.Parse(z[0])/100);

            Cube.transform.position=points[0];

            points[1] = new Vector3(x[1]/100, float.Parse(yy[1])/100, float.Parse(z[1])/100);

            Cube1.transform.position=points[1];

            ite = 2;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube2.transform.position=points[ite]; 

            ite = 3;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube3.transform.position=points[ite]; 

            ite = 4;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube4.transform.position=points[ite];

            ite = 5;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube5.transform.position=points[ite];

            ite = 6;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube6.transform.position=points[ite];

            ite = 7;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube7.transform.position=points[ite];

            ite = 8;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube8.transform.position=points[ite];

            ite = 9;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube9.transform.position=points[ite];

            ite = 10;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube10.transform.position=points[ite];

            ite = 11;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube11.transform.position=points[ite];

            ite = 12;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube12.transform.position=points[ite];

            ite = 13;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube13.transform.position=points[ite];

            ite = 14;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube14.transform.position=points[ite];

            ite = 15;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube15.transform.position=points[ite];

            ite = 16;

            points[ite] = new Vector3(x[ite]/100, float.Parse(yy[ite])/100, float.Parse(z[ite])/100);

            Cube16.transform.position=points[ite];

        }

        
        
        }
        
    }
}
