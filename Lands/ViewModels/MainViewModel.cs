using System;
using System.Collections.Generic;

namespace Lands.ViewModels
{
    public class MainViewModel
    {

        #region Properties
        public List<Models.Land> LandsList
        {
            get;
            set;
        }
        #endregion
        private static MainViewModel instance;//Objeto principal
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public LandsViewModel Lands
        {
            get;
            set;
        }
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Methods

        public static MainViewModel GetInstance()
        {
            if (instance == null)
                return new MainViewModel();
            return instance;
        }
        #endregion
    }
}
