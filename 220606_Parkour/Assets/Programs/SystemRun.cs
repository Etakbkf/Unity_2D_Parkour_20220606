using UnityEngine; //引用unity引擎命名空間(API)

namespace Ash
{
    //C# 從藍圖變成實體物件
    //1. 場景上的遊戲物件 Game Object 灰色方塊線條
    //2. 將此腳本掛在該物件變成元件
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
      #region   資料:保存系統需要的資料
         //欄位 Field:保存資料
         //語法:

         //修飾詞
         //公開:顯示在面板,允許其他類別存取  public
         //私人:不顯示在面板,不允許其他類別存取  private  (封裝)

         //[] Attribute 屬性,額外功能
         //SerializeField 序列化欄位:將私人欄位顯示
         //Heder 標題:可以使用中文
         //Tooltip 提示:可以使用中文
         //Range 範圍:僅限於數值類型資料 int ,flost, byte, long
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        private Animator ani;
        private Rigidbody2D rig;


        #endregion

        #region   功能:實作該系統的複雜方法
        //方法 Method
        //語法
        //修飾詞  傳回資料類型  方法名稱號(參數)  {程式}

        private void Run()
        {
            print("跑步中~~");
            rig.velocity = new Vector2(speedRun,rig.velocity.y);
        }

      #endregion

      #region   事件:程式入口
         //喚醒事件:開始事件前執行一次、取得元件等等
        private void Awake()
        {
            //ani指定:指定角色身上的 Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

         //開始事件:播放遊戲時執行一次
         //初始化設定: 例如生命值初始化
        private void Start()
        {
           // print("Hello,Stranger");
        }

         //更新事件:每秒執行60次 60FPS
        private void Update()
        {
            //print("<color=yellow>更新事件</color>");
            Run();
        }

      #endregion




    }

}

