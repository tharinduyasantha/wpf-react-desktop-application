using Microsoft.Web.WebView2.Core;
using Wpf.Ui.Controls;
using WPFCompact.ViewModels.Pages;

namespace WPFCompact.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = ViewModel;

            InitializeComponent();
            InitializeWebView();
        }

        private void InitializeWebView()
        {
            webView.Loaded += InitializeWebView2;
        }

        private async void InitializeWebView2(object sender, RoutedEventArgs e)
        {
            if (webView.CoreWebView2 == null)
            {
                // Initialize CoreWebView2 for the WebView2 control
                await webView.EnsureCoreWebView2Async();
            }

            // Now you can subscribe to the WebMessageReceived event or any other event
            webView.CoreWebView2.WebMessageReceived += UpdateTextFromReactApp;
        }

        private void UpdateTextFromReactApp(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            string message = args.TryGetWebMessageAsString();
            if (!String.IsNullOrEmpty(message) )
            {
                // Update your WPF app's text or state here based on the message
                // For example, you might set some ViewModel property that's bound to your view
                ViewModel.ReactMessage = message;
            }
        }
        private void OnWpfButtonClickAsync(object sender, RoutedEventArgs e)
        {
            string newText = "Changed using WPF button";
            webView.ExecuteScriptAsync($"window.postMessage('{newText}', '*');");
        }
    }
}
