using UnityEngine;


namespace Ash
{
    public class PassMG : MonoBehaviour
    {
        [SerializeField,Header("�ؼЦW��")]
        private string nameTarget="MaskDude";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private FinalMG finalMG;
        #region �䤤�@�Ӫ��󦳤Ŀ� Is Trigger
        //��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�p�G �I������.�W��.�]�t(MaskDude)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;  //�����]�B�t��
                systemJump.enabled = false; //�������D�t��
                finalMG.enabled = true;  //�Ұʵ����޲z��FinalCanvarsMG
                finalMG.stringTitle = "���ߧA�L��~";
            }
        }
        //��Ӫ���I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        //��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }

        #endregion



        #region �G�Ӫ��󳣨S���Ŀ� Is Trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion



        #region
        #endregion

    }
}
