﻿using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace Browse
{
  public class IconExtractor
  {
    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern uint ExtractIconEx(string szFileName, int nIconIndex,
      IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

    [DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
    private static extern int DestroyIcon(IntPtr hIcon);

    /// <summary>
    ///   Extracts an icon resource from an executable
    /// </summary>
    /// <param name="file">The file to get the icon from</param>
    /// <param name="index">The index of the icon to retreive</param>
    /// <param name="large">If true returns a large icon, false returns a small one</param>
    /// <returns>The Icon requested or null</returns>
    public static Icon ExtractIconFromExe(string file, int index, bool large)
    {
      var hDummy = new[] {IntPtr.Zero};
      var hIconEx = new[] {IntPtr.Zero};

      try
      {
        uint readIconCount;
        if (large)
          readIconCount = ExtractIconEx(file, index, hIconEx, hDummy, 1);
        else
          readIconCount = ExtractIconEx(file, index, hDummy, hIconEx, 1);

        if (readIconCount > 0 && hIconEx[0] != IntPtr.Zero)
        {
          // GET FIRST EXTRACTED ICON
          var extractedIcon = (Icon) Icon.FromHandle(hIconEx[0]).Clone();

          return extractedIcon;
        }
        else // NO ICONS READ
          return null;
      }
      catch (Exception ex)
      {
        /* EXTRACT ICON ERROR */

        // BUBBLE UP
        throw new ApplicationException("Could not extract icon", ex);
      }
      finally
      {
        // RELEASE RESOURCES
        foreach (var ptr in hIconEx)
          if (ptr != IntPtr.Zero)
            DestroyIcon(ptr);

        foreach (var ptr in hDummy)
          if (ptr != IntPtr.Zero)
            DestroyIcon(ptr);
      }
    }

    /// <summary>
    ///   Extracts an icon resource from an executable
    /// </summary>
    /// <param name="file">The file to get the icon from (it can contain a comma and index as well)</param>
    /// <param name="large">If true returns a large icon, false returns a small one</param>
    /// <returns>The Icon requested or null</returns>
    public static Icon ExtractIconFromExe(string file, bool large)
    {
      var index = 0;
      var parts = file.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
      if (parts.Count() == 2)
      {
        file = parts[0];
        index = Int32.Parse(parts[1]);
      }
      return ExtractIconFromExe(file, index, large);
    }
  }
}
