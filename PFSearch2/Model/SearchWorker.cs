using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace PFSearch2.Model
{
  public enum WildCardType { Simple, Regex };

  public static class SearchWorker
  {
    private static Thread lastSearchThread;

    public delegate void ResultFoundHandler(SearchResult result);
    public static event ResultFoundHandler ResultFound;

    public enum SearchState { Ready, Running, Stopping };
    public enum Transition { Started, Complete, Cancelled, StopRequested };
    private static SearchState state = SearchState.Ready;

    public delegate void StateChangedHandler(SearchState newState, Transition transition);
    public static event StateChangedHandler StateChanged;
    public delegate void SearchErrorHandler(Exception ex);
    public static event SearchErrorHandler SearchError;

    public delegate void SearchProgressHandler(string message);
    public static event SearchProgressHandler SearchProgressed;

    private static object searchLockObject = new object();

    public static void StartSearch(SearchArguments arguments)
    {
      lock (searchLockObject)
      {
        if (state != SearchState.Ready)
          return;

        state = SearchState.Running;
        if (StateChanged != null)
          StateChanged(state, Transition.Started);
      }

      lastSearchThread = new Thread(delegate()
      {
        Search(arguments);
        SearchState stoppingState = state;
        state = SearchState.Ready;
        if (StateChanged != null)
          StateChanged(state, stoppingState == SearchState.Stopping ? Transition.Cancelled : Transition.Complete);
      });
      lastSearchThread.IsBackground = true;
      lastSearchThread.Start();
    }

    public static void StopSearch()
    {
      state = SearchState.Stopping;
      StateChanged(state, Transition.StopRequested);
    }

    public static SearchState State
    {
      get
      {
        return state;
      }
      private set
      {
        state = value;
      }
    }

    private static void Search(SearchArguments arguments)
    {
      try
      {
        Search(new DirectoryInfo(arguments.Folder), arguments);
      }
      catch (Exception ex)
      {
        state = SearchState.Stopping;
        if (SearchError != null)
          SearchError(ex);
      }
    }

    private static void Search(DirectoryInfo dir, SearchArguments arguments)
    {
      if (state != SearchState.Running)
        return;

      if (SearchProgressed != null)
        SearchProgressed(dir.FullName);

      try
      {
        FileInfo[] files = dir.GetFiles(arguments.NameSearch);

        foreach (FileInfo file in files)
        {
          if (state != SearchState.Running)
            return;

          if (string.IsNullOrEmpty(arguments.ContentSearch))
          {
            if (ResultFound != null)
              ResultFound(new SearchResult(file.FullName));

            continue;
          }
          else
          {
            try
            {
              string contentSearch = arguments.ContentSearch.ToLower();
              using (StreamReader sire = new StreamReader(file.FullName))
              {
                for (string line = sire.ReadLine();
                     line != null;
                     line = sire.ReadLine())
                {
                  if (state != SearchState.Running)
                    return;

                  if (line.ToLower().Contains(contentSearch))
                  {
                    if (ResultFound != null)
                      ResultFound(new SearchResult(file.FullName));

                    break;
                  }
                }
              }
            }
            catch (IOException) { }
          }
        }

        DirectoryInfo[] subDirs = dir.GetDirectories();
        foreach (DirectoryInfo subDir in subDirs)
        {
          Search(subDir, arguments);
        }
      }
      catch (UnauthorizedAccessException)
      {
        return;
      }
    }
  }
}