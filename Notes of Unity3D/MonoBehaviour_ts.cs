﻿using UnityEngine;
using System.Collections;

public class MonoBehaviour_ts : MonoBehaviour {

    
    int UpdateNumber = 0;
    int FixUpdateNumber = 0;



    #region//执行顺序Awake(),OnEnable(),Start(),FixedUpdate(),Update()
    //Update()默认每秒执行60次，会根据运行的物理环境改变而发生改变
    //FixedUpdate(),固定执行次数，不会根据物理运行环境改变而改变
    //FixedUpdate和Update不可以返回
    private void Awake()
    {
        Debug.Log("Awake()");
    }
  
    private void OnEnable()
    {
        Debug.Log("OnEnable()");
    }

    private void Start()
    {
        Debug.Log("Start()");
    }
   
    private void FixedUpdate()//FixedUpdate和Update不可以返回
    {
        if (FixUpdateNumber==1)
        {
            Debug.Log("FixedUpdate()");
            return;
        }
        FixUpdateNumber++;
    }
    private void Update()
    {
        if (UpdateNumber == 1)
        {
            Debug.Log("Update()");
            return;
        }
        UpdateNumber++;
    }


    #endregion


    #region//触发和碰撞函数，每帧会调用一次

    //碰撞函数，触发函数，要求两个物体都有Collider，并且至少有一个物体带刚体组件（Rigidbody）
    //如果触发和碰撞会同时发生，先执行碰撞函数
    //参数为与该物体发生碰撞的物体的信息
    //private void OnCollisionEnter(Collision collision)//开始发生碰撞时执行
    //{
    //    Debug.Log("OnCollisionEnter()");
    //    Debug.Log(collision.gameObject.name);
    //}
    //private void OnCollisionStay(Collision collision)//碰撞持续时执行
    //{
    //    Debug.Log("OnCollisionStay()");
    //}
    //private void OnCollisionExit(Collision collision)//碰撞退出时执行
    //{
    //    Debug.Log("OnCollisionExit()");
    //}



    //private void OnTriggerEnter(Collider other)//开始触发时执行
    //{
    //    Debug.Log("OnTriggerEnter()");
    //    Debug.Log(other.gameObject.name);
    //}
    //private void OnTriggerStay(Collider other)//触发持续时执行
    //{
    //    Debug.Log("OnTriggerStay()");
    //}
    //private void OnTriggerExit(Collider other)//触发结束时执行
    //{
    //    Debug.Log("OnTriggerExit()");
    //}

    #endregion


    #region//鼠标事件OnMouseXXX


    //鼠标点击事件要求游戏物体有碰撞器


    //private void OnMouseDown()//鼠标点击游戏物体时触发
    //{
    //    Debug.Log("OnMouseDown()");
    //}
    //private void OnMouseEnter()//鼠标进入游戏物体时触发
    //{
    //    Debug.Log("OnMouseEnter()");
    //}
    //private void OnMouseDrag()//鼠标拖拽游戏物体时触发
    //{
    //    Debug.Log("nMouseDrag()");
    //}
    //private void OnMouseExit()//鼠标离开游戏物体时触发
    //{
    //    Debug.Log("OnMouseExit()");
    //}
    //private void OnMouseUp()//松开鼠标按钮时调用，鼠标可以不停留在这个游戏物体上
    //{
    //    Debug.Log("OnMouseUp()");
    //}
    //private void OnMouseOver()//鼠标停留在物体上时触发
    //{
    //    Debug.Log("OnMouseOver()");
    //}
    //private void OnMouseUpAsButton()//鼠标松开时并且鼠标还停留在这个游戏物体时才会调用
    //{
    //    Debug.Log("OnMouseUpAsButton()");
    //}


    #endregion

        

    private void OnDisable()
    {
        Debug.Log("OnDisable()");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy()");
    }
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause()");
    }
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit()");
    }
    
    
}
