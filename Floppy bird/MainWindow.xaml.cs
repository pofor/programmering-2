using System;
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
    /// This method holds all the other methods of the class and adds variables to the program.
    /// that will be used all over the program. 
    /// The double Score variable is for the score so that you can see how many obstacles you have passed.
    /// The Gravity int is for the flappybird to go up and down so that it goes down like gravity is effecting the bird.
    /// The bool gameover is for the game to end and to restart the game.
    /// The Rect for flappybirdHiyBox is for the flappybird to die when something hits the hitbox of the bird.   
    /// /// </summary>
    public partial class MainWindow : Window
    {
        //adds a gametimer
        DispatcherTimer gameTimer = new DispatcherTimer();
        double score;
        int gravity = 8;
        bool gameOver;
        Rect flappyBirdHitBox;

        /// <summary>
        /// Starts the timer of the game and sets the time interval to 20 milliseconds
        /// It starts the game with these two added variables.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();

        }
           /// <summary>
           /// Writes out the score after passing a obstacle. 
           /// Sets the Flappybird hitbox so its the same as the model of the bird. 
           /// 
           /// </summary>
           /// <param name="sender">objekt sender</param>
           /// <param name="e">objekt checker</param>
        private void MainEventTimer(object sender, EventArgs e)
        {
            txtScore.Content = "score" + score;

            flappyBirdHitBox = new Rect(Canvas.GetLeft(flappyBird), Canvas.GetTop(flappyBird), flappyBird.Width, flappyBird.Height);

            Canvas.SetTop(flappyBird, Canvas.GetTop(flappyBird) + gravity);

            //Checks if flappybird is over or under the screen and if so ends the game
            if (Canvas.GetTop(flappyBird) < -10 || Canvas.GetTop(flappyBird) > 458)
            {
                EndGame();
            }
            //loops through the images and moves the images to the right when they pass out on the left. 
            foreach (var x in MyCanvas.Children.OfType<Image>())
            {

                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 800);

                        score += .5;
                    }
                    //gives the pipe a hitbox and makes it the same as the hight and width of the model.
                    Rect pipeHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    //if flappybird interacts with pipes it ends the game
                    if (flappyBirdHitBox.IntersectsWith(pipeHitBox))
                    {
                        EndGame();
                    }

                }
                //moves the cloud to the right like the pipe
                if ((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 1);

                    if (Canvas.GetLeft(x) < -250)
                    {
                        Canvas.SetLeft(x, 550);
                    }

                }
            }
        }
        /// <summary>
        /// This method makes the bird do a event when the key is pressed down. 
        /// </summary>
        /// <param name="sender">This is the object that is sent by the player to the program</param>
        /// <param name="e">This is the event that happends in this case a pressdown key</param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //This checks if the space key is pressed and if so rotates the flappybird 
            if (e.Key == Key.Space)
            {
                flappyBird.RenderTransform = new RotateTransform(-20, flappyBird.Width /2, flappyBird.Height / 2);
                gravity = -8;
            }
            //Checks if r key is pressed while gameover is true and if so starts the game again
            if (e.Key == Key.R && gameOver == true)
            {
                StartGame();
            }
        }
        /// <summary>
        /// This method checks if the key is realesed and rotates the flappybrid to look down and go downwards like the gravity. 
        /// </summary>
        /// <param name="sender">sends the objekt to the method above when the key is realesed</param>
        /// <param name="e">event key</param>
        private void KeyIsUP(object sender, KeyEventArgs e)
        {
            flappyBird.RenderTransform = new RotateTransform(5, flappyBird.Width / 2, flappyBird.Height / 2);
            gravity = 8;
        }
        /// <summary>
        /// This method starts the game and makes the canvas the focus of the program so it runs faster.
        /// It also resets the game after a game over.
        /// It also contains a for each loop that loops through all the images and then it specifice what we want to move and where to move it through tags. 
        /// Starts the gametimer.
        /// </summary>
        private void StartGame()
        {
            MyCanvas.Focus();

            int temp = 300;

            score = 0;

            gameOver = false;
            Canvas.SetTop(flappyBird, 190);
            //Loops through if statements that contain iamges and checks the obstacale and clouds and moves them to their starter position.
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
        /// <summary>
        /// This method stops the game and the timer and asks the player if the player wants to play again. 
        /// Sends a message about if you want to try again. 
        /// </summary>
        private void EndGame()
        {
            gameTimer.Stop();
            gameOver = true;
            txtScore.Content += " Game Over !! press R to try again";
        }
    }
}
