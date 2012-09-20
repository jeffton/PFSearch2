using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PFSearch2.Model;
using PFSearch2.Tools;

namespace PFSearch2.Interface
{
  public partial class MainForm : Form
  {
    private SearchArguments arguments;

    public MainForm()
    {
      Initialize();
      HookThingsUp();
    }

    private void HookThingsUp()
    {
      argumentsBindingSource.DataSource = arguments =
        new SearchArguments("C:\\", "*", string.Empty);
      SearchWorker.SearchProgressed += new SearchWorker.SearchProgressHandler(SearchWorker_SearchProgressed);
      SearchWorker.ResultFound += new SearchWorker.ResultFoundHandler(SearchWorker_ResultFound);
      SearchWorker.StateChanged += new SearchWorker.StateChangedHandler(SearchWorker_StateChanged);
      SearchWorker.SearchError += new SearchWorker.SearchErrorHandler(SearchWorker_SearchError);
    }

    void SearchWorker_SearchError(Exception ex)
    {
      Invoke((MethodInvoker)delegate()
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
      });
    }

    private void Initialize()
    {
      this.Font = SystemFonts.MessageBoxFont;
      InitializeComponent();

      searchButton.Font = new Font(searchButton.Font, FontStyle.Bold);
      openFilelocationToolStripMenuItem.Font = new Font(openFilelocationToolStripMenuItem.Font, FontStyle.Bold);
    }

    void SearchWorker_StateChanged(SearchWorker.SearchState newState, SearchWorker.Transition transition)
    {
      string status = string.Empty;

      switch (transition)
      {
        case SearchWorker.Transition.Cancelled:
          status = "Search stopped";
          break;
        case SearchWorker.Transition.Complete:
          status = "Search complete";
          break;
        case SearchWorker.Transition.Started:
          status = "Searching...";
          break;
        case SearchWorker.Transition.StopRequested:
          status = "Stopping search...";
          break;
      }

      Invoke((MethodInvoker)delegate()
      {
        directoryBox.Enabled = filenameBox.Enabled = contentBox.Enabled = searchButton.Enabled =
          (newState == SearchWorker.SearchState.Ready);
        cancelButton.Enabled = (newState == SearchWorker.SearchState.Running);
        statusLabel.Text = status;

        if (transition == SearchWorker.Transition.Started)
        {
          resultView.Items.Clear();
        }
      });
    }

    void SearchWorker_ResultFound(SearchResult result)
    {
      Invoke((MethodInvoker)delegate()
      {
        resultView.BeginUpdate();
        resultView.Items.Add(new ListViewItem() { Text = result.FullPath, Tag = result });
        resultView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        int width = resultView.Width - SystemInformation.VerticalScrollBarWidth - resultView.Margin.Left
          - resultView.Margin.Right;
        if (fileColumn.Width < width)
          fileColumn.Width = width;
        resultView.EndUpdate();
      });
    }

    void SearchWorker_SearchProgressed(string message)
    {
      Invoke((MethodInvoker)delegate()
      {
        statusLabel.Text = message;
      });
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      SearchWorker.StartSearch(arguments);
    }

    private void argumentBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        SearchWorker.StartSearch(arguments);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      SearchWorker.StopSearch();
    }

    private void openFilelocationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileLocation();
    }

    private void resultView_ItemActivate(object sender, EventArgs e)
    {
      if (SelectedResult != null)
        OpenFileLocation();
    }

    private void OpenFileLocation()
    {
      ShellTools.ShowInExplorer(SelectedResult.FullPath);
    }

    private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShellTools.OpenFile(SelectedResult.FullPath);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShellTools.Copy(SelectedResults.Select(result => result.FullPath));
    }

    private void resultView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      ToggleContextMenuItems();
    }

    private List<SearchResult> SelectedResults
    {
      get
      {
        return resultView.SelectedItems
          .Cast<ListViewItem>()
          .Select(item => item.Tag)
          .Cast<SearchResult>().ToList();
      }
    }

    private SearchResult SelectedResult
    {
      get
      {
        return SelectedResults.FirstOrDefault();
      }
    }


    private void ToggleContextMenuItems()
    {
      var selected = SelectedResults;
      
      bool singleSelection = (selected.Count == 1);
      openFilelocationToolStripMenuItem.Available = singleSelection;
      openfileToolStripMenuItem.Available = singleSelection;
      
      bool anySelection = (selected.Count > 0);
      resultContextMenu.Enabled = anySelection;
      copyToolStripMenuItem.Available = anySelection;
    }

    private void resultView_ItemDrag(object sender, ItemDragEventArgs e)
    {
      var dataObject = ShellTools.GetDataObject(SelectedResults.Select(result => result.FullPath), includeAsText: false);
      resultView.DoDragDrop(dataObject, DragDropEffects.Copy);
    }
  }
}
