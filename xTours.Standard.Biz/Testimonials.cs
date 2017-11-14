using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.NET.DAL.ToursDataSetTableAdapters;
using static Tours.NET.DAL.ToursDataSet;

namespace Tours.NET.Biz
{
  public class Testimonials
  {

    private static Testimonials current;

    public static Testimonials Current => current ?? (current = new Testimonials());
    private TestimonialsTableAdapter testimonialTableAdapter;

    protected TestimonialsTableAdapter ToursTableAdapter {
      get { return testimonialTableAdapter ?? (testimonialTableAdapter = new TestimonialsTableAdapter()); }
    }


    public TestimonialsDataTable GetTestimonials()
    {
      return ToursTableAdapter.GetAllTestimonials();
    }
  }
}
