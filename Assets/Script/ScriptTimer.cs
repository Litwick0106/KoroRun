
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptTimer: MonoBehaviour
{
    private float counttime = 0.0f;//���Ԃ��͂���
    public float timeLimit = 5.0f;//��������

    void Start()
    {

    }

    void Update()
    {
        counttime += Time.deltaTime;//�}�C�t���[�����ɂ����������Ԃ𑫂��Ă���


        if (counttime > timeLimit)
        {
            SceneManager.LoadScene("End");//�w�肵�����Ԃ��߂�����V�[���J�ځB("")�̒��ɑJ�ڐ�̃V�[���̖��O�������B
        }

    }
}
