using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using System.IO;

public class TextFromFile : MonoBehaviour
{
    [SerializeField] private Text decription;
    private string path= "D:\\GitHub\\testTask\\Description.txt";
    private string path2= "D:\\GitHub\\testTask\\Information.txt";
    private string line;
    private void TextFile(string ppath)
    {
        try
        {
            StreamReader sr = new StreamReader(ppath);
            while (!sr.EndOfStream) 
            {
                
                decription.text = line;
                line = sr.ReadLine();
                Debug.Log(line.Length);
            }
            sr.Close();
        }
        catch (System.Exception e)
        {

            Debug.Log(e);
        }
    }
    public void Description()
    {
        TextFile(path);
    }
    public void Information()
    {
        TextFile(path2);
    }
}
