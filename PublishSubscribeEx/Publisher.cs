using System;
using System.Collections.Generic;
using System.Text;
using NetMQ;
using NetMQ.Sockets;

namespace PublishSubscribeEx
{
    public class Publisher
    {
        public void Publish()
        {

            using (var pubSocket = new PublisherSocket())
            {


                pubSocket.Bind("tcp://127.0.0.1");

                var msg = new BlockedOrder();

                pubSocket.SendMoreFrame("BlockedOrderTopic").SendFrame(msg.content);



            }
        }
    }
}