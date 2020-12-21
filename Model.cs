using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExpertSystem
{
    
    public class Model
    {
        public int Sum = 0;
        Dictionary<int, Configuration> ConfigDict = new Dictionary<int, Configuration>();
        int CheckBudget;
        Configuration config;
        
        public Model()
        {      
            CreateConfiguration();
        }

        
        public void GetOneQ(String temp)
        {
            switch (temp)
            {
                case "Ноутбук":
                    Sum = Sum + 100;
                    break;
                case "Стационарный ПК":
                    Sum = Sum + 0;
                    break;
            }
        }

        public void GetTwoQ(string temp)
        {
            switch (temp)
            {
                case "Бюджетный":
                    Sum += 10;
                    break;
                case "Семейный":
                    Sum += 20;
                    break;
                case "Профессиональный":
                    Sum += 30;
                    break;
            }
            /*if (temp <= 50000)
                Sum += 10;

            else if (temp <= 90000 && temp > 50000)
                Sum += 20;

            else if (temp > 90000)
                Sum += 30;*/
       
        }

        public void GetThreeQ(String temp)
        {
            switch (temp)
            {
                case "Программирование":
                    Sum = Sum + 1;
                    break;
                case "Игры":
                    Sum = Sum + 2;
                    break;
                case "Монтаж видео":
                    Sum = Sum + 2;
                    break;
                case "Звукорежиссура":
                    Sum = Sum + 2;
                    break;
                case "Рисование":
                    Sum = Sum + 1;
                    break;
                case "Работа с документами":
                    Sum = Sum + 3;
                    break;

            }
        }

        public Configuration PickUpConfiguration()
        {
            return config;
        }

        public void FixateConfiguration()
        {
            config = ConfigDict[Sum];
        }

        private void CreateConfiguration()
        {
            string contents = File.ReadAllText(@"ConfigSource.xml");
            Debug.WriteLine(contents);
            ConfigDict = XmlParser.Desirialize(contents);
        }

        public string[] CPU()
        {
            string[] temp1 = { "AMD Athlon X4 840 OEM", "AMD A6-7480 OEM", "Intel Celeron G5905 OEM", "Intel Celeron G5920 OEM","Intel Pentium Gold G6400 OEM", "AMD Athlon 3000G OEM" };
            string[] temp2 = { "AMD Ryzen 5 3500X OEM", "Intel Core i5-9400F BOX", "AMD Ryzen 7 2700 OEM", "AMD Ryzen 5 2600X BOX", "Intel Core i3-10300 OEM", "Intel Core i5-9400 OEM" };
            string[] temp3 = { "Intel Core i9-10900F BOX", "Intel Core i9-10850K OEM", "Intel Core i9-10900 OEM", "AMD Ryzen 9 3900X OEM", "AMD Ryzen 9 3900X BOX" };
            CheckBudget = (Sum % 100)/10;
            switch(CheckBudget)
            {
                case 1:
                    return temp1;
                case 2:
                    return temp2;
                case 3:
                    return temp3;
            }
            return null;
        }

        public string[] GPU()
        {
            string[] temp1 = { "NNO3D GeForce GT 710 Silent LP [N710-1SDV-E3BX]", "ASUS GeForce GT 710 Silent LP [GT710-SL-1GD5-BRK]", "ASUS GeForce GT 710 Silent LP [GT710-SL-2GD5]", "PowerColor AMD Radeon RX 550 Red Dragon[AXRX 550 2GBD5 - DH]" };
            string[] temp2 = { "ASUS GeForce GTX 1050 Ti Cerberus Advanced Edition [CERBERUS-GTX1050TI-A4G]", "MSI GeForce GTX 1650 LP OC [GTX 1650 4GT LP OC]", "MSI AMD Radeon RX 570 ARMOR OC [RX 570 ARMOR 4G OC]", "AMD Radeon Pro WX 2100 [Pro WX 2100]" };
            string[] temp3 = { "KFA2 GeForce RTX 3090 SG (1-Click OC) [39NSM5MD1GNK]", "PNY Quadro RTX 4000 [VCQRTX4000-PB]", "Zotac GAMING GeForce RTX 3090 Trinity [ZT-A30900D-10P]" };
            CheckBudget = (Sum % 100) / 10;
            switch (CheckBudget)
            {
                case 1:
                    return temp1;
                case 2:
                    return temp2;
                case 3:
                    return temp3;
            }
            return null;
        }

        public string[] StorageDevice()
        {
            string[] temp1 = { "128 Gb", "256 Gb" };
            string[] temp2 = { "128 Gb", "256 Gb", "512 Gb", "1 TB" };
            string[] temp3 = { "128 Gb", "256 Gb", "512 Gb", "1 TB", "2 TB" };
            CheckBudget = (Sum % 100) / 10;
            switch (CheckBudget)
            {
                case 1:
                    return temp1;
                case 2:
                    return temp2;
                case 3:
                    return temp3;
            }
            return null;
        }

        public string[] RAM()
        {
            string[] temp1 = { "2 Gb", "2 Gb X2" };
            string[] temp2 = { "4 Gb", "4 Gb x2", "8 Gb" };
            string[] temp3 = { "8 Gb x2", "16 Gb", "16 Gb x2", "32 Gb" };
            CheckBudget = (Sum % 100) / 10;
            switch (CheckBudget)
            {
                case 1:
                    return temp1;
                case 2:
                    return temp2;
                case 3:
                    return temp3;
            }
            return null;
        }

        public void ChangeCPU(string temp)
        {
            if(temp=="")
            {
                return;
            }
            config.CPU = temp;
        }

        public void ChangeGPU(string temp)
        {
            if (temp == "")
            {
                return;
            }
            config.GPU = temp;
        }

        public void ChangeSD(string temp1,string temp2)
        {
            if (temp1 == "" || temp2 == "")
            {
                return;
            }
            if (temp1 == "HDD" && temp2 == "128 Gb")
            {
                config.StorageDevice = "Western Digital HDD 128 Gb";
            }
            if (temp1 == "HDD" && temp2 == "256 Gb")
            {
                config.StorageDevice = "Seagate HDD 256 Gb";
            }
            if (temp1 == "HDD" && temp2 == "512 Gb")
            {
                config.StorageDevice = "SAMSUNG HDD 512 Gb";
            }
            if (temp1 == "HDD" && temp2 == "1 TB")
            {
                config.StorageDevice = "SAMSUNG HDD 1 TB";
            }
            if (temp1 == "HDD" && temp2 == "2 TB")
            {
                config.StorageDevice = "Fujitsu HDD 2 TB";
            }
            if (temp1 == "SSD" && temp2 == "128 Gb")
            {
                config.StorageDevice = "HP SSD 128 Gb";
            }
            if (temp1 == "SSD" && temp2 == "256 Gb")
            {
                config.StorageDevice = "Western Digital SSD 256 Gb";
            }
            if (temp1 == "SSD" && temp2 == "512 Gb")
            {
                config.StorageDevice = "SAMSUNG SSD 512 Gb";
            }
            if (temp1 == "SSD" && temp2 == "1 TB")
            {
                config.StorageDevice = "SAMSUNG SSD 1 TB";
            }
            if (temp1 == "SSD" && temp2 == "2 TB")
            {
                config.StorageDevice = "IBM SSD 2 TB";
            }
        }

        public void ChangeRAM(string temp)
        {
            if (temp == "")
            {
                return;
            }
            config.RAM = temp;
        }
    }
}
