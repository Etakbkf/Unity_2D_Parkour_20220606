using UnityEngine;

namespace Ash
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D����"), Range(0, 3000)]
        private float heighJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump; //�P�_�O�_���U��67-71
        private bool isGround; //�ˬd�O�_�b�a�W

        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color ColorCheckGround = new Color(1,0,0,0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        
        #endregion




        #region �ƥ�
        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color = ColorCheckGround;
            //2.ø�s�ϥ�
            //transform.position ��e���󪺮y��
            Gizmos.DrawCube(transform.position + v3CheckOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        //Input AIP��ĳ��bUpdate�I�s
        //�@���60��(���M��q���į�)
        private void Update()
        {
            Jumpkey();
            CheckGround();
        }
        //�@��T�w50��
        private void FixedUpdate()
        {
            Jumpforce();

        }
        #endregion



        #region �\��
        private void Jumpkey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //print("���D");
                clickJump = true;
            }
           else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void Jumpforce()
        {
            //�p�G�I�����D�åB&&�b�a�O�W
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heighJump));  //���@��y�b�����O
                clickJump = false;
            }
        }
        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGround()
        {
            //2D�I���� = 2D���z,�л\�諬��(�����I�A�ؤo�A����,�ϼh)�F
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckOffset, v3CheckGroundSize, 0,layerCheckGround);
            //print("�I�쪺����:" + hit.name);
            isGround = hit;
        }
        #endregion


    }
}

