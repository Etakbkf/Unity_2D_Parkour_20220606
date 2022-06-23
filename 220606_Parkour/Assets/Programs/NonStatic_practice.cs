using UnityEngine;

namespace Ash
{ 
public class NonStatic_practice : MonoBehaviour
{
        #region data
        private SphereCollider spc;
        private Transform trn;
        private Camera cam;
        private GameObject cb;
        private GameObject sp;
        private GameObject cs;
        #endregion

        #region event
        private void Start()
        {
            cam = GetComponent<Camera>();
            spc = GetComponent<SphereCollider>();
            trn = GetComponent<Transform>();
            cb = GameObject.Find("Cube");
            sp = GameObject.Find("Sphere");
            cs = GameObject.Find("Capsule");


            if (gameObject.tag=="MainCamera")
            {
            cam.backgroundColor = Color.green;
            print("攝影機深度：" + cam.depth);
            }

            else if (gameObject.name == "Sphere")
            {
                print("球體碰撞半徑：" + spc.radius);
            }
            else if (gameObject.name == "Capsule")
            {
                trn.localScale = new Vector3(3.0f, 2.0f, 1.0f);
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
            cb.transform.LookAt(sp.transform, Vector3.left);
            cs.GetComponent<Rigidbody>().AddForce(0, 1.0f, 0);
        }
        #endregion

        #region function

        #endregion
    }

}

