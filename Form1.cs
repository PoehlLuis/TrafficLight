using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ampelsteuerung
{
    public partial class Form1 : Form
    {
        #region variables
        int seconds;
        int sumSeconds;
        int secondsGreen;
        int secondsOrange;
        int secondsRed;
        int privateTimer;

        bool startGreen;
        bool startRed;

        Status currentstatus = new Status();


        bool standbyBlink = false;
        bool pedBlink;

        Rectangle rec = new Rectangle(0, 0, 100, 100);

        Brush offRed = new SolidBrush(Color.FromArgb(60, 0, 0));
        Brush offOrange = new SolidBrush(Color.FromArgb(51, 25, 0));
        Brush offGreen = new SolidBrush(Color.FromArgb(0, 51, 0));
        Brush onRed = new SolidBrush(Color.FromArgb(255, 0, 0));
        Brush onOrange = new SolidBrush(Color.FromArgb(255, 128, 0));
        Brush onGreen = new SolidBrush(Color.FromArgb(0, 255, 0));

        Graphics a;
        Graphics b;
        Graphics c;
        Graphics d;
        Graphics f;
        
        #endregion

        #region initializiation
        public Form1()
        {
            InitializeComponent();

            txbGreen.Text = "10";
            txbOrange.Text = "5";
            txbRed.Text = "10";

            a = panelRed.CreateGraphics();
            b = panelOrange.CreateGraphics();
            c = panelGreen.CreateGraphics();
            d = panelRedPed.CreateGraphics();
            f = panelGreenPed.CreateGraphics();

            a.DrawEllipse(new Pen(Color.Black), rec);
            b.DrawEllipse(new Pen(Color.Black), rec);
            c.DrawEllipse(new Pen(Color.Black), rec);
            d.DrawEllipse(new Pen(Color.Black), rec);
            f.DrawEllipse(new Pen(Color.Black), rec);

            #region comboBox initialization
            cbStatus.Items.Add("Standby");
            cbStatus.Items.Add("Working mode");
            cbStatus.SelectedItem = cbStatus.Items[0];
            #endregion

            rbGreen.Checked = true;
            timerSeconds.Start();
        }
        #endregion

        #region Inputs

        #region textbox
        private void txbGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txbGreen.Text == string.Empty)
                {
                    txbGreen.Text = "10";

                }
                if (!Int32.TryParse(txbGreen.Text, out secondsGreen))
                {
                    throw new Exception("Input is not valid");
                }
                if (secondsGreen > 50)
                {

                    throw new Exception("Number is to large");
                }
                else if (secondsGreen < 10)
                {
                    throw new Exception("Number is to small");
                }



                tbGreen.Value = secondsGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txbOrange_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txbOrange.Text == string.Empty)
                {
                    txbOrange.Text = "5";

                }
                if (!Int32.TryParse(txbOrange.Text, out secondsOrange))
                {
                    throw new Exception("Input is not valid");
                }
                if (secondsOrange > 50)
                {

                    throw new Exception("Number is to large");
                }
                else if(secondsOrange < 5)
                {
                    throw new Exception("Number is to small");
                }



                tbOrange.Value = secondsOrange;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbRed_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txbRed.Text == string.Empty)
                {
                    txbRed.Text = "10";

                }
                if (!Int32.TryParse(txbRed.Text, out secondsRed))
                {
                    throw new Exception("Input is not valid");
                }
                if (secondsRed > 50)
                {

                    throw new Exception("Number is to large");
                }
                else if (secondsRed < 10)
                {
                    throw new Exception("Number is to small");
                }



                tbRed.Value = secondsRed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region slider
        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            txbGreen.Text = tbGreen.Value.ToString();
        }

        private void tbOrange_Scroll(object sender, EventArgs e)
        {
            txbOrange.Text = tbOrange.Value.ToString();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            txbRed.Text = tbRed.Value.ToString();
        }

        #endregion

        #region controlbox
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem.ToString() == "Standby")
            {
                currentstatus = Status.standby;
                startGreen = false;
                startRed = false;
            }
            else
            {
                currentstatus = Status.workingmode;
            }
        }
        #endregion

        #endregion

        #region Buttons
        private void btnStop_Click(object sender, EventArgs e)
        {
            currentstatus = Status.workingmode;
            cbStatus.SelectedItem = cbStatus.Items[0];
            startRed = false;
            startGreen = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                sumSeconds = secondsGreen + secondsOrange + secondsRed;
                if (cbStatus.SelectedItem.ToString() == "Working mode")
                {
                    if (rbGreen.Checked)
                    {
                        startGreen = true;
                        startRed = false;
                        currentstatus = Status.green;
                        seconds = 1;
                    }
                    else
                    {
                        startRed = true;
                        startGreen = false;
                        currentstatus = Status.red;
                        seconds = 1;
                    }
                }
                else
                {
                    throw new Exception("The system can only start in working mode");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Timer
        private void timerSeconds_Tick(object sender, EventArgs e)
        {

            if (startGreen)
            {
                if (seconds <= secondsGreen)
                {
                    currentstatus = Status.green;
                }
                else if (seconds > secondsGreen && seconds <= secondsGreen + secondsOrange)
                {
                    currentstatus = Status.orange;
                }
                else if(seconds <= sumSeconds-5)
                {
                    currentstatus = Status.red;
                    pedBlink = false;
                }
                else
                {
                    currentstatus = Status.blink;
                }
            }
            else if (startRed)
            {
                if (seconds <= secondsRed-5)
                {
                    currentstatus = Status.red;
                    pedBlink = false;
                }
                else if(seconds <= secondsRed)
                {
                    currentstatus = Status.blink;
                }
                else if (seconds > secondsRed && seconds < secondsGreen + secondsRed+1)
                {
                    currentstatus = Status.green;
                }
                else
                {
                    currentstatus = Status.orange;
                }
            }

            switch (currentstatus)
            {
                case Status.standby:
                    if (standbyBlink)
                    {
                        a.FillEllipse(offRed, rec);
                        b.FillEllipse(onOrange, rec);
                        c.FillEllipse(offGreen, rec);
                        d.FillEllipse(offRed, rec);
                        f.FillEllipse(offGreen, rec);
                        standbyBlink = false;
                    }
                    else
                    {
                        a.FillEllipse(offRed, rec);
                        b.FillEllipse(offOrange, rec);
                        c.FillEllipse(offGreen, rec);
                        d.FillEllipse(offRed, rec);
                        f.FillEllipse(offGreen, rec);
                        standbyBlink = true;
                    }
                    break;
                case Status.workingmode:
                    a.FillEllipse(offRed, rec);
                    b.FillEllipse(offOrange, rec);
                    c.FillEllipse(offGreen, rec);
                    d.FillEllipse(offRed, rec);
                    f.FillEllipse(offGreen, rec);
                    break;
                case Status.green:
                    a.FillEllipse(offRed, rec);
                    b.FillEllipse(offOrange, rec);
                    c.FillEllipse(onGreen, rec);
                    d.FillEllipse(onRed, rec);
                    f.FillEllipse(offGreen, rec);
                    break;
                case Status.orange:
                    a.FillEllipse(offRed, rec);
                    b.FillEllipse(onOrange, rec);
                    c.FillEllipse(offGreen, rec);
                    d.FillEllipse(onRed, rec);
                    f.FillEllipse(offGreen, rec);
                    break;
                case Status.red:
                    a.FillEllipse(onRed, rec);
                    b.FillEllipse(offOrange, rec);
                    c.FillEllipse(offGreen, rec);
                    d.FillEllipse(offRed, rec);
                    f.FillEllipse(onGreen, rec);
                    break;
                case Status.blink:
                    if (pedBlink)
                    {
                        a.FillEllipse(onRed, rec);
                        b.FillEllipse(offOrange, rec);
                        c.FillEllipse(offGreen, rec);
                        d.FillEllipse(offRed, rec);
                        f.FillEllipse(onGreen, rec);
                        pedBlink = false;
                    }
                    else
                    {
                        a.FillEllipse(onRed, rec);
                        b.FillEllipse(offOrange, rec);
                        c.FillEllipse(offGreen, rec);
                        d.FillEllipse(offRed, rec);
                        f.FillEllipse(offGreen, rec);
                        pedBlink = true;
                    }
                    break;
                default:
                    break;
            }
            if (seconds++ < sumSeconds && currentstatus != Status.standby)
            {
                
            }
            else
            {
                seconds = 1;
            }
            
        }

        #endregion

        private void btnPed_Click(object sender, EventArgs e)
        {
            try
            {
                privateTimer = seconds;
                int startsecond = seconds;
                if (currentstatus == Status.green && startGreen)
                {
                    while (privateTimer != startsecond + 5)
                    {
                        Thread.Sleep(1000);
                        privateTimer++;
                    }


                    while (privateTimer <= 1 + 10)
                    {
                        Thread.Sleep(1000);
                        privateTimer++;
                    }
                    currentstatus = Status.orange;
                    seconds += secondsGreen - seconds;
                }
                else if (currentstatus == Status.green && startRed)
                {
                    while (privateTimer != startsecond + 5)
                    {
                        Thread.Sleep(1000);
                        privateTimer++;
                    }


                    while (privateTimer <= 1 + 10 + secondsRed)
                    {
                        Thread.Sleep(1000);
                        privateTimer++;
                    }
                    currentstatus = Status.orange;
                    seconds += secondsGreen + secondsRed - seconds;
                }
                else
                {
                    throw new Exception("The button can only do something when the traffic light is red");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerPrivate_Tick(object sender, EventArgs e)
        {
            privateTimer++;
        }
    }
}

