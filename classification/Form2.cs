using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classification
{
    public partial class Form2 : Form
    {

        sectionsList secList = new sectionsList();
        section tmpSection = new section();
        bool Stop = false;
        //int studentsCount = 10;
        //int sectionsCount = 4;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            
            secList.AddSection(new section(1,"1",3));
            secList.AddSection(new section(2, "2", 2));
            secList.AddSection(new section(3, "3", 2));
            secList.AddSection(new section(4, "4", 3));
            secList.AddSection(new section(5, "5", 1));
            


           //student 1 
            student s1 = new student();
            s1.id = 1;
            s1.name = "1";
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));



            s1.sectionGrade.Add(secList.RestSectionByID(1), 100);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 200);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 2000);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 100);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 10);

            tmpSection.stdlist.addstudent(s1);


            //student 2 
            s1 = new student();
            s1.id = 2;
            s1.name = "2";
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(1));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 900);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 300);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 50);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 300);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 50);

            tmpSection.stdlist.addstudent(s1);



            //student 3 
            s1 = new student();
            s1.id = 3;
            s1.name = "3";
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(3));


            s1.sectionGrade.Add(secList.RestSectionByID(1), 800);
            s1.sectionGrade.Add(secList.RestSectionByID(2),400);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 60);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 200);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 90);



            tmpSection.stdlist.addstudent(s1);



            //student 4 
            s1 = new student();
            s1.id = 4;
            s1.name = "4";
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(1));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 1000);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 20);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 70);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 220);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 70);

            tmpSection.stdlist.addstudent(s1);




            //student 5 
            s1 = new student();
            s1.id = 5;
            s1.name = "5";
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 2000);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 50);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 75);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 250);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 110);

            tmpSection.stdlist.addstudent(s1);



            //student 6 
            s1 = new student();
            s1.id = 6;
            s1.name = "6";
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(4));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 50);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 90);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 72);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 30);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 120);

            tmpSection.stdlist.addstudent(s1);



            //student 7 
            s1 = new student();
            s1.id = 7;
            s1.name = "7";
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 90);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 70);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 83);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 20);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 130);

            tmpSection.stdlist.addstudent(s1);


            //student 8 
            s1 = new student();
            s1.id = 8;
            s1.name = "8";
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(2));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 70);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 70);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 54);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 10);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 200);

            tmpSection.stdlist.addstudent(s1);


            //student 9 
            s1 = new student();
            s1.id = 9;
            s1.name = "9";
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(3));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 10);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 700);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 50);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 900);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 220);

            tmpSection.stdlist.addstudent(s1);


            //student 10 
            s1 = new student();
            s1.id = 10;
            s1.name = "10";
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(1));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(4));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 30);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 900);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 60);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 1000);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 230);

            tmpSection.stdlist.addstudent(s1);





            //student 11 
            s1 = new student();
            s1.id = 11;
            s1.name = "11";
            s1.preferences.AddSection(secList.RestSectionByID(4));
            s1.preferences.AddSection(secList.RestSectionByID(5));
            s1.preferences.AddSection(secList.RestSectionByID(3));
            s1.preferences.AddSection(secList.RestSectionByID(2));
            s1.preferences.AddSection(secList.RestSectionByID(1));

            s1.sectionGrade.Add(secList.RestSectionByID(1), 200);
            s1.sectionGrade.Add(secList.RestSectionByID(2), 1000);
            s1.sectionGrade.Add(secList.RestSectionByID(3), 100);
            s1.sectionGrade.Add(secList.RestSectionByID(4), 2000);
            s1.sectionGrade.Add(secList.RestSectionByID(5), 250);

            tmpSection.stdlist.addstudent(s1);

            
            for (int index = 0; index < secList.secList.Count;index++ )
            {
                tmpSection.id = secList.ReurnSectionByindex(index).id;
                tmpSection.SortWithGrade();
                for (int i = 0; i < secList.ReurnSectionByindex(index).sectionSize; i++)
                {
                    secList.ReurnSectionByindex(index).stdlist.addstudent(tmpSection.stdlist.GetStudentyIndex(i));
                    
                }
                
                for (int i = 0; i < secList.ReurnSectionByindex(index).sectionSize; i++)
                {
                    
                    tmpSection.stdlist.removeStudent(secList.ReurnSectionByindex(index).stdlist.GetStudentyIndex(i));
                }
                
            }

            
            /*
            section HisCurrentSection = secList.ReurnSectionByindex(0);
            student currentStudent = HisCurrentSection.stdlist.GetStudentyIndex(0);
            section SeekedSection = secList.ReurnSectionByindex(1);
            student TargetStudent = SeekedSection.stdlist.GetStudentyIndex(0);

          
                SwapStudents(secList, currentStudent, 0, TargetStudent, 1);
  */



            while (RelocateStudents())
            {
            }
         
            
            int x = 1;

            
            
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Showing results";
            for (int i = 0; i < secList.secList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "in section : ";
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = secList.secList[i].name;
                string sts = "students : ";
                for (int i2 = 0; i2 < secList.secList[i].stdlist.GetCount(); i2++)
                {

                    sts = sts + secList.secList[i].stdlist.GetStudentyIndex(i2).name+",";
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = sts;
            }
        }

        bool SwapStudents(sectionsList SwSeclist,student SwCurrentStudent,int SwCurrentSectionIndex,student SwTargetStudent,int SwTargetSectionIndex)
        {


            secList.ReurnSectionByindex(SwTargetSectionIndex).stdlist.addstudent(SwCurrentStudent);
            if (! secList.ReurnSectionByindex(SwTargetSectionIndex).stdlist.removeStudent(SwTargetStudent))
            {
                return false;
            }

            secList.ReurnSectionByindex(SwCurrentSectionIndex).stdlist.addstudent(SwTargetStudent);
            if (! secList.ReurnSectionByindex(SwCurrentSectionIndex).stdlist.removeStudent(SwCurrentStudent))
            {
                return false;
            }
            return true;
            
        }

        private bool RelocateStudents()
        {
            bool RetVal = false;
            
            for (int Sectionsindex = 0; Sectionsindex < secList.secList.Count; Sectionsindex++) //looping through sections
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "in section";
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = secList.ReurnSectionByindex(Sectionsindex).id;
                for (int StudentIndex = 0; StudentIndex < secList.ReurnSectionByindex(Sectionsindex).stdlist.GetCount(); StudentIndex++) // looping through students    
             {
                 section HisCurrentSection = secList.ReurnSectionByindex(Sectionsindex);
                 student currentStudent = HisCurrentSection.stdlist.GetStudentyIndex(StudentIndex);


                 dataGridView1.Rows.Add();
                 dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "in student";
                 dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = currentStudent.id;
                 dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "in section";
                 dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = HisCurrentSection.id;
                    
                    for (int PerfIndex = 0; PerfIndex < currentStudent.preferences.secList.Count; PerfIndex++)
                    {

                        section compSection=currentStudent.preferences.ReurnSectionByindex(PerfIndex);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Comparing with pref";
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value ="Student: "+ currentStudent.id;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "Current section " + HisCurrentSection.id;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = "better section "+ compSection.id;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = "pref num  " + PerfIndex;
                        dataGridView1.Rows.Add();                         
                        if (compSection == HisCurrentSection)
                        {
                            
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Satisfied";
                            PerfIndex = currentStudent.preferences.secList.Count; // do not try other pref
                        }
                        else    //pref not done
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Not Satisfied";
                            section TargetSection = secList.RestSectionByID(currentStudent.preferences.ReurnSectionByindex(PerfIndex).id);
                            
                            
                            for (int TStudentIndex = 0; TStudentIndex < TargetSection.stdlist.GetCount(); TStudentIndex++) // looping through students in target section
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Trying with section ";
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = TargetSection.id;
                                student TargetStudent = TargetSection.stdlist.GetStudentyIndex(TStudentIndex);
                                if(currentStudent == TargetStudent)
                                {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "It is me  ...";
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "Current Student: " + currentStudent.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "Current Section: " + HisCurrentSection.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = "Target Student: " + TargetStudent.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = "Target Section: " + TargetSection.id;
                                    continue;
                                }


                                if (currentStudent.getGradeForSection(TargetSection) > TargetStudent.getGradeForSection(TargetSection))
                                {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Swapping ...";
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "Current Student: "+ currentStudent.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "Current Section: " + HisCurrentSection.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = "Target Student: " + TargetStudent.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = "Target Section: " + TargetSection.id;


                                    if (!SwapStudents(secList, currentStudent, secList.ResSectionIndex(HisCurrentSection), TargetSection.stdlist.GetStudentyIndex(TStudentIndex), secList.ResSectionIndex(TargetSection)))
                                    {
                                        dataGridView1.Rows.Add();
                                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "ERROR";

                                        return false;
            
                                        
                                    }
                                    
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "RESTARTING ...";
                                    RelocateStudents();
                           //         PerfIndex = currentStudent.preferences.secList.Count;
//                                    StudentIndex++;
                                    return true;
                                }
                                else
                                {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "He deserve more ...";
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "Current Student: " + currentStudent.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "Current Section: " + HisCurrentSection.id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = "Target Student: " + TargetSection.stdlist.GetStudentyIndex(TStudentIndex).id;
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = "Target Section: " + TargetSection.id;
                                }
                                
                            }


                        }

                    }
                    
                }
                
                
            }

            
            /*
            
            bool Relocate = false;
            for (int Sectionsindex = 0; Sectionsindex < secList.secList.Count; Sectionsindex++) //looping through sections
            {
                            
                for (int StudentIndex = 0; StudentIndex < secList.ReurnSectionByindex(Sectionsindex).stdlist.GetCount(); StudentIndex++) // looping through students 
                {

                    section HisCurrentSection = secList.ReurnSectionByindex(Sectionsindex);
                    student currentStudent = HisCurrentSection.stdlist.GetStudentyIndex(StudentIndex);

                    for (int PerfIndex = 0; PerfIndex < currentStudent.preferences.secList.Count; PerfIndex++)
                    {
                        section SeekedSection = secList.RestSectionByID(currentStudent.preferences.ReurnSectionByindex(PerfIndex).id);

                        int PerfForCurrentSection = currentStudent.GerPerfForSection(HisCurrentSection);
                        int PerfForSeekedSection = currentStudent.GerPerfForSection(SeekedSection);
                        if (SeekedSection != HisCurrentSection && (PerfForCurrentSection > PerfForSeekedSection))
                        {
                            for (int StudentInSeekedSectionIndex = 0; StudentInSeekedSectionIndex < SeekedSection.stdlist.GetCount(); StudentInSeekedSectionIndex++)
                            {
                                student TargetStudent = SeekedSection.stdlist.GetStudentyIndex(StudentInSeekedSectionIndex);
                                
                                if (currentStudent.getGradeForSection(SeekedSection) > TargetStudent.getGradeForSection(SeekedSection) )
                                {
                                    int t=secList.ResSectionIndex(SeekedSection);
                               //     if (!SwapStudents(secList, currentStudent, Sectionsindex, TargetStudent,t ))
                                    if (!SwapStudents(secList, currentStudent, t, TargetStudent, Sectionsindex))
                                    {
                                    }
                                      Relocate = true;

                                }

                            }
                        }
                    }

                }

                if(Relocate)
                {
                //    RelocateStudents();
                }
             
            }

            */
               
                return RetVal;
        }

        private void BtnShowResults_Click(object sender, EventArgs e)
        {
            FrmResults frm = new FrmResults();

            for (int i = 0; i < secList.secList.Count;i++ )
            {
                frm.dataGridView1.Columns.Add(secList.secList[i].id.ToString(), secList.secList[i].name);
                while (frm.dataGridView1.Rows.Count < secList.secList[i].stdlist.GetCount())
                {
                    frm.dataGridView1.Rows.Add();
                }
            }
            for (int i = 0; i < secList.secList.Count; i++)
            {
                for (int i2 = 0; i2 < secList.secList[i].stdlist.GetCount(); i2++)
                {
                    int i3=0;
                    while(frm.dataGridView1.Rows[i3].Cells[i].Value != null)
                    {
                        i3++;
                    }
                    frm.dataGridView1.Rows[i3].Cells[i].Value = secList.secList[i].stdlist.GetStudentyIndex(i2).name;
                }
            }


            frm.Show();
        }

    }
}
