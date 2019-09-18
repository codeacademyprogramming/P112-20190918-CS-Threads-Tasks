using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VasifProject.DAL;
using VasifProject.Model;

namespace VasifProject
{
    public partial class Form1 : Form
    {
        private readonly CarDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new CarDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Demo();

        }

        public void Demo() {
            //Car mashin = new Car();
            //mashin.Name = "Volkswagen Passat";
            //mashin.Price = 50.99F;
            //mashin.State = false;
            //db.Cars.Add(mashin);
            //db.SaveChanges();

            Order sifarish = new Order();
            sifarish.StartDate = new DateTime(2019,03,02);
            sifarish.EndDate = new DateTime(2019,04,10);
            sifarish.CarId = 1;
            db.Orders.Add(sifarish);
            db.SaveChanges();
        }
    }
}
