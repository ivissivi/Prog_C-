using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parts_Dealership
{
    public partial class CreateParts : Component
    {
        public CreateParts()
        {
            InitializeComponent();
        }

        public CreateParts(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carPart aCarPart = new carPart(this.Part);
            bCarParts.Add(aCarPart);
            CarPartBought();
        }

        public enum PartType
        {
            WinterTires,
            SummerTires,
            AllSeasonTires,
            BrakeFluid,
            WiperFluid,
            EngineOil,
            SparkPlug,
            CarBattery,
            BrakePads
        }

        private PartType bPart;

        public PartType Part
        {
            get
            {
                return bPart;
            }
            set
            {
                bPart = value;
            }
        }

        private System.Collections.ArrayList bCarParts = new System.Collections.ArrayList();

        public carPart this[int Index]
        {
            get
            {
                return (carPart)bCarParts[Index];
            }
            set
            {
                bCarParts[Index] = value;
            }
        }

        public delegate void CarPartBoughtDelegate();
        public event CarPartBoughtDelegate CarPartBought;

        public bool Enabled
        {
            set
            {
                tmrTimer.Enabled = value;
            }
        }

        public int Interval
        {
            set
            {
                tmrTimer.Interval = value;
            }
        }

        public void BuyCarParts(PartType partType)
        {
            Part = partType;
            switch (partType)
            {
                case PartType.WinterTires:
                    Interval = 3000;
                    break;

                case PartType.SummerTires:
                    Interval = 1700;
                    break;

                case PartType.AllSeasonTires:
                    Interval = 2800;
                    break;

                case PartType.BrakeFluid:
                    Interval = 3400;
                    break;

                case PartType.WiperFluid:
                    Interval = 3000;
                    break;

                case PartType.EngineOil:
                    Interval = 3000;
                    break;

                case PartType.SparkPlug:
                    Interval = 3000;
                    break;

                case PartType.CarBattery:
                    Interval = 1100;
                    break;

                case PartType.BrakePads:
                    Interval = 1800;
                    break;
            }
            Enabled = true;
        }

        public class carPart
        {
            private PartType bPart;
            private float bPrice = .50F;
            private readonly System.DateTime bTimeOfPurchase;

            public PartType Part
            {
                get
                {
                    return bPart;
                }
                set
                {
                    bPart = value;
                }
            }

            public float Price
            {
                get
                {
                    return bPrice;
                }
                set
                {
                    bPrice = value;
                }
            }

            public System.DateTime TimeOfCreation
            {
                get
                {
                    return bTimeOfPurchase;
                }
            }

            public carPart(PartType Part)
            {
                bTimeOfPurchase = System.DateTime.Now;
                bPart = Part;
            }
        }
    }
}
