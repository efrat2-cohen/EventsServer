using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProject
{
    public partial class SearchHallsForm : Form
    {
        public SearchHallsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BasePrice = 0;
            DateTime dateTime = new DateTime();
            DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO = new DTO.HallToTheHallOwnerDTO();
            if (textBox1.Text != "")
                dateTime = DateTime.Parse(textBox1.Text);
            if (textBox2.Text != "")
                hallToTheHallOwnerDTO.LocationHall = textBox2.Text;
            if (textBox3.Text != "")
                hallToTheHallOwnerDTO.MaximumNumberOfPlaces = int.Parse(textBox3.Text);
            if (textBox4.Text != "")
                hallToTheHallOwnerDTO.IsParking = bool.Parse(textBox4.Text);
            if (textBox6.Text != "")
                hallToTheHallOwnerDTO.HallName = textBox6.Text;
            if (textBox5.Text != "")
                hallToTheHallOwnerDTO.Kashrut = textBox5.Text;
            if (textBox7.Text != "")
                BasePrice = int.Parse(textBox7.Text);
            List<DTO.HallToTheHallOwnerDTO> listHalls = new List<DTO.HallToTheHallOwnerDTO>();
            listHalls = new BL.SearchHallBL().SearchHalls(hallToTheHallOwnerDTO, dateTime, BasePrice);
            dataGridView1.DataSource = listHalls;


        }
    }
}
