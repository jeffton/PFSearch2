using System.Windows.Forms;

namespace PFSearch2.Interface
{
  public class ListViewEx : ListView
  {
    public ListViewEx()
    {
      // Reduces flicker
      SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    }
  }
}
