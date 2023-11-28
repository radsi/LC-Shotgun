using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Gun
{
    class Utils
    {
        public class Main
        {
            public static bool IsIngame()
            {
                GameObject env = GameObject.Find("Environment");
                if (env != null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}