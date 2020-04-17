using PublishSubscribeEx;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PubCode;
using SubCode;
using Xunit;
namespace PubSub.Test
{
    public class SubTest
    {
        [Fact]
        public void Sub_to_Pub()
        {
            var pub1 = new Publisher();
            var sub1 = new Subscriber();
            sub1.SetTopic("BlockedOrderTopic");
            sub1.Subscribe();
            pub1.Publish();


            Assert.Equal(" BlockedOrderCreatedMsg", sub1.GetMsg());


        }
    }
}
