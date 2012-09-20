using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFSearch2.Model
{
  public class SearchArguments
  {
    public SearchArguments(string folder, string nameSearch, string contentSearch)
    {
      Folder = folder;

      if (string.IsNullOrEmpty(nameSearch))
        nameSearch = "*";
      NameSearch = nameSearch;

      ContentSearch = contentSearch;
    }

    public string Folder { get; set; }
    public string NameSearch { get; set; }
    public string ContentSearch { get; set; }
  }
}
