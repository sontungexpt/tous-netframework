﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToUs.Models
{
    public class TimeTableInfo
    {
        private string _name;
        private string _semester;
        private int _year;
        private List<DataScheduleRow> _selectedRows;
        private bool _isPreviewed;

        public bool IsPreviewed
        {
            get => _isPreviewed;
            set => _isPreviewed = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Semester
        {
            get => _semester;
            set => _semester = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public int DigitsCount
        {
            get
            {
                int count = 0;
                if (_selectedRows != null)
                {
                    for (int i = 0; i < _selectedRows.Count; i++)
                    {
                        if (_selectedRows[i].Subject.NumberOfDigits != null)
                            count += (int)_selectedRows[i].Subject.NumberOfDigits;
                    }
                }
                return count;
            }
        }

        public List<DataScheduleRow> SelectedRows
        {
            get
            {
                if (_selectedRows == null)
                    return new List<DataScheduleRow>();
                return _selectedRows;
            }
            set
            {
                _selectedRows = value;
            }
        }

        public void Refresh()
        {
            _name = null;
            _selectedRows = new List<DataScheduleRow>();
            _semester = null;
            _year = 0;
            _isPreviewed = false;
        }
    }
}