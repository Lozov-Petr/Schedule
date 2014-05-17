﻿using Editor.Models;

namespace Editor.ViewModels
{
    internal class SubtitleCardViewModel : ScheduleListenerViewModel
    {
        #region Properties

        #region Subtitle

        private string _subtitle;

        public string Subtitle
        {
            get { return _subtitle; }
            set
            {
                if (_subtitle != value)
                {
                    _subtitle = value;
                    RaisePropertyChanged(() => Subtitle);
                }
            }
        }

        #endregion

        #endregion

        #region Ctor

        public SubtitleCardViewModel(HavingName name)
        {
            Subtitle = name.Name;
        }

        #endregion

        protected override void ClassesScheduleOnPropertyChanged()
        {
            
        }
    }
}
