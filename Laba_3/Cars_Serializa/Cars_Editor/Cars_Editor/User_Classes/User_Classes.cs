using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cars_Editor.User_Classes
{
    [Serializable]
    public abstract class Car
    {
        public enum Transmission
        {
            Automatic,
            Mechanics
        }

        public string owner { get; set; }
        public string brand { get; set; }
        public Transmission transmission { get; set; }
        public Color color { get; set; }

        //public Car() { }

        public Car()
        {
            owner = "Person";
            transmission = Transmission.Automatic;
            color = Color.Black;
        }
    }

    [Serializable]
    public class Volkswagen : Car
    {
        //public enum volkswagen_model
        //{
        //    Amarok, Beetle, Bora, Caddy, Caravelle,
        //    Derby, Fox, Gol, Golf, Golf_Country, Jetta,
        //    Lupo, Multivan, Passat, Phaeton, Polo, Routan,
        //    Tiguan, Touareg, Touran, Vento
        //}

        public static string[] volkswagen_models =
        {
            "Amarok", "Beetle", "Bora", "Caddy", "Caravelle",
            "Derby", "Fox", "Gol", "Golf", "Golf_Country", "Jetta",
            "Lupo", "Multivan", "Passat", "Phaeton", "Polo", "Routan",
            "Tiguan", "Touareg", "Touran", "Vento"
        };

        public string model { get; set; }

        //public Volkswagen() { }

        public Volkswagen() : base()
        {
            brand = "Volkswagen";
            model = "Amarok";
        }
    }

    [Serializable]
    public class Audi : Car
    {
        //public enum audi_model
        //{
        //    A1, S1,
        //    A2, 
        //    A3, S3,
        //    A4, S4, RS4,
        //    A5, S5, RS5,
        //    A6, S6, RS6,
        //    A7, S7, RS7,
        //    A8, S8,
        //    Q2, Q3, Q4, Q5, Q6, Q7, Q8,
        //    TT
        //}

        public static string[] audi_models =
        {
            "A1", "S1",
            "A2",
            "A3", "S3",
            "A4", "S4", "RS4",
            "A5", "S5", "RS5",
            "A6", "S6", "RS6",
            "A7", "S7", "RS7",
            "A8", "S8",
            "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8",
            "TT"
        }; 

        public string model { get; set; }

        //public Audi() { }

        public Audi() : base()
        {
            brand = "Audi";
            model = "RS5";
        }
    }

    [Serializable]
    public class BMW : Car
    {
        //public enum bmw_model
        //{
        //    series_1,
        //    series_2,
        //    series_3,
        //    series_4,
        //    series_5,
        //    series_6,
        //    series_7,
        //    i3, i8,
        //    M2, M3, M4, M5, M6,
        //    X1, X2, X3, X4, X5, X6, X7
        //}
        public static string[] bmw_models =
        {
            "series_1", "series_2", "series_3", "series_4", "series_5", "series_6", "series_7",
            "i3", "i8",
            "M2", "M3", "M4", "M5", "M6",
            "X1", "X2", "X3", "X4", "X5", "X6", "X7"
        };

        public string model { get; set; }

        //public BMW() { }

        public BMW() : base()
        {
            brand = "BMW";
            model = "M5";
        }
    }

    [Serializable]
    public class Mersedes_Benz : Car
    {
        //public enum mersedes_model
        //{
        //    AMG_GT, Citan, CL, CL_AMG, CLA, CLA_AMG,
        //    CLC, CLK, CLS, CLS_AMG, GLA, GLA_AMG, 
        //    GLC, GLE, GLE_AMG, GLK, GLS, GLS_AMG, 
        //    MB, SL, SL_AMG, SLK, Vaneo, Viano, Vito

        //}

        public static string[] mersedes_model =
        {
            "AMG_GT", "Citan", "CL", "CL_AMG", "CLA", "CLA_AMG",
            "CLC", "CLK", "CLS", "CLS_AMG", "GLA", "GLA_AMG",
            "GLC", "GLE", "GLE_AMG", "GLK", "GLS", "GLS_AMG",
            "MB", "SL", "SL_AMG", "SLK", "Vaneo", "Viano", "Vito"
        };

        public string model { get; set; }

        //public Mersedes_Benz() { }

        public Mersedes_Benz() : base()
        {
            brand = "Mersedes_Benz";
            model = "AMG_GT";
        }
    }

    [Serializable]
    public class Mitsubishi : Car
    {
        //public enum mitsubishi_model
        //{
        //    ASX, Carisma, Colt, Delica, Eclipse,
        //    Galant, Grandis, L200, L300, Lancer,
        //    Mirage, Montero, Outlander, Pajero
        //}

        public static string[] mitsubishi_models =
        {
            "ASX", "Carisma", "Colt", "Delica", "Eclipse",
            "Galant", "Grandis", "L200", "L300", "Lancer",
            "Mirage", "Montero", "Outlander", "Pajero"
        };

        public string model { get; set; }

        //public Mitsubishi() { }

        public Mitsubishi() : base()
        {
            brand = "Mitsubishi";
            model = "Galant";
        }
    }

    [Serializable]
    public class Peugeot : Car
    {
        //public enum peugeot_model
        //{
        //    _3008, _301, _305, _306, _307,
        //    _308, _309, _4007, _4008, _405,
        //    _406, _407, _408, _605, _606, _607,
        //    Bipper, Expert, Partner, RCZ, Traveller
        //}

        public static string[] peugeot_models =
        {
            "_3008", "_301", "_305", "_306", "_307",
            "_308", "_309", "_4007", "_4008", "_405",
            "_406", "_407", "_408", "_605", "_606", "_607",
            "Bipper", "Expert", "Partner", "RCZ", "Traveller"
        };

        public string model { get; set; }

        //public Peugeot() { }

        public Peugeot() : base()
        {
            brand = "Peugeot";
            model = "_406";
        }

    }
}
