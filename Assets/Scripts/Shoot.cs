using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    //创建子弹GameObject（需手动将子弹的prefab挂载到该GameObject上）
    public float speed = 25;
    //设置子弹初速度为25

	// Use this for initialization
	void Start () {
        Debug.Log("hello unity");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //检测鼠标左键点击，0为左键
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            //以当前对象（脚本挂载在camera上因此当前对象为camera）坐标和角度实例化子弹bullet，
            //并将返回值赋值给创建的实例对象b
            Rigidbody rgb = b.GetComponent<Rigidbody>();
            //获取实例对象b身上的刚体组件Rigidbody
            rgb.velocity = transform.forward * speed;
            //给该实例对象的刚体组件中的速度赋值，transform.forward为z轴正方向，
            //speed为初速度（speed值可在inspector面板中进行更改，并且以面板中赋值优先）
        }

    }
}
