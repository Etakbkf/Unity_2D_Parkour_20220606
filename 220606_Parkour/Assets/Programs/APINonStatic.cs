using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ash
{
    /// <summary>
    /// �D�R�AAPI�P�R�A���t�O�b��ݭn�@�ӡu���骫��v
    /// �u���骫��v�@�Ӧs�b������W���C������Game Object
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject maskdude;
        [SerializeField]
        private Transform startpoint;
        [SerializeField]
        private Transform ball;
        private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o
            //�y�k:  ���W��.�D�R�A�ݩ�
            print("�Ұʪ��A:" + maskdude.activeInHierarchy);  //activeInHierarchy�O��Ū
            print("�w�]�ϼh:"+ maskdude.layer);
            print("�w�]��m:" +startpoint.position);

            //2.�]�w
            //�y�k:  ���W��.�D�R�A�ݩ� ���w ��
            maskdude.tag = "Player";
            maskdude.layer = 4;
            //maskdude.SetActive(false);
            startpoint.position = new Vector3(-7.0f, -2.0f, 0);
        }
        private void Update()
        {
            ball.Translate(0.1f, 0, 0);
            ball.Rotate(0.1f, 0, 0);
        }
    }

}