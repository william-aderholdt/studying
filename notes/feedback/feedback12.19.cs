using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runPredictor
{
    class WeatherCardClass
    {
		// Changed them to private
		// used 'm' prefix for member standardization
        private string mTime;
        private int mTemp;
        private int mTempFeel;
        private int mPrecip;
        private int mWind;
        private bool mGoodRunTime;

		//passed in easy to use data. Dont need to do any computation. This should be done outside of the class
        public WeatherCardClass(string iTimeData, int iTempData, int iFeelData, int iPrecipData, int iWindData) {
			//Always use 'this.', it specifies that its a member variable.
			this.Time = iTimeData;
			this.Temp = iTempData;
			this.TempFeel = iFeelData;
			this.Precip = iPrecipData;
			this.Wind = iWindData;
            this.GoodRunTime = true;
        }
		// Getters and setters are public.
		// Setters can have some logic that determines if a 'bad' value was passed.
        public string Time {
            get {
                return this.mTime;
            }
            set {
				if(/*Good*/){
					this.mTime = value;
				}
            }
        }
		
        public int Temp {
            get {
                return this.mTemp;
            }
            set {
                this.mTemp = value;
            }
        }
		
        public int TempFeel {
            get {
                return this.mTempFeel;
            }
            set {
                this.mTempFeel = value;
            }
        }
		
        public int Precip {
            get {
                return this.Precip;
            }
            set {
                this.mPrecip = value;
            }
        }
		
        public int Wind {
            get {
                return this.mWind;
            }
            set {
                this.mWind = value;
            }
        }
		
        public int GoodRunTime {
            get {
                return this.mGoodRunTime;
            }
            set {
                this.mGoodRunTime = value;
            }
        }
		
		public override string ToString {
			
			return String.Format("Time:{0}, Temp:{1}, TempFeel:{2}, Precip:{3}, Wind:{4}, GoodRunTime:{5}",
								this.Time, this.Temp, this.TempFeel, this.Precip, this.Wind, this.GoodRunTime);
		}

        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.ReadLine();
        }
    }
}