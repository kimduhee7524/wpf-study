﻿namespace CustomControl.UI.Views
{
    internal class User
    {
        public object Name { get; private set; }
        public string Location { get; private set; }

        internal User GenData(string name, string location)
        {
            var user = new User();
            user.Name = name;
            user.Location = location;
            return user;
        }
    }
}