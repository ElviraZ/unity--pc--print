using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintImage : MonoBehaviour
{
 
    public void PrintFile()
    {
        PrintFiles();
    }
   /// <summary>
    /// 打印
    /// </summary>
     void PrintFiles(string path=null)
    {
        path = "d:\\screenshots\\sample.jpg";
        System.Diagnostics.Process process = new System.Diagnostics.Process(); //系统进程
        process.StartInfo.CreateNoWindow = false; //不显示调用程序窗口
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;//
        process.StartInfo.UseShellExecute = true; //采用操作系统自动识别模式
        process.StartInfo.FileName = path; //要打印的文件路径
     
        process.StartInfo.Verb = "print"; //指定对图片执行的动作，打印：print   打开：open …………
        process.Start(); //开始打印
    }
}
