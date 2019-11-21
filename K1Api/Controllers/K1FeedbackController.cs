using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using K1Api.Repository;
using K1Api.Models;
using K1Api.Context;

namespace K1Api.Controllers
{
    public class K1FeedbackController : ApiController
    {
        FeedbackRepository feedRepositoryObj = new FeedbackRepository(new FeedbackContext());

        [HttpGet]
        [Route("api/Feedback/Get")]
        public IHttpActionResult GetFeedback()
        {
            List<Feedback> feedbackList = feedRepositoryObj.GetFeedbacks().ToList();

            try
            {
                return Ok(feedbackList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Feedback/List")]
        public IHttpActionResult GetFeedbackList()
        {
            List<Feedback> feedbackList = feedRepositoryObj.GetFeedbackList().ToList();
            try
            {
                return Ok(feedbackList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);//dont use notfound always return any message 
            }
        }



        [HttpPost]
        [Route("api/Feedback/Insert")]
        public IHttpActionResult InsertFeedbacks([FromBody]Feedback feedback)
        {
            Feedback addFeedback = feedRepositoryObj.InsertFeedback(feedback);
            feedRepositoryObj.Save();
            try
            {
                return Ok("feedback inserted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Feedback/Delete")]
        public IHttpActionResult DeleteFeedback([FromBody]int feedbackId)
        {
            Feedback delFeedback = feedRepositoryObj.DeleteFeedback(feedbackId);
            feedRepositoryObj.Save();
            try
            {
                return Ok("feedback deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}



