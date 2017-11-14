using System;
using System.Collections.Generic;
using System.Text;

namespace Tours.NET.DAL.Properties
{
  public partial class Settings
  {
    public class Default
    {
        public static string ToursConnectionString = @"Data Source=(localDB)\mssqllocaldb;AttachDbFilename=|DataDirectory|\Tours.mdf;Initial Catalog=Tours;Integrated Security=True";
    }
  }
}
