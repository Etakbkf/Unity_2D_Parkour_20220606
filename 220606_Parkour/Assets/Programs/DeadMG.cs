
using UnityEngine;
namespace Ash
{
    /// <summary>
    /// 管理死亡
    /// </summary>
    public class DeadMG : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "MaskDude";
        [SerializeField, Header("結束管理器")]
        private FinalMG finalMG;
        [SerializeField, Header("CM 攝影機控制物件")]
        private GameObject goCM;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //如果 碰撞物件.名稱.包含(MaskDude)
            if (collision.name.Contains(nameTarget))   
            {
                finalMG.stringTitle = "挑戰失敗~";
                finalMG.enabled = true;   //啟動結束管理器
                goCM.SetActive(false);    //關閉攝影機
            }   
        }
    }
}

