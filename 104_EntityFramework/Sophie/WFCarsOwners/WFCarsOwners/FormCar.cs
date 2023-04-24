using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCarsOwners.Data;
using WFCarsOwners.Models;

namespace WFCarsOwners
{
    public partial class FormCar : Form
    {
        private Db303CarsownersContext dbContext;
        public FormCar()
        {
            InitializeComponent();
            dbContext = new Db303CarsownersContext();
            dbContext.Cars.Load<Car>();

            dataGridViewCar.DataSource = dbContext.Cars.Local.ToBindingList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.CarId = 29;
            car.CarName = "80";
            car.BrandId = 2; //Audi
            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxCarId.Text, out id);
            if (idOk)
            {
                Car? carToDelete = dbContext.Cars.Find(id);
                if (carToDelete != null)
                {
                    dbContext.Cars.Remove(carToDelete);
                    dbContext.SaveChanges();
                }
            }
        }

        private void buttonModifyCar_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxCarId.Text, out id);
            if (idOk)
            {
                Car? carToModify = dbContext.Cars.Find(id);
                if (carToModify != null)
                {
                    carToModify.CarName = textBoxNewName.Text;
                    dbContext.Cars.Update(carToModify);
                    dbContext.SaveChanges();
                    dataGridViewCar.Refresh();
                }
            }
        }
    }
}
