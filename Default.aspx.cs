using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterviewQuestion.Models;
namespace CHI_Test
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            House hr = new House();
            hr.AddTestData();
            GridView1.DataSource = hr.h;
            GridView1.DataBind();
        }

       
    }
    public class House  
    {
        public List<PetBase> h = new List<PetBase>();
        public void AddTestData()
        {
            h.Add(new Cat()
            {
                ID = h.Count + 1,
                Name = "Gracie",
                DateOfBirth = new DateTime(2016, 09, 28),
                Gender = Gender.Female
            });

            h.Add(new Cat()
            {
                ID =h.Count + 1,
                Name = "Patches",
                DateOfBirth = new DateTime(2015, 01, 09),
                Gender = Gender.Male
            });

            
        }


       
    }
}
