/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//IPointerDownHandler, IPointerUpHandler
public class arrow_touch : MonoBehaviour
{
    private void Start()
    {
        transform.Translate(new Vector2(4, 5));
    }
 
    *//* bool check;
     [SerializeField] private GameObject obj;
     Vector3 pos;
     private float x, y;
     private void Start()
     {
         obj.transform.position = new Vector3(-2, 0.7f, 0); //처음 위치 설정
         setPosition();
     }
     private void Update()
     {
         *//*pos = this.gameObject.transform.position;
         setX(pos.x);
         setY(pos.y);*//*

         if (check)

             transform.Translate(Vector3.up * 2.0f * Time.deltaTime);

     }
     private void setPosition()
     {

     }
     *//*private void setX(float posX)  { x = posX; }
     private void setY(float posY) { y = posY; }
     private float getX() { return x; }
     private float getY() { return y; }

     public void right(){ setPosition();  obj.transform.position = new Vector3(getX() + 0.01f, getY(), 0); }
     public void left() { setPosition(); obj.transform.position = new Vector3(getX() - 1, getY(), 0); }
     public void down() { setPosition(); obj.transform.position = new Vector3(getX(), getY() - 1, 0); }
     public void up() { setPosition(); obj.transform.position = new Vector3(getX(), getY() + 1, 0); }*//*

     public void OnPointerDown(PointerEventData eventData)
     {
         check = true;
     }

     public void OnPointerUp(PointerEventData eventData)
     {
         check = false;
     }*//*
}
*/
/*using UnityEngine;*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class arrow_touch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isBtnDown = false;
    [SerializeField] private InputField input;
    [SerializeField] private GameObject obj;

    private void Update()
    {
        if (isBtnDown == true)
        {
            input.SetTextWithoutNotify("BTN down");
        }
        else
        {
            input.SetTextWithoutNotify("BTN up");
        }
    }

    public void down() { obj.transform.position = new Vector2(transform.position.x - 0.33f * Time.deltaTime, transform.position.y); }
    public void OnPointerDown(PointerEventData eventData)
    {
        obj.transform.position = new Vector2(transform.position.x - 0.33f * Time.deltaTime, transform.position.y);
        isBtnDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
    }

   
}

/*public class arrow_touch : MonoBehaviour
{
    Rigidbody2D rigid;

    private void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - 0.33f * Time.deltaTime, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + 0.33f * Time.deltaTime, transform.position.y);
        }
    }
}*/
