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
        private bool clickJump;
        #endregion

        #region �ƥ�
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
                print("���D");
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

