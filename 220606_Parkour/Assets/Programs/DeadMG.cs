
using UnityEngine;
namespace Ash
{
    /// <summary>
    /// �޲z���`
    /// </summary>
    public class DeadMG : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "MaskDude";
        [SerializeField, Header("�����޲z��")]
        private FinalMG finalMG;
        [SerializeField, Header("CM ��v�������")]
        private GameObject goCM;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�p�G �I������.�W��.�]�t(MaskDude)
            if (collision.name.Contains(nameTarget))   
            {
                finalMG.stringTitle = "�D�ԥ���~";
                finalMG.enabled = true;   //�Ұʵ����޲z��
                goCM.SetActive(false);    //������v��
            }   
        }
    }
}

