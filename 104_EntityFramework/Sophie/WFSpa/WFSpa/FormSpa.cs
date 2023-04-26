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
using WFSpa.Data;

namespace WFSpa
{
    public partial class FormSpa : Form
    {
        SpaContext context;
        public FormSpa()
        {
            InitializeComponent();
            context = new SpaContext();
            context.Chats.Load();
            InitializeForm();

        }

        public void InitializeForm()
        {

        }
    }
}
