using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K1Api.Models;
using K1Api.Context;


namespace K1Api.Repository
{
    public class FeedbackRepository : IDisposable
    {
        private FeedbackContext context;

        public FeedbackRepository(FeedbackContext context)
        {
            this.context = context;
        }

        public FeedbackRepository()
        {
            // To do: Complete member initialization
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return context.Feedbacks.ToList();
        }
        public IEnumerable<Feedback> GetFeedbackList()
        {
            return context.Feedbacks.ToList();
        }
       

        public Feedback InsertFeedback(Feedback feedback)
        {
            return context.Feedbacks.Add(feedback);
            
        }

        public Feedback DeleteFeedback(int feedbackId)
        {
            Feedback feedback = context.Feedbacks.Find(feedbackId);
            return context.Feedbacks.Remove(feedback);
        }

       
        //public bool Isreviewed()
        //{
        //    return context.
        //}to get pop up if customer has not given the reviews.

        public void Save()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }




    }

}
