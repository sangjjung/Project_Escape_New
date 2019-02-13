using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code_OpenEye : MonoBehaviour
{
    public GameObject Ob_Eye;

    private int Cnt_Touch;

    private Image Img_Blur;

    private void Start()
    {
        Cnt_Touch = 0;
    }

    public void OpenEye()
    {
        Cnt_Touch++;

        if (Cnt_Touch < 10)
        {
            Ob_Eye.transform.position += new Vector3(0, 20, 0);
        }
        else if(Cnt_Touch > 10 && Cnt_Touch < 20)
        {
            Ob_Eye.transform.position += new Vector3(0, 40, 0);
        }
    }

    public void OpenEye_Blur()
    {
        Color Color_blur = Img_Blur.color;
        Color_blur.a -= 0.5f;

    }
}
