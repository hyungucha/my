using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NI_DAQ;
using Euresys;
using Base;
using DAQ.Viewer;
using DAQ.Common;

using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DAQ
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class App : Application
    {
        #region Private Member Variables

        #region Hardware Controller

        private Euresys.GrabLink _camera;

        private ImageViewerTest _imageViewerTestView;

        #endregion Hardware Controller

        #endregion Private Member Variables

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Window window = new NI_DAQ.MainWindow();
            Window window = new MainWindow();
            window.Show();
        }

        #region Private Methods

        private bool Initailize()
        {
            bool initResult = false;

            try
            {
                Parameters parameters = Parameters.Instance;

                Camera = new GrabLink();
                Camera.CameraParams = parameters.CameraParameters;

                initResult = Camera.InitializeCamera();
            }
            catch (Exception ex)
            {
                initResult = false;
            }

            return initResult;
        }


        #endregion Private Methods


        #region Constructors

        public App()
        {
            if (!Initailize())
            {
                Shutdown();
            }

            // Image
            ImageViewerTestView = new ImageViewerTest();

            ImageViewerTestView.Hide();
        }
        
        #endregion Constructors

        #region Public Properties

        public GrabLink Camera
        {
            get => _camera;
            set => _camera = value;
        }
        
        public ImageViewerTest ImageViewerTestView 
        { 
            get => _imageViewerTestView; 
            set => _imageViewerTestView = value; 
        }

        #endregion Public Properties
    }
}
