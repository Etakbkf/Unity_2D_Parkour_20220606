using UnityEngine;

namespace Ash
{ 
    /// <summary>
    /// API �R�A���ϥΤ�k
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
 
        private void Start()
        {
            #region  �Ұ�
            //���o�R�A�ݩ�
            //�y�k
            //���O.�R�A�ݩʦW��
            print("�H����:"+Random.value);
            print("��P�v:" + Mathf.PI);
            print("�L���j:" + Mathf.Infinity);


            //�]�w�R�A�ݩ� set(read only�����)
            //�y�k
            //���O.�R�A�ݩʦW�� ���w ��;
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, -1.0f);     //x�ȬO���k,y�ȬO�W�U,�t�ȬO�V�U���ȬO�V�W
            Time.timeScale = 0.5f;                        //�Ʀr�p�O�C�ʧ@,�Ʀr�j�O�[�t

            //�ϥ��R�A��k
            //�y�k:
            //���O.�R�A��k�W��(�����޼�)
            float rng = Random.Range(30.0f,100.0f);
            print("�H���d��:" + rng);
            #endregion
            #region  �ߧ@
            int camCount = Camera.allCamerasCount;
            print("��v���ƶq:" + camCount);
            print("���ε{�����x:" + Application.platform);
            #endregion
        }




        private void Update()
        {
            #region  �Ұ�
            int rngInt = Random.Range(1, 3);
            print("�H���d��:" + rngInt);
            #endregion
            #region  �ߧ@
            if (Input.anyKey) { print("����:"+Input.anyKey); }


            #endregion
        }




    }

}
