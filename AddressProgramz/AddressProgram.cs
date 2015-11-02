/*
Created by Matthew Ho
Created on 11-02-15
Created for ICS3U
Assignment #4-03
This program shows the address details of a person.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressProgramz
{
    public partial class frmAddressProgram : Form
    {
        public void AddressListing(string apartmentNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(apartmentNumber + "\n" + streetAddress + "\n" + city + "\n" + province + "\n" + postalCode, "Address");
        }

        public void AddressListing(string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(streetAddress + "\n" + city + "\n" + province + "\n" + postalCode, "2Address");
        }

        public frmAddressProgram()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string aptNumber;
            string streetAddress;
            string city;
            string province;
            string postalCode;

            aptNumber = this.txtAptNumber.Text;
            streetAddress = this.txtStreetAddress.Text;
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

            if (aptNumber == "")
            {
                AddressListing(streetAddress, city, province, postalCode);
            }
            else {
                AddressListing(aptNumber, streetAddress, city, province, postalCode);
            }

        }
    }
}
