using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.NET.DAL.ToursDataSetTableAdapters;
using static Tours.NET.DAL.ToursDataSet;

namespace Tours.NET.Biz
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
