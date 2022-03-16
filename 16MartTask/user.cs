using System;
using System.Collections.Generic;
using System.Text;

namespace _16MartTask
{
    internal class user
    {
        
        private string _username;
        private string _password;
        public bool _check;

        public string Username
        {
            get { return _username; }
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length >=6 && value.Length <=25){
                    this._username = value;
                }
            }
        }
        public string Password
        {
            get { return this._password; }
            set
            {
                if (!string.IsNullOrEmpty(value) &&value.Length >= 8 && value.Length <= 25)
                {

                    int count = 0;
                    int count2 = 0;
                    int count3 = 0;
                    

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsUpper(value[i]))
                        {
                            count = 1;
                        }
                        else if (char.IsLower(value[i]))
                        {
                            count2 = 1;

                        }
                        else if (char.IsDigit(value[i]))
                        {
                            count3 = 1;
                        }
                        
                    }
                    if (count == 1 && count2 == 1 && count3 == 1)
                    {
                        this._password = value;
                    }

                }
            }
        }
        public bool HasDigit (string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count = 1;
                }
                if (count == 1)
                {
                    return true;
                }
                
            }
            return false;
        } 

        public bool HasUpper (string str)
        {
            int count = 0; 
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                   count = 1;
                }
                if (count == 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    count = 1;
                }
                if (count == 1)
                {
                    return true;
                }
            }
            return false;
        }



    }
    }

