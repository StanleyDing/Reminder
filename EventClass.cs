﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
     class EventClass : EventClassInterface
    {
        private string name;
        private DateTime due;
        private int importance;
        private bool isFinished;
        private bool isOverDated;
        private bool isMultiEvent;
        private ArrayList eventlist = new ArrayList();

        public EventClass(string name, DateTime due, int importance, bool isFinished, bool isOverDated, bool isMultiEvent, ArrayList eventlist)
        {
            this.name = name;
            this.due = due;
            this.importance = importance;
            this.isFinished = isFinished;
            this.isOverDated = isOverDated;
            this.isMultiEvent = isMultiEvent;
            this.eventlist = eventlist;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Due
        { get; set; }

        public int Importance
        {
            get { return importance; }
            set { importance = value; }
        }

        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }

        public bool IsOverDated
        {
            get
            {
                return DateTime.Now >= due;
            }
        }

        public bool IsMultiEvent
        {
            get { return isMultiEvent; }
            set { isMultiEvent = value; }
        }

        public ArrayList Eventlist
        {
            get { return Eventlist; }
        }

        public int ArraylistNumber
        {
            get { return Eventlist.Count; }
        }
    }
}
