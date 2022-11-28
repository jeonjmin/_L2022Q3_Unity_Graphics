using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Slider : MonoBehaviour
{
    public GameObject MyGameObject;
    Material MyMaterial;
    // Start is called before the first frame update
    void Start()
    {
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged_SetColor()
    {
        float val = GetComponent<Slider>().value;
        print(val);
       OnValueChanged_SetColor c = new OnValueChanged_SetColor(val,val,val,1)
            My
    }
}
