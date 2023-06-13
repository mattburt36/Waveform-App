namespace Waveform_App
{
    public class WaveClass
    {
        // Private variable declarations 
        #region Vars
        private static Thread? _WriteThread;
        private static Thread? _ReadThread;
        private static MASTER? _masterForm;
        private static bool _connected = false;
        #endregion

        // Publically accessible variables 
        #region getters/setters
        public static bool Connected
        {
            get { return _connected; }
        }
        #endregion

        // Trigger the wave thread
        public static void triggerThread(MASTER formObject)
        {
            _masterForm = formObject;

            // Create a writing thread that will control the type of signal being written to the ADP3450 
            _WriteThread = new Thread(write) 
            {
                Priority = ThreadPriority.Highest
            };

            // Create a readingg thread that will listen to the signal on the ADP3450 
            _ReadThread = new Thread(read)
            {
                Priority = ThreadPriority.Highest
            };

            _WriteThread.Start();
            _ReadThread.Start();
        }

        // Method to constantly write the type of sine wave selected in the combo box
        // sine wave for now
        public static void write()
        {
            //Write a sine wave to the output of the ADP3450 channel 0
        }

        // Method to listen to the values being read on the ADP3450
        public static void read()
        {
            // Listen to the signals on the ADP3450 for channel 0

        }

        // Connect the ADP3450 WFG to the PC
        public static bool connectWFG()
        {
            // Connect and check is connected
            
            return _connected;
        }
    }
}
