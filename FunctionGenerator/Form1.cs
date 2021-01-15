using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments;

namespace FunctionGenerator
{
    public partial class Form1 : Form
    {
        public double[] outputArray;
        public double[] time;
        public bool flag = false;
        private NationalInstruments.DAQmx.Task analogTask;
        public Form1()
        {
            InitializeComponent();
            dutyCycle.Enabled = false;
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            
            double amp = Convert.ToDouble(amplitude.Value);
            double dutyCYCLE = Convert.ToDouble(dutyCycle.Value);
            int freq = Convert.ToInt32(frequencySelector.Value);
            double dcOFF = Convert.ToDouble(dcOffset.Value);
            int sampleRate = 900000;

            int samples = sampleRate/freq;

            outputArray = new double[samples];
            time = new double[samples];

            if(flag != true)
            {
                //// creating the new task
                //analogTask = new NationalInstruments.DAQmx.Task();

                //// disabling and enabling buttons
                //outputBtn.Enabled = false;
                //Stop.Enabled = true;

                //// combining string for dev name and input ports
                //string devAndChannels = devPort.Text;
            }
            else
            {
                chart1.Series.Clear();
                for (int i = 0; i < samples; i++)
                {
                    time[i] = 0;
                    outputArray[i] = 0;
                }
            }
            //flag = false;
            

            

            if (wavFormBox.Text == "Sine" || wavFormBox.Text == "Triangle" || wavFormBox.Text == "Square" || wavFormBox.Text == "Sawtooth")
            {
                
                    double value = 0;
                    double timeValue = 0.0;
                    if(wavFormBox.Text == "Sine")
                    {
                       for(int i = 0; i < samples; i++)
                       {
                           time[i] = timeValue;
                           outputArray[i] = amp*Math.Sin(value);

                           value = value + (2*Math.PI)/samples;
                           timeValue = timeValue + 1;
                       }
                     
                     for (int p = 0; p < samples; p++)
                        {
                            chart1.Series[0].Points.AddXY(time[p], outputArray[p]);
                            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        }
                       
                        

                    }
                    if(wavFormBox.Text == "Triangle")
                    {

                    }
                    if(wavFormBox.Text == "Square")
                    {

                    }
                    if(wavFormBox.Text == "Sawtooth")
                    {

                    }

                    //// write data to stream here.
                    //analogTask.AOChannels.All.UseOnlyOnBoardMemory = true;
                    //// creating the channel
                    //analogTask.AOChannels.CreateVoltageChannel(devAndChannels, "", -1 * Convert.ToDouble(amplitude.Value), Convert.ToDouble(amplitude.Value), NationalInstruments.DAQmx.AOVoltageUnits.Volts);
                    //NationalInstruments.DAQmx.AnalogSingleChannelWriter writer = new NationalInstruments.DAQmx.AnalogSingleChannelWriter(analogTask.Stream);
                
            }
            else
            {
                // create a digital channel here.


            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            outputBtn.Enabled = true;
            Stop.Enabled = false;
        }

        private void wavFormBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = true;
            // if the user changes the type of wave either enable or disable certain selections
            if(wavFormBox.Text == "Sine")
            {
                amplitude.Enabled = true;
                dutyCycle.Enabled = false;
                dcOffset.Enabled = true;
            }
            else if (wavFormBox.Text == "Triangle")
            {
                amplitude.Enabled = true;
                dutyCycle.Enabled = true;
                dcOffset.Enabled = true;
            }
            else if (wavFormBox.Text == "SawTooth")
            {
                amplitude.Enabled = true;
                dutyCycle.Enabled = false;
                dcOffset.Enabled = true;
            }
            else if (wavFormBox.Text == "Square")
            {
                amplitude.Enabled = true;
                dutyCycle.Enabled = true;
                dcOffset.Enabled = true;
            }
            else if (wavFormBox.Text == "TTL")
            {
                amplitude.Enabled = false;
                dutyCycle.Enabled = true;
                dcOffset.Enabled = false;
            }
            else
            {
                // do nothing probably should exit
                // because something is wrong.
                Application.Exit();
            }
            outputBtn_Click(sender, e);
        }

        private void frequencySelector_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            outputBtn_Click(sender, e);
        }

        private void dutyCycle_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            outputBtn_Click(sender, e);
        }

        private void dcOffset_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            outputBtn_Click(sender, e);
        }

        private void amplitude_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            outputBtn_Click(sender, e);
        }
    }
}
