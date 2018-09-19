using Tours.DAL.ToursDataSetTableAdapters;
using static Tours.DAL.ToursDataSet;

namespace Tours.Biz
{
  public class Tours
  {

    private static Tours current;

    public static Tours Current => current ?? (current = new Tours());
    private ToursTableAdapter toursTableAdapter;

    protected ToursTableAdapter ToursTableAdapter {
      get { return toursTableAdapter ?? (toursTableAdapter = new ToursTableAdapter()); }
    }


    public ToursDataTable GetTours()
    {
      return ToursTableAdapter.GetAllTours();
    }
  }
}
