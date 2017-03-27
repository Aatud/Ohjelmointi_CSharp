using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace FriendsApp
{
    /// <summary>
    /// Add a new friend page.
    /// </summary>
    public sealed partial class AddPage : Page
    {
        // add/modify friend
        private Friend friend;
        // link to main page collection
        private ObservableCollection<Friend> friends;
        // employee image file
        private StorageFile file;

        // constructor
        public AddPage()
        {
            this.InitializeComponent();
        }

        // page is navigated to
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            // add
            if (e.Parameter is ObservableCollection<Friend>)
            {
                friends = (ObservableCollection<Friend>)e.Parameter;
                AddButton.Content = "Add";
            }
            // modify
            if (e.Parameter is Friend)
            {
                friend = (Friend)e.Parameter;
                NameTextBox.Text = friend.Name;
                AddressTextBox.Text = friend.Address;
                PhoneTextBox.Text = friend.Phone;
                EmailTextBox.Text = friend.Email;
                InfoTextBox.Text = friend.Info;
                // image
                try
                {
                    StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                    StorageFile file = await localFolder.GetFileAsync(friend.Image);
                    var stream = await file.OpenAsync(FileAccessMode.Read);
                    BitmapImage image = new BitmapImage();
                    image.SetSource(stream);
                    FriendImage.Source = image;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Cannot read friends image from the disk!");
                    Debug.WriteLine(ex);
                }
                AddButton.Content = "Modify";
            }
            base.OnNavigatedTo(e);
        }

        // add/modify button clicked
        private async void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // add a new
            if (AddButton.Content.ToString().EndsWith("Add"))
            {
                friend = new Friend();
            }
            // add / modify data
            friend.Name = NameTextBox.Text;
            friend.Address = AddressTextBox.Text;
            friend.Email = EmailTextBox.Text;
            friend.Phone = PhoneTextBox.Text;
            friend.Info = InfoTextBox.Text;
            // copy image to app local folder
            if (file != null)
            {
                friend.Image = file.Name;
                await file.CopyAsync(ApplicationData.Current.LocalFolder, file.Name, NameCollisionOption.ReplaceExisting);
            }
            // add
            if (AddButton.Content.ToString().EndsWith("Add"))
            {
                friends.Add(friend);
            }
            NavigateBack();
        }

        // cancel button clicked
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateBack();
        }

        // navigate back to main page
        private void NavigateBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        // get a new friend image from the system
        private async void FriendImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // create file open picker
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".png");

            // open
            file = await openPicker.PickSingleFileAsync();
            // show
            if (file != null)
            {
                var stream = await file.OpenAsync(FileAccessMode.Read);
                BitmapImage image = new BitmapImage();
                image.SetSource(stream);
                FriendImage.Source = image;
            }
        }
    }
}