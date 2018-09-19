using Tours.DAL.ToursDataSetTableAdapters;
using static Tours.DAL.ToursDataSet;

namespace Tours.Biz
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
