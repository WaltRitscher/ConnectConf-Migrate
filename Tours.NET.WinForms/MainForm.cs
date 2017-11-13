using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tours.NET.WinForms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();


    }

    private void MainForm_Load(object sender, EventArgs e)
    {


      dataGridViewTips.DataSource = Tours.NET.Biz.Tips.Current.GetTips();
      dataGridViewTestimonials.DataSource = Tours.NET.Biz.Testimonials.Current.GetTestimonials();
      listBox1.DataSource = Tours.NET.Biz.Tours.Current.GetTours();
      listBox1.DisplayMember = "TourName";

      //DataBindings.Add(propertyName: "Text", 
      //                 dataSource: listBox1.DataSource,
      //                 dataMember: "TourName");
      textBoxTourName.DataBindings.Add(propertyName: "Text",
                    dataSource: listBox1.DataSource,
                    dataMember: "TourName");
      textBoxRegion.DataBindings.Add(propertyName: "Text",
                    dataSource: listBox1.DataSource,
                    dataMember: "Region");
      textBoxDescription.DataBindings.Add(propertyName: "Text",
                   dataSource: listBox1.DataSource,
                   dataMember: "Description");

      numericUpDownMaxPeople.DataBindings.Add(propertyName: "Value",
                 dataSource: listBox1.DataSource,
                 dataMember: "MaxPeoplePerTour");

    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
  }
}
