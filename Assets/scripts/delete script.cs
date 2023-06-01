using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletescript : MonoBehaviour
{
    // Start is called before the first frame update
    public void startdelete()
    {
        StartCoroutine(destroy());
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(50);
        Object.Destroy(this.gameObject);
    }

}
