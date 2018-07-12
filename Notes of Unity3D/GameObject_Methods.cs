﻿using UnityEngine;
using System.Collections;
using System;

public class GameObject_Methods : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    private void OnMouseDown()
    {
        //gameObject.AddComponent<>();
        #region//给游戏物体添加一个组件
        //给游戏物体添加一个组件
        //gameObject.AddComponent<>();
        #endregion

        //gameObject.BroadcastMessage();

        //gameObject.CompareTag();
        #region//比较游戏物体的标签是否一样
        //比较游戏物体的标签是否一样，传递参数如果未定义，报错
        //gameObject.CompareTag("Anmy");
        //Debug.Log("CompareTag:"+gameObject.CompareTag("Playr"));
        #endregion

        //gameObject.GetComponent<>();
        #region//获取游戏物体身上的组件
        //获取游戏物体身上的一个组件
        //gameObject.GetComponent<>();
        #endregion

        //gameObject.GetComponentInChildren<>();
        #region//按深度搜索的方法，从自身开始，往子物体查找，返回查找到的第一个组件
        //按深度搜索的方法，从自身开始，往子物体查找，返回查找到的第一个组件。
        //首先查找自身的组件
        //gameObject.GetComponentInChildren<MeshCollider>()
        //if (gameObject.GetComponentInChildren<MeshCollider>()!=null)
        //{
        //    gameObject.GetComponentInChildren<MeshCollider>().enabled = false;
        //}
        //else
        //{
        //    Debug.LogError("组件获取失败");
        //}
        #endregion

        //gameObject.GetComponentInParent<>();
        #region//从自身开始向父物体查找组件，返回找到的第一个组件
        //从自身开始向父物体查找组件，返回找到的第一个组件
        //gameObject.GetComponentInParent<>();

        //if (gameObject.GetComponentInParent<MeshCollider>()!=null)
        //{
        //    gameObject.GetComponentInParent<MeshCollider>().enabled = false;
        //}
        //else
        //{
        //    Debug.Log("组件没有查找到");
        //}
        #endregion

        //gameObject.GetComponentsInChildren<>();
        #region//获取自身和其子物体的所有组件，返回数组
        //获取自身和其子物体的所有组件，返回数组
        //gameObject.GetComponentsInChildren<>();

        //MeshCollider[] components;

        //components= gameObject.GetComponentsInChildren<MeshCollider>();

        //foreach (MeshCollider com in components)
        //{
        //    com.enabled = false;
        //}
        #endregion

        //gameObject.GetComponents<>();
        #region//获取当前游戏物体上的所有组件，返回数组
        //获取当前游戏物体上的所有组件，返回数组
        //获取返回组件的类型com.GetType()
        //获取某个类的类型typeof(组件类名)
        //gameObject.GetComponents<>();
        //Component[] components;

        //components= gameObject.GetComponents<Component>();

        //foreach (Component com in components)
        //{
        //    Debug.Log(com.name);
        //    Debug.Log(com.GetType());
        //    if (com.GetType() == typeof(MeshCollider))
        //    {
        //        ((MeshCollider)com).enabled = false;
        //    }
        //}
        #endregion

        //gameObject.GetComponentsInParent<>();
        #region//获取自身及其所有父物体上的组件，返回数组
        //获取自身及其所有父物体上的组件，返回数组
        //gameObject.GetComponentsInParent<>();

        //MeshCollider[] meshColliders;
        //meshColliders= gameObject.GetComponentsInParent<MeshCollider>();

        //if (meshColliders!=null)
        //{
        //    foreach (MeshCollider mesh in meshColliders)
        //    {
        //        mesh.enabled = false;
        //    }
        //}
        //else
        //{
        //    Debug.LogError("组件未获取到");
        //}
        #endregion

        //gameObject.SendMessage();
        #region//发送消息，不常用
        //gameObject.SendMessage();
        //gameObject.SendMessageUpwards();
        #endregion

        //gameObject.SetActive();
        #region //设置游戏物体的激活状态
        //设置游戏物体的激活状态
        //SetActive(bool a)
        //gameObject.SetActive();

        //gameObject.SetActive(false);

        #endregion

        //GameObject.CreatePrimitive(PrimitiveType.Cube);
        #region//创建基础的游戏物体
        //创建基础的游戏物体
        //GameObject.CreatePrimitive();

        //GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(0, 0, 0);
        #endregion

        //GameObject.Find("Cube/one");
        #region//按路径名字查找游戏物体
        //按路径名字查找游戏物体
        //从最小的子物体层级开始查询，从最下面开始查找
        //游戏物体尽量不重名，使用时最好有路径
        //推荐使用FindWithtag()
        //GameObject.Find();
        //GameObject go = GameObject.Find("Cube");

        //if (go!=null)
        //{
        //    go.GetComponent<MeshRenderer>().enabled=false;
        //    Debug.Log(go.name);
        //}
        //else
        //{
        //    Debug.LogError("游戏物体为空");
        //}
        #endregion

        //GameObject.FindGameObjectsWithTag();
        #region //按tag查找游戏物体，返回数组
        //按tag查找游戏物体，返回数组
        //GameObject.FindGameObjectsWithTag();

        #endregion

        //GameObject.FindGameObjectWithTag();
        #region//按tag查找游戏物体，返回一个游戏物体
        //按tag查找游戏物体，返回一个游戏物体
        //GameObject.FindWithTag();

        //GameObject.FindWithTag("Player").SetActive(false);
        #endregion


        //gameObject.hideFlags;
        //gameObject.name;

        //gameObject.GetInstanceID();
        #region//得到游戏物体在场景中的ID
        //得到游戏物体在场景中的ID
        //每个游戏物体的ID在场景中是不一样的
        //gameObject.GetInstanceID();
        //Debug.Log(gameObject.GetInstanceID());


        //gameObject.ToString();
        #endregion

        //GameObject.Destroy();
        #region//删除游戏物体,组件，资源
        //GameObject.Destroy();

        //删除游戏物体身上的组件
        //删除游戏物体
        //还可以删除资源
        //第二个参数是延迟的时间
        //Destroy(gameObject.GetComponent<MeshCollider>());
        //Destroy(gameObject,2.0f);

        #endregion

        //GameObject.DestroyImmediate();
        #region//立即销毁游戏物体或组件

        //立即销毁游戏物体或组件
        //GameObject.DestroyImmediate();


        #endregion

        //DontDestroyOnLoad();
        #region//加载新场景时不销毁游戏物体
        //加载新场景时不销毁游戏物体
        //GameObject.DontDestroyOnLoad();
        #endregion

        //GameObject.FindObjectOfType();
        #region //按type查找游戏物体，返回一个游戏物体
        //按type查找游戏物体，返回一个游戏物体
        //GameObject.FindObjectOfType<>();

        //GameObject.FindObjectOfType(typeof(GameObject));
        //Debug.Log(GameObject.FindObjectOfType(typeof(GameObject)).name);

        //GameObject.FindObjectsOfType<>();
        //GameObject.Instantiate();
        #endregion

        #region//按type查找游戏物体，返回数组
        //按type查找游戏物体，返回数组
        //GameObject.FindObjectsOfType<>();
        #endregion

        //Component和GameObject都继承自Object，有共同的方法，GetComponent系列的方法可以达到同样的效果
        //gameObject.GetComponent<MeshCollider>().GetComponent<BoxCollider>().enabled = false;


    }
}
