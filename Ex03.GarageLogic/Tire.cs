﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    //public enum eTireParameters
    //{
    //    ManufacturerName,
    //    CurrentPSI,
    //    MaxValidPSI
    //}

    public class Tire
    {
        public const int k_MinCharsForTireManufacturerName = 4;
        public const int k_MaxCharsForTireManufacturerName = 48;
        private string m_ManufacturerName;
        private float m_CurrentPSI;
        private readonly float m_MaxValidPSI;

        public Tire (float i_MaxValidPSI) // c'tor
        {
            m_MaxValidPSI = i_MaxValidPSI;
            m_ManufacturerName = null;
            m_CurrentPSI = 0;
        }

        //properties
        public float CurrentPSI
        {
            get
            {
                return m_CurrentPSI;
            }
            set
            {
                m_CurrentPSI = value;
            }
        }

        public float MaxPSI
        {
            get
            {
                return m_MaxValidPSI;
            }
        }

        public string ManufacturerName
        {
            get
            {
                return m_ManufacturerName;
            }
            set
            {
                m_ManufacturerName = value;
            }
        }

        public void InflateTire(float i_AmountOfPsiToAdd)
        {
            if(m_MaxValidPSI - m_CurrentPSI < i_AmountOfPsiToAdd)
            {
                throw new ValueOutOfRangeException(m_MaxValidPSI - m_CurrentPSI, 0, eOutOfRangeTypes.Number);
            }
            else
            {
                m_CurrentPSI += i_AmountOfPsiToAdd;
            }
        }

        
    }
}
