/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TimeCounter : MonoBehaviour
{
    //�J�E���g�_�E��
    public float countdown = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public UnityEngine.UI.Text timeText;

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            timeText.text = "���ԂɂȂ�܂����I";
        }
    }
}
*/