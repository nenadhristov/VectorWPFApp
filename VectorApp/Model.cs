using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using vector = VectorClass.VectorClass;
namespace VectorApp
{
    public class Model : INotifyPropertyChanged
    {
        private double Vector1x;
        private double Vector1y;
        private double Vector1z;

        private double Vector2x;
        private double Vector2y;
        private double Vector2z;

        public double Vector3x;

        public double Vector3y;

        public double Vector3z;

        public DelegateCommand Calculate { get; set; }

        public Model()
        {
            Calculate = new DelegateCommand(calculate);
        }



        public double vector1x
        {
            get
            {
                return Vector1x;
            }
            set
            {
                Vector1x = value;
                OnPropertyChanged("Vector1x");
            }
        }

        public double vector1y
        {
            get
            {
                return Vector1y;
            }
            set
            {
                Vector1y = value;
                OnPropertyChanged("Vector1y");
            }
        }

        public double vector1z
        {
            get
            {
                return Vector1z;
            }

            set
            {
                Vector1z = value;
                OnPropertyChanged("Vector1z");
            }
        }

        public double vector2x
        {
            get
            {
                return Vector2x;
            }

            set
            {
                Vector2x = value;
                OnPropertyChanged("Vector2x");
            }
        }

        public double vector2y
        {
            get
            {
                return Vector2y;
            }

            set
            {
                Vector2y = value;
                OnPropertyChanged("Vector2y");
            }
        }

        public double vector2z
        {
            get
            {
                return Vector2z;
            }

            set
            {
                Vector2z = value;
                OnPropertyChanged("Vector2z");
            }
        }
        public double vector3x
        {
            get
            {
                return Vector3x;
            }

            set
            {
                Vector3x = value;
                OnPropertyChanged("Vector3x");
            }
        }
        public double vector3y
        {
            get
            {
                return Vector3y;
            }

            set
            {
                Vector3y = value;
                OnPropertyChanged("Vector3y");
            }
        }

        public double vector3z
        {
            get
            {
                return Vector3z;
            }

            set
            {
                Vector3z = value;
                OnPropertyChanged("Vector3z");
            }
        }

        private void calculate(object param)
        {
            
            var vectorrezult = new vector();

            var vector1 = new vector(vector1x, vector1y, vector1z);

            var vector2 = new vector(vector2x, vector2y, vector2z);

            vectorrezult = vectorrezult.CrossProduct(vector1, vector2);

            vector3x = vectorrezult.x;
            vector3y = vectorrezult.y;
            vector3z = vectorrezult.z;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
