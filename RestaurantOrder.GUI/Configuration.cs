using System.Configuration;

namespace RestaurantOrder.GUI
{
    /// <summary>
    /// Klasa udostepnia metody pobeirajace dane z pliku knfiguracyjnego App.config
    /// </summary>
    static class Configuration
    {

        public static string EmailUserName
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailUserName"] != null)
                {
                    return ConfigurationManager.AppSettings["EmailUserName"].ToString();
                }

                return string.Empty;
            }
        }

        public static string EmailUserNameTo
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailUserNameTo"] != null)
                {
                    return ConfigurationManager.AppSettings["EmailUserNameTo"].ToString();
                }

                return string.Empty;
            }
        }

        public static string EmailPassword
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailPassword"] != null)
                {
                    return ConfigurationManager.AppSettings["EmailPassword"].ToString();
                }

                return string.Empty;
            }
        }


        public static string EmailHost
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailHost"] != null)
                {
                    return ConfigurationManager.AppSettings["EmailHost"].ToString();
                }

                return string.Empty;
            }
        }

        public static int EmailPort
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailPort"] != null)
                {
                    int port = 0;
                    if (int.TryParse(ConfigurationManager.AppSettings["EmailPort"].ToString(), out port))
                    {
                        return port;
                    }
                }

                return 0;
            }
        }

        public static int EmailTimeout
        {
            get
            {
                if (ConfigurationManager.AppSettings["EmailTimeout"] != null)
                {
                    int timeout = 0;
                    if (int.TryParse(ConfigurationManager.AppSettings["EmailTimeout"].ToString(), out timeout))
                    {
                        return timeout;
                    }
                }

                return 5000;
            }
        }


       
    }
}
