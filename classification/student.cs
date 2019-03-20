using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classification
{
    class student
    {
        public int id;
        public sectionsList preferences;
        public Dictionary<section, int> sectionGrade;
        public string name;


        public student()
        {
            id = -1;
            preferences = new sectionsList();
            sectionGrade = new Dictionary<section, int>();
            name = "";
        }

        //public int sectionid;

        public section getSectionBypreference(int prefernceNumber)
        {
            return preferences.ReurnSectionByindex(prefernceNumber);
        }
        public int getGradeForSection(section sec)
        {
            foreach (KeyValuePair<section, int> entry in sectionGrade)
            {
                if (entry.Key == sec)
                {
                    return entry.Value;
                }
            }
            return -1;
            /*
            for (int i = 0; i < sectionGrade.Count;i++ )
            {
                if (sectionGrade.ElementAt(i).Key.id == sec.id)
                {
                    return sectionGrade.ElementAt(i).Value;
                }
                
            }
            return -1;
             * */
        }


        internal int GerPerfForSection(section HisCurrentSection)
        {

            for(int i=0;i<preferences.secList.Count;i++)
            {
                if (preferences.ReurnSectionByindex(i) == HisCurrentSection) 
            {
                    return i;
            }
            }
            return -1;
        }
    }
}
