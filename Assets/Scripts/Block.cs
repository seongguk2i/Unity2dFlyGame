using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        // 시작할 때 틈새의 높이를 변경
        ChangeHeight();
    }

    private void ChangeHeight()
    {
        //임의의 높이르 생성하고 설정
        float height = Random.Range(minHeight, maxHeight);
        pivot.transform.localPosition = new Vector3(0.0f, height, 0.0f);
    }

    // ScrollObject 스크립트로부터의 메시지를 받아 높이를 변경
    void OnScrollEnd()
    {
        ChangeHeight();
    }
}
