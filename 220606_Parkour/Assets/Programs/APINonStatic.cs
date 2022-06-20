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
        private void Start()
        {
            //非靜態屬性
            //1.取得
            //語法:  欄位名稱.非靜態屬性
            print("啟動狀態:" + maskdude.activeInHierarchy);  //activeInHierarchy是唯讀
            print("預設圖層:"+ maskdude.layer);

            //2.設定
            //語法:  欄位名稱.非靜態屬性 指定 值
            maskdude.tag = "Player";
            maskdude.layer = 4;
            maskdude.SetActive(false);
        }
    }

}