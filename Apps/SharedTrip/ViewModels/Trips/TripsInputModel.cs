﻿namespace SharedTrip.ViewModels.Trips
{
    public class TripsInputModel
    {
        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public int Seats { get; set; }

        public string DepartureTime { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}
