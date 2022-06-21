using UnityEngine;

namespace Ash
{ 
public class NonStatic_practice : MonoBehaviour
{
        #region data
        private SphereCollider spc;
        private Camera cam;
        #endregion

        #region event
        private void Start()
        {
            if (FindObjectOfType(typeof(Camera)))
            {
            print("攝影機深度："+Camera.main.depth);
            cam = GetComponent<Camera>();
            cam.backgroundColor = Color.green;
            }
            else if(FindObjectOfType(typeof(Mesh)))
            {
            spc = GetComponent<SphereCollider>();
            print("球體碰撞半徑：" + spc.radius);
            }
            
            
        }

        private void Awake()
        {
            
        }

        private void FixedUpdate()
        {
            
        }

        private void Update()
        {
            
        }
        #endregion

        #region function

        #endregion
    }

}

