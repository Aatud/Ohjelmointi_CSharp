/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course example file.
 * 
 * Created: 28/03/2016 
 * Authors: Pasi Manninen
 */

using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// A friend class to hold friend properties.
/// </summary>
namespace FriendsApp
{
    public class Friend : INotifyPropertyChanged
    {
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.        
        /// </summary>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                RaisePropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                RaisePropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged();
            }
        }

        private string info;
        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                RaisePropertyChanged();
            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                RaisePropertyChanged();
            }
        }

    }
}