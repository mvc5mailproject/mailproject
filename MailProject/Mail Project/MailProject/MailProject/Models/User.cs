using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailProject.Models
{
    /// <summary>
    /// Users class
    /// </summary>
    public class User
    {

    #region Fields

        private int userID;

        private string username;

        private string password;

        private string email;

        private DateTime created;

    #endregion

    #region Properties

        /// <summary>
        /// User ID
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// Username
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }     
  
        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }     
   
        /// <summary>
        /// Email address
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        } 

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

    #endregion

    #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {
            // TODO :
        }

    #endregion

    }
}