using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PFSearch2.Tools
{
  public class ShellTools
  {
    public static void OpenFile(string filePath)
    {
      Process.Start(filePath);
    }

    public static void ShowInExplorer(string filePath)
    {
      Process.Start("explorer.exe", string.Format("/select, \"{0}\"", filePath));
    }

    public static void Copy(IEnumerable<string> paths)
    {
      var dataObject = GetDataObject(paths);
      Clipboard.SetDataObject(dataObject, true);
    }

    public static DataObject GetDataObject(IEnumerable<string> paths, bool includeAsText = true)
    {
      var dataObject = new DataObject();
      var pathCollection = new StringCollection();
      pathCollection.AddRange(paths.ToArray());
      dataObject.SetFileDropList(pathCollection);
      if (includeAsText)
        dataObject.SetText(string.Join(Environment.NewLine, paths));
      return dataObject;
    }

  }
}
