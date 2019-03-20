using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace classification
{
    class sectionsList
    {
        public BindingList<section> secList;

        public sectionsList()
        {
            secList = new BindingList<section>();
        }
        public section RestSectionByID(int SectionID)
        {
            return secList.First(o => o.id == SectionID);
        }
        public void AddSection(section sec)
        {
            secList.Add(sec);
        }
        public section ReurnSectionByindex(int Index)
        {
            return secList[Index];
        }




        internal int ResSectionIndex(section SeekedSection)
        {
            return secList.IndexOf(SeekedSection);
        }
    }
}
