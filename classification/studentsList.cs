using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classification
{
    class studentsList
    {
        List<student> studentslist;
        public studentsList()
        {
            studentslist=new List<student>();
        }

        public void SortForSecion(section sec)
        {
            //OrderBy(o=>o.OrderDate).ToList();
            studentslist = studentslist.OrderByDescending(o => o.getGradeForSection(sec)).ToList();
           
        }

        public student GetStudentyIndex(int index)
        {
            return studentslist[index];
        }

        public void addstudent(student s)
        {
            for (int i = 0; i < studentslist.Count; i++)
            {
                if (studentslist[i].id == s.id)
                {
                    return;
                }
            }
            studentslist.Add(s);
        }
        public bool removeStudent(student st)
        {
            
            var item = studentslist.SingleOrDefault(x => x.id == st.id);
            if (item != null)
            {

                studentslist.Remove(item);
                return true;
            }
            /*
            for (int i = 0; i < studentslist.Count;i++ )
            {
                if(studentslist[i].id == st.id)
                {
                    
                    studentslist.RemoveAt(i);
                    return true;
                }
            }
             * */
            return false;
        }

        internal int GetCount()
        {
            return studentslist.Count;
        }
    }
}
