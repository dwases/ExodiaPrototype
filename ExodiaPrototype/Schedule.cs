using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Schedule
    {
        public List<Day> days = new List<Day>();
        public Pracownik pracownik { get; set; }
        public Kierownik kierownik { get; set; }
        public Clock clock { get; set; }

        public Schedule(int days_count, Pracownik p, Kierownik k)
        {
            this.pracownik = p;
            this.kierownik = k;
            this.clock = new Clock();
            for (int i = 0; i < days_count; i++)
            {
                this.days.Add(new Day(i+1));
            }
        }
        public int add_Day(int day_id, TimeOnly start_time, TimeOnly end_time)
        {
            try
            {
                days[day_id].add_shift(start_time, end_time);
            }
            catch {
                Console.WriteLine("Shit");
                return -1;
            }
            return 0;
        }
        public int remove_Day(int day_id)
        {
            try
            {
                days[day_id].remove_shifts();
            }
            catch
            {
                return -1;
            }
            return 0;
        }
        
    }
}
