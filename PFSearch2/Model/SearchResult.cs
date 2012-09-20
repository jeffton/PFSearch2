using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PFSearch2.Model
{
  public class SearchResult
  {
    public SearchResult(string fullPath)
    {
      this.FileName = Path.GetFileName(fullPath);
      this.DirectoryPath = Path.GetDirectoryName(fullPath);
      this.FullPath = fullPath;
    }

    public string DirectoryPath { get; private set; }
    public string FileName { get; private set; }
    public string FullPath { get; private set; }

    public override string ToString()
    {
      return FullPath;
    }
  }
}
