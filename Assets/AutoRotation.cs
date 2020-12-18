using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    public float _speed = 1000.0f;
    public float _angle = 0.0f;
    // Start is called before the first frame update
   // void Start()
  //  {
        
  //  }

    // Update is called once per frame
    void Update()
    {
        _angle += _speed * Time.deltaTime;


        this.transform.localRotation = Quaternion.Euler(_angle, 0.0f, _angle);
    }
}
