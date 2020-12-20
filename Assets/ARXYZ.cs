using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ARXYZ : MonoBehaviour
{
    public float _speed1 = 100.0f;
    public float _angle1 = 0.0f;
    private int _retourne = 0;
    private float _initialY = 0.0f;
    static public int clickcount=0;
    public int score = 0;
    //Appel du gameplay manager
    private GameplayManager gameplayManager;

    void Awake()
    {
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }
    //Fin d'appel
    // Start is called before the first frame update
    void Start()
    {
        _initialY = this.transform.localPosition.y;
        
        _angle1 = this.transform.localRotation.eulerAngles.x;

    }

    public void SetNoir()
    {
        _angle1 = 180.0f;
        this.transform.localRotation = Quaternion.Euler(_angle1, 0.0f, 0.0f);
        gameplayManager.UpdateScore(-1,clickcount);
    }

    public void SetBlanc()
    {
        _angle1 = 0.0f;
        this.transform.localRotation = Quaternion.Euler(_angle1, 0.0f, 0.0f);
        gameplayManager.UpdateScore(1,clickcount);
    }

    public void Tourner()
    {
        if (this._angle1 == 0.0f)
        {
            _retourne = 1;
            gameplayManager.UpdateScore(-1, clickcount);
        }
            
        if (this._angle1 == 180.0f)
        {
            _retourne = -1;
            gameplayManager.UpdateScore(1, clickcount);
        }
            


    }

    void Update()
    {

        if (_retourne != 0)
        {
            float deltaAngle = _speed1 * Time.deltaTime * _retourne;
            _angle1 += deltaAngle;
            if (_retourne > 0)
            {
                if (_angle1 >= 180.0f)
                {
                    _angle1 = 180.0f;
                    _retourne = 0;
                   // score = -1;
                }
            }
            else 
            {
                if (_angle1 <= 0.0f)
                {
                    _angle1 = 0.0f;
                    _retourne = 0;
                   // score = 1;
                }
            }
            Vector3 pos = this.transform.localPosition;
            pos.y = _initialY + (90.0f - Math.Abs(_angle1 - 90.0f)) / 90.0f * 10.0f;
            this.transform.localPosition = pos;
            this.transform.localRotation = Quaternion.Euler(_angle1, 0.0f, 0.0f);
            
        }
    }

    void OnMouseDown()
    {
        Debug.Log(_angle1);

        int check = 0;
        //_angle1 = this.transform.localRotation.eulerAngles.x;
        //_initialY = this.transform.localPosition.y;
        if ((this._angle1 == 90.0f) && ((clickcount % 2) == 0))
         {
             this.SetNoir();
             clickcount = clickcount + 1;
            check = 1;
        }
        if ((this._angle1 == 90.0f) && ((clickcount % 2) == 1))
         {
            this.SetBlanc();
             clickcount = clickcount + 1;
            check = 1;
        }
       /* if ((this._angle1 == 0.0f) && (check == 0))
        {
           this.SetNoir();
            check = 1;
        }
        if((this._angle1 == 180.0f) && (check==0))
       {
           this.SetBlanc();
            check = 1;
        }*/
       // Debug.Log( clickcount);
         if (this._angle1!=90   && check ==0) 
  {
      this.Tourner();
  }




    }

    // Update is called once per frame
    /* void Update()
     {
         //    _angle1 += _speed1 * Time.deltaTime;
         //    _angle2 += _speed2 * Time.deltaTime;
         //    _angle3 += _speed3 * Time.deltaTime;
         //    this.transform.localRotation = Quaternion.Euler( _angle1, _angle2,_angle3);
         //

         /* if (Input.GetKeyDown("p"))
              _retourne = 1;
          if (Input.GetKeyDown("m"))
              _retourne = -1;

          if(_retourne!=0)
          {
              float deltaAngle = _speed1 * Time.deltaTime * _retourne;
              _angle1 += deltaAngle;
              if(_retourne>0)
              {
                  if(_angle1>=180.0f)
                  {
                      _angle1 = 180.0f;
                      _retourne = 0;
                  }
              }
              else if (_angle1 <= 0.0f)
              {
                  if (_angle1 <= 0.0f)
                  {
                      _angle1 = 0.0f;
                      _retourne = 0;
                  }
              }
              Vector3 pos = this.transform.localPosition;
              pos.y = _initialY + (90.0f - Math.Abs(_angle1 - 90.0f)) / 90.0f * 10.0f;
              this.transform.localPosition = pos;
              this.transform.localRotation = Quaternion.Euler(_angle1, 0.0f, 0.0f);

          }
         OnMouseDown();
     }*/

    public void retournePionBlanc()
    {
        _retourne = 1;
    }

    public void retournePionNoir()
    {
        _retourne = -1;
    }


}