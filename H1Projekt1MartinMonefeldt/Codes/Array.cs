using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes;
{
    internal class MyArray
    {
        public string[,,] Cources_MultiDimensional { get; set; }

        public string[][] CourcesJagged { get; set; }

        public MyArray()
        {
            Cources_MultiDimensional = new string[,,]
            {
                {
                    // H1 Programmeringslinje:
                    {"Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog."},
                    // H2 Programmeringslinje:
                    {"Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog."}
                },
                {
                    // H1 Supportlinje:
                    {"Grund. Server Opsætninger", "Db Server", "Web Server", "Linux Server", "Netværk", "OS"},
                    // H2 Supportlinje:
                    {"LAN Netværk", "WAN Netværk", "Db Admin.", "Web Admin.", "Linux Cluster Admin", "Hypervisor"},
                }
            };
        }

        public string GetCourseInfo(string courseName)
        {
            string returnText = "";
            // new string[rowsInThirdDimension,rowsInSecondDimension,columnCount]
            int rowsInThirdDimension = Cources_MultiDimensional.GetLength(0);
            int rowsInSecondDimension = Cources_MultiDimensional.GetLength(1);
            int columnCount = Cources_MultiDimensional.GetLength(2);

            for (int rowIndex3D = 0; rowIndex3D < rowsInThirdDimension; rowIndex3D++)
            {
                for (int rowIndex2D = 0; rowIndex2D < rowsInSecondDimension; rowIndex2D++)
                {
                    for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                    {
                        string s = Cources_MultiDimensional[rowIndex3D, rowIndex2D, columnIndex];
                        if (s == courseName)
                        {
                            if (rowIndex3D == 0)
                                returnText = "Programmeringslinje";
                            else if (rowIndex3D == 1)
                                returnText = "Supportlinje";

                            if (rowIndex2D == 0)
                                returnText = returnText + ", H1";
                            else if (rowIndex2D == 1)
                                returnText = returnText + ", H2";

                            break;
                        }
                    }
                }
            }

            return returnText;
        }
    }
}