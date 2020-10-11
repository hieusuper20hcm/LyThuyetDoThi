using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai1
{
    class Graph
    {
        private int soDinh;
        private int dinh;
        private int[,] arrGraph;

        public void ReadData(string fName)
        {
            StreamReader streamReader = new StreamReader(fName);
            string[] row = streamReader.ReadLine().Split();
            soDinh = int.Parse(row[0]);
            dinh = int.Parse(row[1]);
            arrGraph = new int[soDinh, soDinh];
            for (int i = 0; i < soDinh; i++)
            {
                string[] line = streamReader.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    if(line[j]=="")
                    {
                        arrGraph[i, j] = 0;
                    }    
                    else arrGraph[i, j] = int.Parse(line[j]);
                }
            }
        }
        public void WriteData()
        {
            for (int i = 0; i < soDinh; i++)
            {
                for (int j = 0; j < soDinh; j++)
                {
                    if(arrGraph[i,j]!=0)
                    Console.Write($"{arrGraph[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        public void LienThong(string fName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fName))
            {
                for (int i = 0; i < soDinh; i++)
                {
                    for (int j = 0; j < soDinh; j++)
                    {
                        if (i == dinh-1&&arrGraph[i,j]!=0)
                            streamWriter.Write($"{arrGraph[i, j]}  ");
                    }
                }
            }
        }
    }
}
