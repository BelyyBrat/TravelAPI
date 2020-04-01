using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual ApplicationUser User { get; set; }

        public static void Post(Review review)
        {
            string jsonDestination = JsonConvert.SerializeObject(review);
            var apiCallTask = ApiHelper.Post(jsonDestination);
        }

        public static void Put(Review review)
        {
            string jsonDestination = JsonConvert.SerializeObject(review);
            var apiCallTask = ApiHelper.Put(review.ReviewId, jsonDestination);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }

        public static Review GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

            return review;
        }

        public static List<Review> GetReviews()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Review> reviewsList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

            return reviewsList;
        }
    }


}