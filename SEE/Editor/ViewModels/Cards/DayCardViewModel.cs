﻿using Editor.Models;

namespace Editor.ViewModels.Cards
{
    class DayCardViewModel : ScheduleListenerViewModel
    {
        #region Properties

        #region Day

        private string _day;
        public string Day
        {
            get { return _day; }
            set
            {
                if (_day != value)
                {
                    _day = value;
                    RaisePropertyChanged(() => Day);
                }
            }
        }

        #endregion

        #endregion

        #region Ctor

        public DayCardViewModel(Weekdays day)
        {
            Day = day.ToString();
        }

        #endregion

        protected override void ClassesScheduleOnPropertyChanged()
        {
            
        }
    }
}
