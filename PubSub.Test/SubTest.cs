using PublishSubscribeEx;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace PubSub.Test
{
    public class SubTest
    {
        [Fact]
        public void Sub_to_evt()
        {
            var pub1 = new Publisher();
            var sub1 = new Subscriber("BlockedOrderTopic");
            sub1.Subscribe();
            pub1.Publish();

            Assert.Equal(" blockedOrderMsg", sub1.GetMsg());


        }
    }
}
