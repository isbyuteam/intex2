using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intex2.Models
{
    public class CrashSeverityData
    {

        public float minute { get; set; }
        public float day { get; set; }
        public float hour { get; set; }
        public float month { get; set; }
        public bool motorcycle_involved_True { get; set; }
        public bool pedestrian_involved_True { get; set; }
        public bool overturn_rollover_True { get; set; }
        public bool bicyclist_involved_True { get; set; }
        public float year { get; set; }
        public bool teenage_driver_involved_True { get; set; }
        public bool day_of_week_Tuesday { get; set; }
        public bool day_of_week_Monday { get; set; }
        public bool unrestrained_True { get; set; }
        public bool day_of_week_Saturday { get; set; }
        public bool day_of_week_Wednesday { get; set; }
        public bool day_of_week_Thursday { get; set; }
        public bool night_dark_condition_True { get; set; }
        public bool roadway_departure_True { get; set; }
        public bool older_driver_involved_True { get; set; }
        public bool single_vehicle_True { get; set; }
        public bool day_of_week_Sunday { get; set; }
        public bool wild_animal_related_True { get; set; }
        public bool intersection_related_True { get; set; }
        public bool dui_True { get; set; }
        public bool work_zone_related { get; set; }
        public bool improper_restraint_True { get; set; }
        public bool city_PROVO { get; set; }
        public bool distracted_driving_True { get; set; }

        public float BoolToFloat(bool input)
        {
            if (input == true)
            {
                return 1f;
            }
            else
            {
                return 0;
            }
        }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                minute, day, hour,month,
                BoolToFloat(motorcycle_involved_True),
                BoolToFloat(pedestrian_involved_True),
                BoolToFloat(overturn_rollover_True),
                BoolToFloat(bicyclist_involved_True),
                year,
                BoolToFloat(teenage_driver_involved_True),
                BoolToFloat(day_of_week_Tuesday),
                BoolToFloat(day_of_week_Monday),
                BoolToFloat(unrestrained_True),
                BoolToFloat(day_of_week_Saturday),
                BoolToFloat(day_of_week_Wednesday),
                BoolToFloat(day_of_week_Thursday),
                BoolToFloat(night_dark_condition_True),
                BoolToFloat(roadway_departure_True),
                BoolToFloat(older_driver_involved_True),
                BoolToFloat(single_vehicle_True),
                BoolToFloat(day_of_week_Sunday),
                BoolToFloat(wild_animal_related_True),
                BoolToFloat(intersection_related_True),
                BoolToFloat(dui_True),
                BoolToFloat(work_zone_related),
                BoolToFloat(improper_restraint_True),
                BoolToFloat(city_PROVO),
                BoolToFloat(distracted_driving_True)
            };
            int[] dimensions = new int[] { 1, 28 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}

