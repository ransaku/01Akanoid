using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {

    public float cameraspeed = 4;
    //设置可控属性组件来控制镜头初始移动速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        float h = Input.GetAxis("Horizontal");
        //GetAxis获取轴状态（Horizontal为水平轴，即x方向坐标），返回值h会根据按下的方向键左右有-1到0到1的变化
        transform.Translate(new Vector3(h, 0, 0) * Time.deltaTime * cameraspeed);
        //利用transform中的Translate组件获取方向
        //不做按键操作时h为0，方向不改变。按→时h返回值为1则向(1,0,0)移动，即向右移动，按←时返回值为-1向左移动。
        //由于移动时h的值为1，1帧运行1米，1s约有60帧，按一下1s时间将移动60米。速度太快，需要乘deltaTime(约60分之1)来控制时间间隔，当前速度将变为1s移动1米。
        //再增加cameraspeed变量使镜头速度可控

        float v = Input.GetAxis("Vertical");
        //Vertical为垂直轴，即y方向坐标。
        transform.Translate(new Vector3(0, v, 0) * Time.deltaTime * cameraspeed);
        //控制镜头纵向移动

        
        /*上述代码可合并书写*/
        /*
         float h = Input.GetAxis("Horizontal");
         float v = Input.GetAxis("Vertical");
         
         transform.Translate(new Vector3(h, v, 0) * Time.deltaTime * cameraspeed);

         */
    }
}
