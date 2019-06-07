using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Races
{
    // helper for manipulating objects from different threads
    public delegate void HelperToCall(Button btn);

    public partial class MainForm : Form
    {
        #region Fields
        Thread t1; // thread for the first car motion
        Thread t2; // thread for the second car motion 
        Thread t3; // thread for the third car motion
        Thread t4; // thread for the fourth car motion
        Thread t5; // thread for the fifth car motion

        HelperToCall helper;

        static Random rand;

        ButtonCompare[] button;

        SoundPlayer running, background;
        #endregion

        #region Constructor
        public MainForm()
        {
            running = new SoundPlayer(Properties.Resources.Track_06);
            background = new SoundPlayer(Properties.Resources._37_Applause_Cheering_Indoor_Hockey_Arena_Medium_Crowd);

            background.Play();

            Thread.Sleep(500);

            InitializeComponent();

            button = new ButtonCompare[] { first_car_btn, second_car_btn, third_car_btn, fourth_car_btn, fifth_car_btn };

            helper = new HelperToCall(Motion);

            rand = new Random();


        }
        #endregion

        #region start_btn_Click
        /// <summary>
        /// Method is called when you click the "Start" button and starts the threads,
        /// if they have not been created. Renewable streams if they were suspended.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_btn_Click(object sender, EventArgs e)
        {
            running.Play();

            Switcher(false, true, true);

            if (t1 != null)
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
                t5.Resume();
                return;
            }

            t1 = new Thread(Movement1);
            t2 = new Thread(Movement2);
            t3 = new Thread(Movement3);
            t4 = new Thread(Movement4);
            t5 = new Thread(Movement5);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = t5.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
        #endregion

        #region pause_btn_Click
        /// <summary>
        ///  Suspend threads in the case of pressing the "Pause" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_btn_Click(object sender, EventArgs e)
        {
            background.Play();

            Switcher(true, false, true);

            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
                t4.Suspend();
                t5.Suspend();
            }
        }
        #endregion

        #region stop_btn_Click
        /// <summary>
        /// In the case of pressing the "Stop" button, suspend threads and resets the car
        /// coordinates in the starting position. Deletes the word "Leader". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_btn_Click(object sender, EventArgs e)
        {
            background.Play();

            pause_btn_Click(new object(), new EventArgs());

            Reset();

            Switcher(true, false, false);
        }
        #endregion

        #region Motion
        /// <summary>
        /// Moves a specific button, received as a parameter
        /// </summary>
        /// <param name="button"></param>
        void Motion(Button button)
        {
            if (stop_btn.Enabled)
            {
                button.Location = new Point(button.Location.X + rand.Next(3), button.Location.Y);
                Lider();

                Finish(button);
            }
        }
        #endregion

        #region Movement1
        /// <summary>
        /// Responsible for the movement of the first car
        /// </summary>
        void Movement1()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(5, 40));
                Invoke(helper, first_car_btn);
            }
        }
        #endregion

        #region Movement2
        /// <summary>
        /// Responsible for the movement of the second car
        /// </summary>
        void Movement2()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(5, 40));
                Invoke(helper, second_car_btn);
            }
        }
        #endregion

        #region Movement3
        /// <summary>
        /// Responsible for the movement of the third car
        /// </summary>
        void Movement3()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(5, 40));
                Invoke(helper, third_car_btn);
            }
        }
        #endregion

        #region Movement4
        /// <summary>
        /// Responsible for the movement of the fourth car
        /// </summary>
        void Movement4()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(5, 40));
                Invoke(helper, fourth_car_btn);
            }
        }
        #endregion

        #region Movement5
        /// <summary>
        /// Responsible for the movement of the fifth car
        /// </summary>
        void Movement5()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(5, 40));
                Invoke(helper, fifth_car_btn);
            }
        }
        #endregion

        #region Finish
        /// <summary>
        /// Determines the winner and stops the movement of the cars in case of victory of one of them
        /// </summary>
        /// <param name="button"></param>
        private void Finish(Button button)
        {
            if (button.Location.X > (pictureBox1.Location.X - button.Width))
            {
                pause_btn_Click(new object(), new EventArgs());
                start_btn.Enabled = false;

                background.Play();

                MessageBox.Show(button.Name + " победила!");
            }

        }
        #endregion

        #region Lider
        /// <summary>
        ///  Displays the word "Leader" on the leading at the moment car
        /// </summary>
        private void Lider()
        {
            Array.Sort(button);
            button[0].Text = "L E A D E R !";

            for (int i = 1; i < button.Length; i++)
                button[i].Text = null;
        }
        #endregion

        #region Reset
        /// <summary>
        /// Resets the car coordinates in the starting position. Deletes the word "Leader"
        /// </summary>
        private void Reset()
        {
            foreach (ButtonCompare btn in button)
                btn.Text = null;

            first_car_btn.Location = new Point(12, first_car_btn.Location.Y);
            second_car_btn.Location = new Point(12, second_car_btn.Location.Y);
            third_car_btn.Location = new Point(12, third_car_btn.Location.Y);
            fourth_car_btn.Location = new Point(12, fourth_car_btn.Location.Y);
            fifth_car_btn.Location = new Point(12, fifth_car_btn.Location.Y);

        }
        #endregion

        #region MainForm_FormClosing
        /// <summary>
        /// Normal exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_btn_Click(sender, new EventArgs());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Switcher
        /// <summary>
        /// Controls the availability of buttons
        /// </summary>
        /// <param name="flagStart"></param>
        /// <param name="flagPause"></param>
        /// <param name="flagStop"></param>
        void Switcher(bool flagStart, bool flagPause, bool flagStop)
        {
            start_btn.Enabled = flagStart;
            pause_btn.Enabled = flagPause;
            stop_btn.Enabled = flagStop;
        }
        #endregion

    }
}
