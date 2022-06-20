using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ash
{
    /// <summary>
    /// 非靜態API與靜態的差別在於需要一個「實體物件」
    /// 「實體物件」一個存在於場景上的遊戲物件Game Object
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject maskdude;
        [SerializeField]
        private Transform startpoint;
        [SerializeField]
        private Transform ball;
        private void Start()
        {
            //非靜態屬性
            //1.取得
            //語法:  欄位名稱.非靜態屬性
            print("啟動狀態:" + maskdude.activeInHierarchy);  //activeInHierarchy是唯讀
            print("預設圖層:"+ maskdude.layer);
            print("預設位置:" +startpoint.position);

            //2.設定
            //語法:  欄位名稱.非靜態屬性 指定 值
            maskdude.tag = "Player";
            maskdude.layer = 4;
            //maskdude.SetActive(false);
            startpoint.position = new Vector3(-7.0f, -2.0f, 0);
        }
        private void Update()
        {
            ball.Translate(0.1f, 0, 0);
            ball.Rotate(0.1f, 0, 0);
        }
    }

}