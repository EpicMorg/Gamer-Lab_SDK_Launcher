using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using glSDK.Annotations;

namespace glSDK.Pocos {
    [Serializable]
    public class Compilers: INotifyPropertyChanged {
        private List<Profile> _profiles = new List<Profile>();

        public List<Profile> Profiles
        {
            get
            {
                //OnPropertyChanged(nameof(Profiles));
                return _profiles;
            }
            set
            {
                _profiles = value;
                OnPropertyChanged( nameof(Profiles) );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null ) {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }

    [Serializable]
    public class Profile:INotifyPropertyChanged {
        private string _name;
        private string _gameExe;
        private string _mod;

        [XmlAttribute]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( _name == value ) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Command Game { get; set; } = new Command();

        public string Mod
        {
            get
            {
                return _mod;
            }
            set
            {
                if (_mod==value) return;
                _mod = value;
                OnPropertyChanged(nameof(Mod));
            }
        }

        public Command Csg { get; set; } = new Command();
        public Command Bsp { get; set; } = new Command();
        public Command Vis { get; set; } = new Command();
        public Command Rad { get; set; } = new Command();
        public override string ToString() => Name;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null ) {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }

    [Serializable]
    public class Command: INotifyPropertyChanged {
        private string _params;
        private string _path;

        [XmlAttribute]
        public string Params
        {
            get
            {
                return _params;
            }
            set
            {
                if ( _params == value ) return;
                _params = value;
                OnPropertyChanged(nameof(Params));
            }
        }

        [XmlText]
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if ( _path == value ) return;
                _path = value;
                OnPropertyChanged( nameof(Path) );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null ) {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}