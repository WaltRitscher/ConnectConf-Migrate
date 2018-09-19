using Tours.DAL.ToursDataSetTableAdapters;

using static Tours.DAL.ToursDataSet;

namespace Tours.Biz
{
  public class Tips
  {

    private static Tips current;

    public static Tips Current => current ?? (current = new Tips());
    private TravelTipsTableAdapter tipsTableAdapter;

    protected TravelTipsTableAdapter ToursTableAdapter {
      get { return tipsTableAdapter ?? (tipsTableAdapter = new TravelTipsTableAdapter()); }
    }


    public TravelTipsDataTable GetTips()
    {
      return ToursTableAdapter.GetAllTravelTips();
    }
  }
}
