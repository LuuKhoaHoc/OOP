using System;

namespace Bài_2
{
    class Student
    {
        private int MSV;
        private string TSV;
        private float DLT, DTH;

        public Student()
        {
            MSV = 1;
            TSV = "Khong co";
            DLT = 0;
            DTH = 0;
        }
        public Student(int newMSV, string newTSV, float newDLT, float newDTH)
        {
            if (newMSV > 0) MSV = newMSV; else MSV = 1;
            if (newTSV != string.Empty) TSV = newTSV; else TSV = "Khong co";
            if ((newDLT >= 0) && (newDLT <= 10)) DLT = newDLT; else DLT = 0;
            if ((newDTH >= 0) && (newDTH <= 10)) DTH = newDTH; else DLT = 0;
        }
        public float DTB()
        {
            return (DLT + DTH) / 2;
        }
        public void setMSV(int newMSV)
        {
            if (newMSV > 0) MSV = newMSV; else MSV = 1;
        }
        public void setTSV(string newTSV)
        {
            if (newTSV != string.Empty) TSV = newTSV; else TSV = "Khong co";
        }
        public void setDLT(float newDLT)
        {
            if ((newDLT >= 0) && (newDLT <= 10)) DLT = newDLT; else DLT = 0;
        }
        public void setDTH(float newDTH)
        {
            if ((newDTH >= 0) && (newDTH <= 10)) DTH = newDTH; else DLT = 0;
        }

        public void toString()
        {
            System.Console.WriteLine("|{0,3}|{1,-25}|{2,10}|{3,10}|{4,10}|", MSV, TSV, DLT, DTH, this.DTB());
        }
        public static void title()
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("|{0,-3}|{1,-25}|{2,-10}|{3,-10}|{4,-10}|", "MSV", "TSV", "DLT", "DTH", "DTB");
            System.Console.WriteLine("*****************************************************************");
            //Dau "-" de can le trai
        }
        public static void end()
        {
            System.Console.WriteLine("*****************************************************************");
        }
        public int getMSV()
        {
            return this.MSV;
        }
        public string getTSV()
        {
            return this.TSV;
        }
        public float getDLT()
        {
            return this.DLT;
        }
        public float getDTH()
        {
            return this.DTH;
        }
    }
}
