using UnityEngine; //�ޥ�unity�����R�W�Ŷ�(API)

namespace Ash
{
    //C# �q�Ź��ܦ����骫��
    //1. �����W���C������ Game Object �Ǧ����u��
    //2. �N���}�����b�Ӫ����ܦ�����
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
      #region   ���:�O�s�t�λݭn�����
         //��� Field:�O�s���
         //�y�k:

         //�׹���
         //���}:��ܦb���O,���\��L���O�s��  public
         //�p�H:����ܦb���O,�����\��L���O�s��  private  (�ʸ�)

         //[] Attribute �ݩ�,�B�~�\��
         //SerializeField �ǦC�����:�N�p�H������
         //Heder ���D:�i�H�ϥΤ���
         //Tooltip ����:�i�H�ϥΤ���
         //Range �d��:�ȭ���ƭ�������� int ,flost, byte, long
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        private Animator ani;
        private Rigidbody2D rig;


        #endregion

        #region   �\��:��@�Өt�Ϊ�������k
        //��k Method
        //�y�k
        //�׹���  �Ǧ^�������  ��k�W�ٸ�(�Ѽ�)  {�{��}

        private void Run()
        {
            print("�]�B��~~");
            rig.velocity = new Vector2(speedRun,rig.velocity.y);
        }

      #endregion

      #region   �ƥ�:�{���J�f
         //����ƥ�:�}�l�ƥ�e����@���B���o���󵥵�
        private void Awake()
        {
            //ani���w:���w���⨭�W�� Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

         //�}�l�ƥ�:����C���ɰ���@��
         //��l�Ƴ]�w: �Ҧp�ͩR�Ȫ�l��
        private void Start()
        {
           // print("Hello,Stranger");
        }

         //��s�ƥ�:�C�����60�� 60FPS
        private void Update()
        {
            //print("<color=yellow>��s�ƥ�</color>");
            Run();
        }

      #endregion




    }

}

