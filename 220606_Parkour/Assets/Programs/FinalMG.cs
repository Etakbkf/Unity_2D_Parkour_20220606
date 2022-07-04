using UnityEngine;
using UnityEngine.SceneManagement; //�ޥγ����޲zAPI
using TMPro;  //�ޥΤ�rAPI


namespace Ash
{
    /// <summary>
    /// �޲z�����e�� �L���P����
    /// </summary>
    public class FinalMG : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string stringTitle;  //public�O���F���t�@��script PassMGŪ��
        private void Start()
        {
            textFinal.text = stringTitle;
            //MonoBehaviour���O��API�i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);  //���ЩI�s("��k�W��",����ɶ�,�I�s���j�ɶ�)
        }

        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            //�z���׻��W
            groupFinal.alpha += 0.1f;
            print("�H�J");
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn"); //�����I�s("��k�W��)
            }
        }
        //���s�P�{�����q�覡
        //1.�w�q���}��k
        //2.Button On Click�]�w���}�������}��k
        public void Quit()  //�ۭq���}�C������k
        {
            print("���}�C��");
            //�u�b�o�������ɹq���P����˸m�W���@��
            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("Scene001");
        }
    }
}

