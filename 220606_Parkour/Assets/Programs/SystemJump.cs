using UnityEngine;

namespace Ash
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0, 3000)]
        private float heighJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        //Input AIP建議放在Update呼叫
        //一秒約60次(取決於電腦效能)
        private void Update()
        {
            Jumpkey();
        }
        //一秒固定50次
        private void FixedUpdate()
        {
            Jumpforce();
        }
        #endregion

        #region 功能
        private void Jumpkey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍");
                clickJump = true;
            }
           
        }
        private void Jumpforce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heighJump));
                clickJump = false;
            }
        }
        #endregion


    }
}

