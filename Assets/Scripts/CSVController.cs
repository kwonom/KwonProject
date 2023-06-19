using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;


public class CSVController : MonoBehaviour
{
    public List<RankingData> _lstRanking = new List<RankingData>();
    void Start()
    {
        ReadCSV();
        WriteCSV();
        Debug.Log("csv에서 호출되었습니다.");
    }

    public void WriteCSV()
    {
        string fileName = "RankingList.csv";
        
        StringBuilder sb = new StringBuilder();

        string filePath = Application.persistentDataPath + "/" + fileName;
        sb.AppendLine("이름,점수");

        for(int i = 0; i < _lstRanking.Count; i++)
        {
            sb.AppendLine(_lstRanking[i].GetName() + "," + _lstRanking[i].GetScore());
        }

        using (StreamWriter outStream = File.CreateText(filePath))
        {
            outStream.Write(sb);
        }
    }

    void ReadCSV()
    {
        string path = Application.persistentDataPath + "/RankingList.csv";
        if (File.Exists(path))
        {
            string source;
            using (StreamReader sr = new StreamReader(path))
            {
                string[] lines;
                source = sr.ReadToEnd();
                lines = Regex.Split(source, @"\r\n|\n\r|\n|\r");
                string[] header = Regex.Split(lines[0], ",");
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = Regex.Split(lines[i], ",");
                    if (values.Length == 0 || string.IsNullOrEmpty(values[0])) continue;

                    RankingData rank = new RankingData();
                    rank.SetData(values[0], int.Parse(values[1]));
                    _lstRanking.Add(rank);
                    
                }
            }
        }
        
    }
}

public class RankingData
{
    string Name;
    int Score;

    public void SetData(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetScore()
    {
        return Score;
    }
}
