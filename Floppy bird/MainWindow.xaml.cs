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
using System.Windows.Threading;

namespace Floppy_bird
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();
        double score;
        int gravity = 8;
        bool gameOver;
        Rect flappyBirdHitBox;


        public MainWindow()
        {
            InitializeComponent();
            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();

        }

        private void MainEventTimer(object sender, EventArgs e)
        {
       
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                flappyBird.RenderTransform = new RotateTransform(-20, flappyBird.Width /2, flappyBird.Height / 2);
                gravity = -8;
            }
            if (e.Key == Key.R && gameOver == true)
            {
                StartGame();
            }
        }

        private void KeyIsUP(object sender, KeyEventArgs e)
        {
            flappyBird.RenderTransform = new RotateTransform(5, flappyBird.Width / 2, flappyBird.Height / 2);
            gravity = 8;
        }

        private void StartGame()
        {
            MyCanvas.Focus();

            int temp = 300;

            score = 0;

            gameOver = false;
            Canvas.SetTop(flappyBird, 190);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }
                if ((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, 300 + temp);
                    temp = 800;
                }

            }

            gameTimer.Start();


        }

        private void EndGame()
        {

        }
    }
}
