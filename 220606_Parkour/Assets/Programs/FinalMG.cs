using UnityEngine;
using UnityEngine.SceneManagement; //引用場景管理API
using TMPro;  //引用文字API


namespace Ash
{
    /// <summary>
    /// 管理結束畫面 過關與失敗
    /// </summary>
    public class FinalMG : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;  //public是為了讓另一個script PassMG讀取
        private void Start()
        {
            textFinal.text = stringTitle;
            //MonoBehaviour類別的API可以直接使用名稱呼叫
            InvokeRepeating("FadeIn", 0, 0.2f);  //重覆呼叫("方法名稱",延遲時間,呼叫間隔時間)
        }

        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            //透明度遞增
            groupFinal.alpha += 0.1f;
            print("淡入");
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn"); //取消呼叫("方法名稱)
            }
        }
        //按鈕與程式溝通方式
        //1.定義公開方法
        //2.Button On Click設定此腳本的公開方法
        public void Quit()  //自訂離開遊戲的方法
        {
            print("離開遊戲");
            //只在發布執行檔電腦與手機裝置上有作用
            Application.Quit();
        }
        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("Scene001");
        }
    }
}

