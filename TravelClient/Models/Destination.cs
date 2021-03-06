
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public virtual ApplicationUser User { get; set; }
        public static List<Destination> GetAll()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

            return destinationList;
        }

        public static Destination Get(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            var destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());

            return destination;
        }

        public static List<Destination> GetByReviews()
        {
            var apiCallTask = ApiHelper.GetByReviews();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

            return destinationList;
        }

        public static List<Destination> GetByRatings()
        {
            var apiCallTask = ApiHelper.GetByRatings();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

            return destinationList;
        }
        public static List<Destination> Search(string city, string country)
        {
            var apiCallTask = ApiHelper.Search(city, country);
            var result = apiCallTask.Result;
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());
            return destinationList;
        }
        public static void Post(Destination destination)
        {
            string jsonDestination = JsonConvert.SerializeObject(destination);
            var apiCallTask = ApiHelper.Post(jsonDestination);
        }

        public static void Put(Destination destination)
        {
            string jsonDestination = JsonConvert.SerializeObject(destination);
            var apiCallTask = ApiHelper.Put(destination.DestinationId, jsonDestination);
        }
        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}