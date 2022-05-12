using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book1_book2 : MonoBehaviour
{
    


    private Animation animati;
    public Transform book_1;
    public Transform book_2;
    public Transform other;
  
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame

    bool flag1 = false;
    bool flag2 = false;
    void Update()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);

            if (dist < 1 && !flag2)
            {
                flag1 = true;
            }
            if (dist > 1)
            {
                flag2 = false;
                flag1 = false;
                show_end();
            }

            if (flag1)
            {
                flag1 = false;
                flag2 = true;
                show();
            }
        }
    }

    void show()
    {
        Debug.Log("start");
    }

    void show_end()
    {
        Debug.Log("end");
    }

   
    
}
