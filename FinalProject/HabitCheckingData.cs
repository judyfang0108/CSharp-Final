using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class HabitCheckingData
    {
        public Data water = new Data();
        public Data workout = new Data();
        public Data meditation = new Data();
        public Data study = new Data();
        public int completed_habits_times = 0;
        public int now_doing_habits = 0;
    }
    public class Data
    {
        public bool is_build = false;
        public int total_times = 0;
        public int completed_times = 0;
        public int repeat_freq;
    }
}
