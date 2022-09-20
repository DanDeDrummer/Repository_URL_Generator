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

namespace Repository_URL_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string PERSONAL_ACCESS_TOKEN = "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";
        const string USERNAME = "DanDeDrummer";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string projectName = "";
            projectName = tbxProjectName.Text;
            if (projectName == "")
            {
                MessageBox.Show("Enter a Project name!");
                return;
            }
            //Create a string that adds the TOKEN into the link
            string output = "https://" + PERSONAL_ACCESS_TOKEN + "@github.com/" + USERNAME + "/" + projectName + ".git";
            tbxOutput.Text = output;
            projectName = "";

            //Clear all
            tbxProjectName.Text = "";
        }
    }
}
