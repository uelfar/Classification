using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classification
{
    class section
    {
       public int id;
       public string name;
       public int sectionSize;
       public studentsList stdlist;
       public section()
       {
           id = -1;
           name = "";
           sectionSize = -1;
           stdlist = new studentsList();
       }
       public section(int ID,string Name,int SectionSize)
       {
           id = ID;
           name = Name;
           sectionSize = SectionSize;
           stdlist = new studentsList();

       }
       public static void SwapStudents()
       {
       }
       public  void SortWithGrade()
       {
           stdlist.SortForSecion(this);
       }
/*       void RemoveOverSize()
       {
           stdlist.RemoveRange(SectionSuze, stdlist.Count - SectionSuze);
       }
 * */

       void AddStudent(student st)
       {
           stdlist.addstudent(st);

       }

        public static bool operator== (section sec1, section sec2)
        {
            if(sec1.id == sec2.id)
            {
                return true;
            }else{
                return false;
            }
        }
        public static bool operator !=(section sec1, section sec2)
        {
            if (sec1.id != sec2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
