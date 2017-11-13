using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.NET.DAL.ToursDataSetTableAdapters;
using static Tours.NET.DAL.ToursDataSet;

namespace Tours.NET.Biz
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
