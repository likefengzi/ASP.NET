using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void MultiView1_Init(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View3);
        }

        protected void Calendar3_DayRender(object sender, DayRenderEventArgs e)
        {
            MDay(e);
            NDay(e);
            FDay(e);
        }
        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            MDay(e);
            NDay(e);
            FDay(e);
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            MDay(e);
            NDay(e);
            FDay(e);
        }
        public void MDay(DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 1 && e.Day.Date.Month == 5)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                Label label1 = new Label();
                label1.Text = "<br/>今天是劳动节";
                e.Cell.Controls.Add(label1);
            }
        }
        public void NDay(DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 1 && e.Day.Date.Month == 10)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                Label label1 = new Label();
                label1.Text = "<br/>今天是国庆节";
                e.Cell.Controls.Add(label1);
            }
        }
        public void FDay(DayRenderEventArgs e)
        {
            int day = GetChineseDay(e.Day.Date);
            int month = GetChinesMonth(e.Day.Date);
            //Response.Write(str);
            if (day == 1 && month == 1)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                Label label1 = new Label();
                label1.Text = "<br/>今天是春节";
                e.Cell.Controls.Add(label1);
            }
        }
        private static ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
        public int GetChineseDay(DateTime dateTime)
        {
            return calendar.GetDayOfMonth(dateTime) - 1;
        }

        public int GetChinesMonth(DateTime dateTime)
        {
            int month = calendar.GetMonth(dateTime);
            int year = calendar.GetYear(dateTime);
            int leap = 0;
            for (int i = 3; i <= month; i++)
            {
                if (calendar.IsLeapMonth(year, i))
                {
                    leap = i;
                    break;
                }
            }
            if (leap > 0) month--;
            return month - 1;
        }
    }
}