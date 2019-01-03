using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Model;
using System.Windows.Forms;

namespace _3.Controller
{
    public class clsController
    {
        private clsBank myBank;
        public clsDataSource DataSource = new clsDataSource(); 

        public clsController(clsBank vmyBank)
        {
            myBank = new clsBank();
        }

       public  clsController()
        {
            myBank = null;
        }

        public clsBank vmyBank
        {
            get
            {
                return myBank;
            }

            set
            {
                myBank = value;
            }
        }

        public clsListAgencies gatAgencies()
        {
            try
            {
                myBank.vListAgencies = DataSource.fncGetAgencies();
                return myBank.vListAgencies;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Err _3.Controller.clsController.gatAgencies() : " + ex.Message);
                return null;
            }
            
        }
    }
}
