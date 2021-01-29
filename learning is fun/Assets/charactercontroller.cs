using System.Collections;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    Animator anim;
    int JumpHash = Animator.StringToHash("Jump");
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            anim.SetFloat("Speed",1);

            //AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorInfo(0);
            if(Input.GetKeyDown(KeyCode.Space)){
                anim.SetTrigger(JumpHash);
            }
        }
        else{
            anim.SetFloat("Speed",0);
        }
    }
}
