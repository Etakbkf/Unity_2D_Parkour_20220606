using UnityEngine;

namespace Ash
{ 
    /// <summary>
    /// API 靜態的使用方法
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
 
        private void Start()
        {
            #region  課堂
            //取得靜態屬性
            //語法
            //類別.靜態屬性名稱
            print("隨機值:"+Random.value);
            print("圓周率:" + Mathf.PI);
            print("無限大:" + Mathf.Infinity);


            //設定靜態屬性 set(read only不能用)
            //語法
            //類別.靜態屬性名稱 指定 值;
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, -1.0f);     //x值是左右,y值是上下,負值是向下正值是向上
            Time.timeScale = 0.5f;                        //數字小是慢動作,數字大是加速

            //使用靜態方法
            //語法:
            //類別.靜態方法名稱(對應引數)
            float rng = Random.Range(30.0f,100.0f);
            print("隨機範圍:" + rng);
            #endregion
            #region  習作
            int camCount = Camera.allCamerasCount;
            print("攝影機數量:" + camCount);
            print("應用程式平台:" + Application.platform);
            #endregion
        }




        private void Update()
        {
            #region  課堂
            int rngInt = Random.Range(1, 3);
            print("隨機範圍:" + rngInt);
            #endregion
            #region  習作
            if (Input.anyKey) { print("按鍵:"+Input.anyKey); }


            #endregion
        }




    }

}
