﻿using System;
using System.Collections.Generic;
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

namespace FP_PEMROGLANJUT.View
{
    /// <summary>
    /// Interaction logic for HiburanPage.xaml
    /// </summary>
    public partial class HiburanPage : Page
    {
        public HiburanPage()
        {
            InitializeComponent();
        }

        private void menuGame_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new GamePage());
        }
        private void menuStreaming_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new StreamingPage());
        }
        private void menuVoucher_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new VoucherPage());
        }
    }
}
