﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cookbook
{
    /// <summary>
    /// Interaction logic for ProfileInfoPage.xaml
    /// </summary>
    public partial class ProfileMainPage : Page
    {
        public BitmapImage infoButtonImage = new BitmapImage(new Uri("pack://application:,,,/Images/InfoButton.png"));
        public BitmapImage infoButtonDarkImage = new BitmapImage(new Uri("pack://application:,,,/Images/InfoButtonDark.png"));

        public BitmapImage preferencesButtonImage = new BitmapImage(new Uri("pack://application:,,,/Images/PreferencesButton.png"));
        public BitmapImage preferencesButtonDarkImage = new BitmapImage(new Uri("pack://application:,,,/Images/PreferencesButtonDark.png"));

        private ProfileInfoPage profileInfoPage = new ProfileInfoPage();
        private ProfilePreferencesPage profilePreferencesPage = new ProfilePreferencesPage();

        public ProfileMainPage()
        {
            InitializeComponent();
        }

        private void ProfileInfoButton_Click(object sender, RoutedEventArgs e)
        {
            //Selected
            InfoButtonImageBrush.ImageSource = infoButtonDarkImage;
            //Unselected
            PreferencesButtonImageBrush.ImageSource = preferencesButtonImage;

            //Switch content
            profileMain.Content = profileInfoPage;
        }

        private void ProfilePreferencesButton_Click(object sender, RoutedEventArgs e)
        {
            //Selected
            PreferencesButtonImageBrush.ImageSource = preferencesButtonDarkImage;
            //Unselected
            InfoButtonImageBrush.ImageSource = infoButtonImage;

            //Switch content
            profileMain.Content = profilePreferencesPage;
        }
    }
}
