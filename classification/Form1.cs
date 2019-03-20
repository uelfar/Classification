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
    public partial class Form1 : Form
    {
        int studentsCount = 10;
        int classesCount = 4;
        //List<List<int>> studentsPerferences;
        Dictionary<int, List<int>> studentsPerferences;
        Dictionary<int, List<int>> studentsgrades;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getinitials();
        }

        private void getinitials()
        {

            for (int i = 0; i < studentsCount;i++ )
            {
                studentsPerferences.Add(i, new List<int>());
            }
            studentsPerferences[0].Add(1);
            studentsPerferences[0].Add(2);
            studentsPerferences[0].Add(3);
            studentsPerferences[0].Add(4);


            studentsPerferences[1].Add(4);
            studentsPerferences[1].Add(3);
            studentsPerferences[1].Add(2);
            studentsPerferences[1].Add(1);

            studentsPerferences[2].Add(3);
            studentsPerferences[2].Add(4);
            studentsPerferences[2].Add(2);
            studentsPerferences[2].Add(1);

            studentsPerferences[3].Add(3);
            studentsPerferences[3].Add(4);
            studentsPerferences[3].Add(2);
            studentsPerferences[3].Add(1);

            studentsPerferences[4].Add(4);
            studentsPerferences[4].Add(1);
            studentsPerferences[4].Add(2);
            studentsPerferences[4].Add(3);

            studentsPerferences[5].Add(3);
            studentsPerferences[5].Add(4);
            studentsPerferences[5].Add(2);
            studentsPerferences[5].Add(1);

            studentsPerferences[6].Add(1);
            studentsPerferences[6].Add(2);
            studentsPerferences[6].Add(3);
            studentsPerferences[6].Add(4);

            studentsPerferences[7].Add(1);
            studentsPerferences[7].Add(2);
            studentsPerferences[7].Add(3);
            studentsPerferences[7].Add(4);

            studentsPerferences[8].Add(4);
            studentsPerferences[8].Add(3);
            studentsPerferences[8].Add(2);
            studentsPerferences[8].Add(1);

            studentsPerferences[9].Add(1);
            studentsPerferences[9].Add(4);
            studentsPerferences[9].Add(2);
            studentsPerferences[9].Add(3);

            for (int i = 0; i < studentsCount; i++)
            {
                studentsgrades.Add(i, new List<int>());
            }
            studentsgrades[0].Add(10);
            studentsgrades[0].Add(5);
            studentsgrades[0].Add(15);
            studentsgrades[0].Add(30);

            studentsgrades[1].Add(20);
            studentsgrades[1].Add(11);
            studentsgrades[1].Add(100);
            studentsgrades[1].Add(80);

            studentsgrades[2].Add(10);
            studentsgrades[2].Add(70);
            studentsgrades[2].Add(5);
            studentsgrades[2].Add(5);


            studentsgrades[3].Add(250);
            studentsgrades[3].Add(5);
            studentsgrades[3].Add(50);
            studentsgrades[3].Add(5);

            studentsgrades[4].Add(250);
            studentsgrades[4].Add(40);
            studentsgrades[4].Add(300);
            studentsgrades[4].Add(5);

            studentsgrades[5].Add(20);
            studentsgrades[5].Add(300);
            studentsgrades[5].Add(250);
            studentsgrades[5].Add(250);

            studentsgrades[6].Add(300);
            studentsgrades[6].Add(10);
            studentsgrades[6].Add(300);
            studentsgrades[6].Add(250);

            studentsgrades[7].Add(500);
            studentsgrades[7].Add(300);
            studentsgrades[7].Add(100);
            studentsgrades[7].Add(250);


            studentsgrades[8].Add(100);
            studentsgrades[8].Add(300);
            studentsgrades[8].Add(300);
            studentsgrades[8].Add(100);

            studentsgrades[9].Add(300);
            studentsgrades[9].Add(100);
            studentsgrades[9].Add(200);
            studentsgrades[9].Add(100);




        }
    }
}
