// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Recurrence schedule for the job.
    /// </summary>
    public partial class JobRecurrence
    {
        private int? _count;
        
        /// <summary>
        /// Count of occurrences that will execute. Optional. Default will
        /// recur infinitely
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private System.DateTime? _endTime;
        
        /// <summary>
        /// Time in ISO-8601 format after which no more occurrences will
        /// execute.
        /// </summary>
        public System.DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private JobRecurrenceFrequency _frequency;
        
        /// <summary>
        /// The frequency of recurrence.
        /// </summary>
        public JobRecurrenceFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }
        
        private int? _interval;
        
        /// <summary>
        /// Interval of the recurrence at the given frequency.
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        private JobRecurrenceSchedule _schedule;
        
        /// <summary>
        /// Recurrence schedule for the job.
        /// </summary>
        public JobRecurrenceSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobRecurrence class.
        /// </summary>
        public JobRecurrence()
        {
        }
    }
}
