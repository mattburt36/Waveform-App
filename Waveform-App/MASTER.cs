using System.Diagnostics;

namespace Waveform_App
{
    public partial class MASTER : Form
    {
        readonly double[] Values = new double[25];
        readonly Stopwatch Stopwatch = Stopwatch.StartNew();

        public MASTER()
        {
            InitializeComponent();
            UpdateValues();
            formsPlot1.Plot.AddSignal(Values);
        }

        public void UpdateValues()
        {
            double phase = Stopwatch.Elapsed.TotalSeconds;
            double multiplier = 2 * Math.PI / Values.Length;
            for (int i = 0; i < Values.Length; i++)
                Values[i] = Math.Sin(i * multiplier + phase);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateValues();
            formsPlot1.Render();
        }

    }
}