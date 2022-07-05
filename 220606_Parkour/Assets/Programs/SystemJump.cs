using UnityEngine;

namespace Ash
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump; //判斷是否按下跳67-71
        private bool isGround; //檢查是否在地上
        private AudioSource aud;  //播放音效

        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0, 3000)]
        private float heighJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color ColorCheckGround = new Color(1,0,0,0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump = "Bool_jump";
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;  //存放音效
        #endregion




        #region 事件
        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color = ColorCheckGround;
            //2.繪製圖示
            //transform.position 當前物件的座標
            Gizmos.DrawCube(transform.position + v3CheckOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
            
        }
        //Input AIP建議放在Update呼叫
        //一秒約60次(取決於電腦效能)
        private void Update()
        {
            Jumpkey();
            CheckGround();
            UpdateAnimator();
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
                //print("跳躍");
                clickJump = true;
            }
           else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void Jumpforce()
        {
            //如果點擊跳躍並且&&在地板上
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heighJump));  //給一個y軸的推力
                clickJump = false;
                //音效來源,播放一次音效(音效片段,音量)
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
            }
        }
        /// <summary>
        /// 檢查是否碰到地板
        /// </summary>
        private void CheckGround()
        {
            //2D碰撞器 = 2D物理,覆蓋方型區(中心點，尺寸，角度,圖層)；
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckOffset, v3CheckGroundSize, 0,layerCheckGround);
            //print("碰到的物件:" + hit.name);
            isGround = hit;
        }

        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround); //不在地板上的時候開啟Animator bool parameters的Jump
        }
        #endregion


    }
}

