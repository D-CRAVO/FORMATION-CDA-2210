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
using WFCities.Data;

namespace WFCities
{
    public partial class FormCities : Form
    {
        Db301CitiesContext dbContext;
        public FormCities()
        {
            InitializeComponent();
            dbContext = new Db301CitiesContext();
            dbContext.Countries.Load();
            comboBoxCountryCode.DataSource = dbContext.Countries.Local.ToBindingList();
            comboBoxCountryCode.ValueMember = "CountryCode";
        }
    }
}
