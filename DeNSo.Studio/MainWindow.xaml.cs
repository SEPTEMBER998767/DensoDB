﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DeNSo.Studio.Meta;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Windows.Interop;
using DeNSo.Studio.UserControls;

namespace DeNSo.Studio
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      //this.EnableSystemDropShadow();

      this.leftColumn.RegisterRegion("leftArea");
      this.centerColumn.RegisterRegion("centerArea");

      new ConfiguredStoreList().ShowInRegion("leftArea");
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (e.LeftButton == MouseButtonState.Pressed)
        try
        {
          this.DragMove();
        }
        catch { }
    }


    private void btnExit_MouseDown(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void FullScreenToggle_MouseDown(object sender, RoutedEventArgs e)
    {
      if (this.WindowState == System.Windows.WindowState.Maximized)
        this.WindowState = System.Windows.WindowState.Normal;
      else
        this.WindowState = System.Windows.WindowState.Maximized;
    }

    private void Iconify_MouseDown(object sender, RoutedEventArgs e)
    {

      this.WindowState = System.Windows.WindowState.Minimized;
    }

    private void Thumb_DragDelta_1(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
    {
      this.Width += e.HorizontalChange;
      this.Height += e.VerticalChange;
    }

    private void btn_OpenNewDatabase(object sender, RoutedEventArgs e)
    {

    }

  }
}
